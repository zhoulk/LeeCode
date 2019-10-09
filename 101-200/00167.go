package main

// 给定一个已按照升序排列 的有序数组，找到两个数使得它们相加之和等于目标数。

// 函数应该返回这两个下标值 index1 和 index2，其中 index1 必须小于 index2。

// 说明:

// 返回的下标值（index1 和 index2）不是从零开始的。
// 你可以假设每个输入只对应唯一的答案，而且你不可以重复使用相同的元素。
// 示例:

// 输入: numbers = [2, 7, 11, 15], target = 9
// 输出: [1,2]
// 解释: 2 与 7 之和等于目标数 9 。因此 index1 = 1, index2 = 2 。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

// func twoSum167(numbers []int, target int) []int {
// 	lenOfNums := len(numbers)
// 	temp := make(map[int]int, lenOfNums)
// 	for i := lenOfNums - 1; i >= 0; i-- {
// 		other := target - numbers[i]
// 		if ic, ok := temp[other]; ok {
// 			if ic != i {
// 				return []int{i + 1, ic + 1}
// 			}
// 		} else {
// 			temp[numbers[i]] = i
// 		}
// 	}
// 	return nil
// }

// func twoSum167(numbers []int, target int) []int {
// 	high := len(numbers) - 1
// 	low := 0
// 	for {
// 		if low > high {
// 			break
// 		}
// 		sum := numbers[low] + numbers[high]
// 		if sum == target {
// 			return []int{low + 1, high + 1}
// 		} else if sum < target {
// 			low = low + 1
// 		} else {
// 			high--
// 		}
// 	}
// 	return nil
// }

func twoSum167(numbers []int, target int) []int {
	m := make(map[int]int, len(numbers))

	for i, n := range numbers {
		if m[target-n] != 0 {
			return []int{m[target-n], i + 1}
		}
		m[n] = i + 1
	}
	return nil
}

// func main() {
// 	nums := []int{2, 3, 4}
// 	target := 6
// 	res := twoSum167(nums, target)

// 	fmt.Println(res)
// }
