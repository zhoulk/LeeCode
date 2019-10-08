package main

import "fmt"

// 给定一个整数 n，返回 n! 结果尾数中零的数量。

// 示例 1:

// 输入: 3
// 输出: 0
// 解释: 3! = 6, 尾数中没有零。
// 示例 2:

// 输入: 5
// 输出: 1
// 解释: 5! = 120, 尾数中有 1 个零.
// 说明: 你算法的时间复杂度应为 O(log n) 。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/factorial-trailing-zeroes
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func trailingZeroes(n int) int {
	// sum := 1
	// index := 0
	// for i := 1; i <= n; i++ {
	// 	sum *= i

	// 	fmt.Println(sum)

	// 	for sum%10 == 0 {
	// 		index++
	// 		sum = sum / 10
	// 	}
	// }
	// return index

	count := 0
	step := 5
	for step <= n {
		count += n / step
		step *= 5
	}
	return count
}

func main() {
	ret := trailingZeroes(30)
	fmt.Println(ret)
}
