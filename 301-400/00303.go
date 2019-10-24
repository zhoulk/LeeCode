package main

// 给定一个整数数组  nums，求出数组从索引 i 到 j  (i ≤ j) 范围内元素的总和，包含 i,  j 两点。

// 示例：

// 给定 nums = [-2, 0, 3, -5, 2, -1]，求和函数为 sumRange()

// sumRange(0, 2) -> 1
// sumRange(2, 5) -> -1
// sumRange(0, 5) -> -3
// 说明:

// 你可以假设数组不可变。
// 会多次调用 sumRange 方法。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/range-sum-query-immutable
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

type NumArray struct {
	_nums []int
}

func Constructor(nums []int) NumArray {
	return NumArray{
		_nums: nums,
	}
}

func (this *NumArray) SumRange(i int, j int) int {
	nl := len(this._nums)
	if nl < j || nl < i {
		return 0
	}

	sum := 0
	for x := i; x <= j; x++ {
		sum += this._nums[x]
	}
	return sum
}

/**
 * Your NumArray object will be instantiated and called as such:
 * obj := Constructor(nums);
 * param_1 := obj.SumRange(i,j);
 */

// func main() {
// 	nums := []int{-2, 0, 3, -5, 2, -1}
// 	obj := Constructor(nums)
// 	param_1 := obj.SumRange(1, 2)

// 	fmt.Println(param_1)
// }
