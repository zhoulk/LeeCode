package main

// 给定一个非空数组，返回此数组中第三大的数。如果不存在，则返回数组中最大的数。要求算法时间复杂度必须是O(n)。

// 示例 1:

// 输入: [3, 2, 1]

// 输出: 1

// 解释: 第三大的数是 1.
// 示例 2:

// 输入: [1, 2]

// 输出: 2

// 解释: 第三大的数不存在, 所以返回最大的数 2 .
// 示例 3:

// 输入: [2, 2, 3, 1]

// 输出: 1

// 解释: 注意，要求返回第三大的数，是指第三大且唯一出现的数。
// 存在两个值为2的数，它们都排第二。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/third-maximum-number
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

const INT_MAX = int(^uint(0) >> 1)
const INT_MIN = ^INT_MAX

func thirdMax(nums []int) int {
	m1 := INT_MIN
	m2 := INT_MIN
	m3 := INT_MIN
	for _, n := range nums {
		if n > m1 {
			m3 = m2
			m2 = m1
			m1 = n
		} else if n != m1 && n > m2 {
			m3 = m2
			m2 = n
		} else if n != m1 && n != m2 && n > m3 {
			m3 = n
		}
		// fmt.Println(m1, m2, m3)
	}
	if m3 == INT_MIN {
		return m1
	}
	return m3
}

// func main() {
// 	ret := thirdMax([]int{1, 2})
// 	fmt.Println(ret)
// }
