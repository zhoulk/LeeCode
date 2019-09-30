package main

import (
	"strconv"
)

// 给定两个二进制字符串，返回他们的和（用二进制表示）。

// 输入为非空字符串且只包含数字 1 和 0。

// 示例 1:

// 输入: a = "11", b = "1"
// 输出: "100"
// 示例 2:

// 输入: a = "1010", b = "1011"
// 输出: "10101"

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/add-binary
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

// func addBinary(a string, b string) string {
// 	la := len(a)
// 	lb := len(b)
// 	index := 0
// 	res := []int{}
// 	for {
// 		index++

// 		numA := 0
// 		if la-index >= 0 {
// 			nA, _ := strconv.Atoi(string(a[la-index]))
// 			numA = nA
// 		}
// 		numB := 0
// 		if lb-index >= 0 {
// 			nB, _ := strconv.Atoi(string(b[lb-index]))
// 			numB = nB
// 		}

// 		res = append(res, numA+numB)

// 		if la-index <= 0 && lb-index <= 0 {
// 			break
// 		}
// 	}

// 	l := len(res)
// 	for i := 0; i < l; i++ {
// 		if i+1 >= l {
// 			if res[i]/2 > 0 {
// 				res = append(res, res[i]/2)
// 			}
// 		} else {
// 			res[i+1] += res[i] / 2
// 		}
// 		res[i] = res[i] % 2
// 	}

// 	resStr := ""
// 	for i := len(res) - 1; i >= 0; i-- {
// 		resStr = resStr + strconv.Itoa(res[i])
// 	}

// 	return resStr
// }

func addBinary(a string, b string) string {
	la := len(a)
	lb := len(b)

	res := "0"
	for la > 0 || lb > 0 {
		la--
		lb--

		numA := 0
		if la >= 0 {
			nA, _ := strconv.Atoi(string(a[la]))
			numA = nA
		}
		numB := 0
		if lb >= 0 {
			nB, _ := strconv.Atoi(string(b[lb]))
			numB = nB
		}

		nO, _ := strconv.Atoi(string(res[0]))
		result := numA + numB + nO

		res = strconv.Itoa(result/2) + strconv.Itoa(result%2) + res[1:]
	}

	if res[0] == '0' {
		res = res[1:]
	}

	return res
}

// func main() {
// 	res := addBinary("0", "0")
// 	fmt.Println(res)
// }
