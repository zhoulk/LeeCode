package main

// 给定两个二叉树，编写一个函数来检验它们是否相同。

// 如果两个树在结构上相同，并且节点具有相同的值，则认为它们是相同的。

// 示例 1:

// 输入:       1         1
//           / \       / \
//          2   3     2   3

//         [1,2,3],   [1,2,3]

// 输出: true
// 示例 2:

// 输入:      1          1
//           /           \
//          2             2

//         [1,2],     [1,null,2]

// 输出: false
// 示例 3:

// 输入:       1         1
//           / \       / \
//          2   1     1   2

//         [1,2,1],   [1,1,2]

// 输出: false

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/same-tree
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
func isSameTree(p *TreeNode, q *TreeNode) bool {
	for p != nil && q != nil {
		if p.Val == q.Val {
			if isSameTree(p.Left, q.Left) {
				return isSameTree(p.Right, q.Right)
			}
			return false
		}
		break
	}

	return p == nil && q == nil
}

// func main() {
// 	t1 := new(TreeNode)
// 	t1.Val = 1
// 	t12 := new(TreeNode)
// 	t12.Val = 2
// 	t13 := new(TreeNode)
// 	t13.Val = 3
// 	t1.Left = t12
// 	// t1.Right = t13

// 	t2 := new(TreeNode)
// 	t2.Val = 1
// 	t22 := new(TreeNode)
// 	t22.Val = 2
// 	t23 := new(TreeNode)
// 	t23.Val = 3
// 	t2.Left = t22
// 	t2.Right = t23

// 	res := isSameTree(t1, t2)
// 	fmt.Println(res)
// }
