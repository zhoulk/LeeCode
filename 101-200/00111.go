package main

// 给定一个二叉树，找出其最小深度。

// 最小深度是从根节点到最近叶子节点的最短路径上的节点数量。

// 说明: 叶子节点是指没有子节点的节点。

// 示例:

// 给定二叉树 [3,9,20,null,null,15,7],

//     3
//    / \
//   9  20
//     /  \
//    15   7
// 返回它的最小深度  2.

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/minimum-depth-of-binary-tree
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

const INT_MAX = int(^uint(0) >> 1)
const INT_MIN = ^INT_MAX

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
func minDepth(root *TreeNode) int {
	if root == nil {
		return 0
	}
	if root.Left == nil && root.Right == nil {
		return 1
	}
	min := INT_MAX
	if root.Left != nil {
		min = minValue(minDepth(root.Left), min)
	}
	if root.Right != nil {
		min = minValue(minDepth(root.Right), min)
	}
	return min + 1
}

func minValue(a int, b int) int {
	if a < b {
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
// 	// t1.Right = t13
// 	// t12.Left = t14
// 	// t13.Right = t15
// 	// t14.Left = t16
// 	// t15.Right = t17
// 	ret := minDepth(t1)
// 	fmt.Println(ret)
// }
