package main

// 给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）

// 例如：
// 给定二叉树 [3,9,20,null,null,15,7],

//     3
//    / \
//   9  20
//     /  \
//    15   7
// 返回其自底向上的层次遍历为：

// [
//   [15,7],
//   [9,20],
//   [3]
// ]

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/binary-tree-level-order-traversal-ii
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func levelOrderBottom(root *TreeNode) [][]int {
	if root == nil {
		return [][]int{}
	}

	queue := make([]*TreeNode, 0)
	queue = append(queue, root)

	res := make([][]int, 0)
	for len(queue) > 0 {
		len := len(queue)
		one := make([]int, 0)
		for i := 0; i < len; i++ {
			q := queue[i]
			one = append(one, q.Val)

			if q.Left != nil {
				queue = append(queue, q.Left)
			}
			if q.Right != nil {
				queue = append(queue, q.Right)
			}
		}
		res = append(append([][]int{}, one), res...)
		queue = queue[len:]
	}

	return res
}

// func main() {
// 	t1 := new(TreeNode)
// 	t1.Val = 1
// 	t12 := new(TreeNode)
// 	t12.Val = 2
// 	t13 := new(TreeNode)
// 	t13.Val = 3
// 	t14 := new(TreeNode)
// 	t14.Val = 4
// 	t15 := new(TreeNode)
// 	t15.Val = 5
// 	t16 := new(TreeNode)
// 	t16.Val = 6
// 	t17 := new(TreeNode)
// 	t17.Val = 7
// 	t1.Left = t12
// 	t1.Right = t13
// 	t12.Left = t14
// 	t13.Right = t15
// 	t15.Left = t16
// 	t15.Right = t17

// 	res := levelOrderBottom(nil)
// 	fmt.Println(res)
// }
