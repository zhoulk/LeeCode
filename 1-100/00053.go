package main

// 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。

// 示例:

// 输入: [-2,1,-3,4,-1,2,1,-5,4],
// 输出: 6
// 解释: 连续子数组 [4,-1,2,1] 的和最大，为 6。
// 进阶:

// 如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的分治法求解。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/maximum-subarray
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

const INT_MAX = int(^uint(0) >> 1)
const INT_MIN = ^INT_MAX

// func maxSubArray(nums []int) int {
// 	len := len(nums)
// 	index := 0
// 	max := INT_MIN
// 	sum := 0
// 	for index < len {
// 		sum = 0
// 		for i := index; i < len; i++ {
// 			sum += nums[i]

// 			if sum > max {
// 				max = sum
// 			}
// 		}
// 		index++
// 	}
// 	return max
// }

func maxValue(a int, b int) int {
	if a > b {
		return a
	}
	return b
}

func maxSubArray(nums []int) int {
	len := len(nums)
	index := 0
	max := INT_MIN
	sum := 0
	for index < len {
		sum = maxValue(sum+nums[index], nums[index])
		max = maxValue(sum, max)
		index++
	}
	return max
}

// func main() {
// 	nums := []int{-1}
// 	res := maxSubArray(nums)
// 	fmt.Println(res)
// }
