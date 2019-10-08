package main

import "fmt"

// 设计一个支持 push，pop，top 操作，并能在常数时间内检索到最小元素的栈。

// push(x) -- 将元素 x 推入栈中。
// pop() -- 删除栈顶的元素。
// top() -- 获取栈顶元素。
// getMin() -- 检索栈中的最小元素。
// 示例:

// MinStack minStack = new MinStack();
// minStack.push(-2);
// minStack.push(0);
// minStack.push(-3);
// minStack.getMin();   --> 返回 -3.
// minStack.pop();
// minStack.top();      --> 返回 0.
// minStack.getMin();   --> 返回 -2.

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/min-stack
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

type MinStack struct {
	nums   []int
	origin []int
}

/** initialize your data structure here. */
func Constructor() MinStack {
	return MinStack{
		origin: make([]int, 0),
		nums:   make([]int, 0),
	}
}

func (this *MinStack) Push(x int) {
	this.origin = append(this.origin, x)

	l := len(this.nums)
	if l == 0 {
		this.nums = append(this.nums, len(this.origin)-1)
	} else {
		flag := false
		for i := 0; i < l; i++ {
			if x > this.origin[this.nums[i]] {
				temp := append([]int{}, len(this.origin)-1)
				temp = append(temp, this.nums[i+1:]...)
				// fmt.Println("temp", temp)
				this.nums = append(this.nums[0:i+1], temp...)
				flag = true
				break
			}
		}
		if !flag {
			temp := append([]int{}, len(this.origin)-1)
			this.nums = append(temp, this.nums...)
		}
	}

	// fmt.Println("push", this.nums, this.origin)
}

func (this *MinStack) Pop() {
	l := len(this.origin)
	if l > 0 {
		this.origin = this.origin[:l-1]

		nl := len(this.nums)
		for i := 0; i < nl; i++ {
			if this.nums[i] == len(this.origin) {
				// fmt.Println("pop  ", i)
				if i == nl-1 {
					this.nums = this.nums[0:i]
				} else {
					this.nums = append(this.nums[0:i], this.nums[i+1:]...)
				}
				break
			}
		}
	}
}

func (this *MinStack) Top() int {
	l := len(this.origin)
	if l > 0 {
		return this.origin[l-1]
	}
	return 0
}

func (this *MinStack) GetMin() int {
	l := len(this.nums)
	if l > 0 {
		if this.nums[0] < len(this.origin) {
			return this.origin[this.nums[0]]
		}
	}
	return 0
}

/**
 * Your MinStack object will be instantiated and called as such:
 * obj := Constructor();
 * obj.Push(x);
 * obj.Pop();
 * param_3 := obj.Top();
 * param_4 := obj.GetMin();
 */

func main() {
	minStack := Constructor()
	minStack.Push(-2)
	minStack.Push(0)
	minStack.Push(-3)
	// minStack.getMin();   --> 返回 -3.
	fmt.Println(minStack.GetMin())
	minStack.Pop()
	// minStack.Top() //--> 返回 0.
	fmt.Println(minStack.Top())
	// minStack.getMin();   --> 返回 -2.
	fmt.Println(minStack.GetMin())
}
