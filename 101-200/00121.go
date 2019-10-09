package main

import "fmt"

// 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。

// 如果你最多只允许完成一笔交易（即买入和卖出一支股票），设计一个算法来计算你所能获取的最大利润。

// 注意你不能在买入股票前卖出股票。

// 示例 1:

// 输入: [7,1,5,3,6,4]
// 输出: 5
// 解释: 在第 2 天（股票价格 = 1）的时候买入，在第 5 天（股票价格 = 6）的时候卖出，最大利润 = 6-1 = 5 。
//      注意利润不能是 7-1 = 6, 因为卖出价格需要大于买入价格。
// 示例 2:

// 输入: [7,6,4,3,1]
// 输出: 0
// 解释: 在这种情况下, 没有交易完成, 所以最大利润为 0。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

const INT_MAX = int(^uint(0) >> 1)
const INT_MIN = ^INT_MAX

// func maxProfit(prices []int) int {
// 	len := len(prices)
// 	min := INT_MAX
// 	maxProfile := 0
// 	for i := 0; i < len; i++ {
// 		if prices[i] < min {
// 			min = prices[i]
// 		}
// 		if prices[i]-min > maxProfile {
// 			maxProfile = prices[i] - min
// 		}
// 	}

// 	return maxProfile
// }

func maxProfit(prices []int) int {
	l := len(prices)
	if l <= 1 {
		return 0
	}
	dp := make([][]int, l)
	for i := 0; i < l; i++ {
		dp[i] = make([]int, 2)
	}
	dp[0][0] = 0
	dp[0][1] = -prices[0]
	for i := 1; i < l; i++ {
		dp[i][0] = maxValue(dp[i-1][0], dp[i-1][1]+prices[i])
		dp[i][1] = maxValue(dp[i-1][1], -prices[i])
	}
	return dp[l-1][0]
}

func maxValue(a int, b int) int {
	if a > b {
		return a
	}
	return b
}

func main() {
	nums := []int{7, 1, 5, 3, 6, 4}
	ret := maxProfit(nums)
	fmt.Println(ret)
}
