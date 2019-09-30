package main

// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

// 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

// 示例:

// 给定 nums = [2, 7, 11, 15], target = 9

// 因为 nums[0] + nums[1] = 2 + 7 = 9
// 所以返回 [0, 1]

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/two-sum
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

// func twoSum(nums []int, target int) []int {
// 	res := make([]int, 0)
// 	for i := 0; i < len(nums)-1; i++ {
// 		for j := i + 1; j < len(nums); j++ {
// 			if nums[i]+nums[j] == target {
// 				res = append(res, i)
// 				res = append(res, j)
// 				return res
// 			}
// 		}
// 	}
// 	return res
// }

// func twoSum(nums []int, target int) []int {

// 	temp := make(map[int]int)
// 	for i := 0; i < len(nums); i++ {
// 		temp[nums[i]] = i
// 	}

// 	res := make([]int, 0)
// 	for i := 0; i < len(nums)-1; i++ {
// 		other := target - nums[i]
// 		if _, ok := temp[other]; ok {
// 			if temp[other] != i {
// 				res = append(res, i)
// 				res = append(res, temp[other])
// 				return res
// 			}
// 		}
// 	}
// 	return res
// }

func twoSum(nums []int, target int) []int {
	lenOfNums := len(nums)
	temp := make(map[int]int, lenOfNums)
	for i := 0; i < lenOfNums; i++ {
		other := target - nums[i]
		if ic, ok := temp[other]; ok {
			if ic != i {
				return []int{i, ic}
			}
		} else {
			temp[nums[i]] = i
		}
	}
	return nil
}

// func twoSum(nums []int, target int) []int {
// 	lenOfNums := len(nums)
// 	m := make(map[int]int, lenOfNums)
// 	for i := 0; i < lenOfNums; i++ {
// 		c := target - nums[i]
// 		if ic, ok := m[c]; ok {
// 			return []int{ic, i}
// 		}
// 		m[nums[i]] = i
// 	}
// 	return nil
// }

// func main() {
// 	nums := []int{3, 2, 4}
// 	target := 6
// 	res := twoSum(nums, target)

// 	fmt.Println(res)
// }
