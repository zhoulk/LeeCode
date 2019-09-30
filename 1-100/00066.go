package main

// 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。

// 最高位数字存放在数组的首位， 数组中每个元素只存储单个数字。

// 你可以假设除了整数 0 之外，这个整数不会以零开头。

// 示例 1:

// 输入: [1,2,3]
// 输出: [1,2,4]
// 解释: 输入数组表示数字 123。
// 示例 2:

// 输入: [4,3,2,1]
// 输出: [4,3,2,2]
// 解释: 输入数组表示数字 4321。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/plus-one
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func plusOne(digits []int) []int {
	len := len(digits)
	first := 0
	digits[len-1] = digits[len-1] + 1
	for i := len - 1; i >= 0; i-- {
		if digits[i] >= 10 {
			if i-1 >= 0 {
				digits[i-1] += digits[i] / 10
			} else {
				first = digits[i] / 10
			}

			digits[i] = digits[i] % 10
		}
	}

	if first > 0 {
		res := []int{first}
		res = append(res, digits...)
		return res
	}
	return digits
}

// func main() {
// 	nums := []int{1, 2, 9}
// 	res := plusOne(nums)
// 	fmt.Println(res)
// }
