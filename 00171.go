package main

import "fmt"

// 给定一个Excel表格中的列名称，返回其相应的列序号。

// 例如，

//     A -> 1
//     B -> 2
//     C -> 3
//     ...
//     Z -> 26
//     AA -> 27
//     AB -> 28
//     ...
// 示例 1:

// 输入: "A"
// 输出: 1
// 示例 2:

// 输入: "AB"
// 输出: 28
// 示例 3:

// 输入: "ZY"
// 输出: 701

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/excel-sheet-column-number
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func titleToNumber(s string) int {
	l := len(s)
	res := 0
	power := 1
	for i := l - 1; i >= 0; i-- {
		res += int(s[i]-64) * power
		power = power * 26
	}
	return res
}

func main() {
	res := titleToNumber("ZY")
	fmt.Println(res)
}
