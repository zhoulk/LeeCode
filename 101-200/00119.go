package main

// 给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。

// 在杨辉三角中，每个数是它左上方和右上方的数的和。

// 示例:

// 输入: 3
// 输出: [1,3,3,1]
// 进阶：

// 你可以优化你的算法到 O(k) 空间复杂度吗？

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/pascals-triangle-ii
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func getRow(rowIndex int) []int {
	res := make([]int, rowIndex+1)
	for i := 0; i < rowIndex+1; i++ {
		len := i + 1
		for j := len - 1; j >= 0; j-- {
			if j == 0 {
				res[j] = 1
			} else if j == len-1 {
				res[j] = 1
			} else {
				if j-1 >= 0 {
					res[j] = res[j] + res[j-1]
				}
			}
		}
	}
	return res
}

// func main() {
// 	ret := getRow(3)
// 	fmt.Println(ret)
// }
