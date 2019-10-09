package main

// 给定一个非负整数 numRows，生成杨辉三角的前 numRows 行。

// 在杨辉三角中，每个数是它左上方和右上方的数的和。

// 示例:

// 输入: 5
// 输出:
// [
//      [1],
//     [1,1],
//    [1,2,1],
//   [1,3,3,1],
//  [1,4,6,4,1]
// ]

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/pascals-triangle
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func generate(numRows int) [][]int {
	if numRows == 0 {
		return nil
	}
	res := make([][]int, numRows)
	for i := 0; i < numRows; i++ {
		len := i + 1
		res[i] = make([]int, len)
		for j := 0; j < len; j++ {
			if j == 0 {
				res[i][j] = 1
			} else if j == len-1 {
				res[i][j] = 1
			} else {
				if i-1 >= 0 && j-1 >= 0 {
					res[i][j] = res[i-1][j-1] + res[i-1][j]
				}
			}
		}
	}
	return res
}

// func main() {
// 	ret := generate(5)
// 	fmt.Println(ret)
// }
