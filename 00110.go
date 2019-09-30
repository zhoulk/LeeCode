package main

import (
	"math"
)

// 给定一个二叉树，判断它是否是高度平衡的二叉树。

// 本题中，一棵高度平衡二叉树定义为：

// 一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过1。

// 示例 1:

// 给定二叉树 [3,9,20,null,null,15,7]

//     3
//    / \
//   9  20
//     /  \
//    15   7
// 返回 true 。

// 示例 2:

// [1,2,2,3,null,null,3,4,null,null,4]
// 给定二叉树 [1,2,2,3,3,null,null,4,4]

//        1
//       / \
//      2   2
//     / \
//    3   3
//   / \
//  4   4
// 返回 false 。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/balanced-binary-tree
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
func isBalanced(root *TreeNode) bool {
	if root == nil {
		return true
	}
	if math.Abs(float64(treeLen(root.Left))-float64(treeLen(root.Right))) <= 1 {
		return isBalanced(root.Left) && isBalanced(root.Right)
	}
	return false
}

func treeLen(root *TreeNode) int {
	if root == nil {
		return 0
	}
	return maxValue(treeLen(root.Left), treeLen(root.Right)) + 1
}

func maxValue(a int, b int) int {
	if a > b {
		return a
	}
	return b
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
// 	t14.Left = t16
// 	t15.Right = t17
// 	ret := isBalanced(t1)
// 	fmt.Println(ret)
// }
