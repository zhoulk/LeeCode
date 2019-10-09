package main

// 给定一个二叉树，检查它是否是镜像对称的。

// 例如，二叉树 [1,2,2,3,4,4,3] 是对称的。

//     1
//    / \
//   2   2
//  / \ / \
// 3  4 4  3
// 但是下面这个 [1,2,2,null,3,null,3] 则不是镜像对称的:

//     1
//    / \
//   2   2
//    \   \
//    3    3
// 说明:

// 如果你可以运用递归和迭代两种方法解决这个问题，会很加分。

// 在真实的面试中遇到过这道题？

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/symmetric-tree
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
func isSymmetric(root *TreeNode) bool {
	if root == nil {
		return true
	}
	return isEqual(root.Left, root.Right)
}

func isEqual(t1 *TreeNode, t2 *TreeNode) bool {
	if t1 == nil && t2 == nil {
		return true
	}
	if t1 != nil && t2 != nil {
		if t1.Val == t2.Val {
			if isEqual(t1.Left, t2.Right) {
				return isEqual(t1.Right, t2.Left)
			}
			return false
		}
		return false
	}
	return false
}

// func main() {
// 	t1 := new(TreeNode)
// 	t1.Val = 1
// 	t12 := new(TreeNode)
// 	t12.Val = 2
// 	t13 := new(TreeNode)
// 	t13.Val = 2
// 	t1.Left = t12
// 	// t1.Right = t13

// 	res := isSymmetric(t1)
// 	fmt.Println(res)
// }
