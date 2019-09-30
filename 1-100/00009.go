package main

// 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。

// 示例 1:

// 输入: 121
// 输出: true
// 示例 2:

// 输入: -121
// 输出: false
// 解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
// 示例 3:

// 输入: 10
// 输出: false
// 解释: 从右向左读, 为 01 。因此它不是一个回文数。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/palindrome-number
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

// func isPalindrome(x int) bool {
// 	flag := false
// 	if x >= 0 {
// 		rev := 0
// 		temp := x
// 		for temp != 0 {
// 			pop := temp % 10
// 			temp = temp / 10
// 			rev = rev*10 + pop
// 		}
// 		flag = rev == x
// 	}
// 	return flag
// }

func isPalindrome(x int) bool {

	if x < 0 || (x > 0 && x%10 == 0) {
		return false
	}

	rev := 0
	temp := x
	for x > 0 {
		rev = rev*10 + x%10
		x = x / 10
	}
	return rev == temp
}

// func main() {
// 	flag := isPalindrome(121)
// 	fmt.Println(flag)
// }
