package main

// 编写一个算法来判断一个数是不是“快乐数”。

// 一个“快乐数”定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，然后重复这个过程直到这个数变为 1，也可能是无限循环但始终变不到 1。如果可以变为 1，那么这个数就是快乐数。

// 示例:

// 输入: 19
// 输出: true
// 解释:
// 12 + 92 = 82
// 82 + 22 = 68
// 62 + 82 = 100
// 12 + 02 + 02 = 1

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/happy-number
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func calNum(n int) int {
	ret := 0
	for n > 0 {
		ret += (n % 10) * (n % 10)
		n = n / 10
	}
	return ret
}

func isHappy(n int) bool {
	slow := calNum(n)
	fast := calNum(n)
	fast = calNum(fast)
	for slow != fast {
		slow = calNum(slow)
		fast = calNum(fast)
		fast = calNum(fast)
	}
	if slow == 1 {
		return true
	} else {
		return false
	}
}

// func main() {
// 	ret := isHappy(19)
// 	fmt.Println(ret)
// }
