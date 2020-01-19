package main

import (
	"fmt"
	"strconv"
)

// 给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。

// 注意：

// num1 和num2 的长度都小于 5100.
// num1 和num2 都只包含数字 0-9.
// num1 和num2 都不包含任何前导零。
// 你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/add-strings
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func addStrings(num1 string, num2 string) string {
	lA := len(num1)
	lB := len(num2)
	res := ""
	for {
		num := 0
		if lA >= 0 {
			n, _ := strconv.Atoi(num1[lA:1])
			num += n
			lA--
		}
		if lB >= 0 {
			n, _ := strconv.Atoi(num2[lB:1])
			num += n
			lB--
		}
		res = res + strconv.Itoa(num)
		if lA <= 0 && lB <= 0 {
			break
		}
	}
	return res
}

func main() {
	// ret := addStrings("1212121", "21212121")
	// fmt.Println(ret)
	fmt.Println(32 << 1)
}
