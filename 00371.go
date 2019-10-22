package main

import "fmt"

// 不使用运算符 + 和 - ​​​​​​​，计算两整数 ​​​​​​​a 、b ​​​​​​​之和。

// 示例 1:

// 输入: a = 1, b = 2
// 输出: 3
// 示例 2:

// 输入: a = -2, b = 3
// 输出: 1

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/sum-of-two-integers
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func getSum(a int, b int) int {
	sum := a ^ b
	carry := (a & b) << 1
	if carry != 0 {
		return getSum(sum, carry)
	}
	return sum
}

func main() {
	ret := getSum(-1, 2)
	fmt.Println(ret)
}
