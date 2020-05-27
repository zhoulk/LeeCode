package main

// 计算给定二叉树的所有左叶子之和。

// 示例：

//     3
//    / \
//   9  20
//     /  \
//    15   7

// 在这个二叉树中，有两个左叶子，分别是 9 和 15，所以返回 24

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/sum-of-left-leaves
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
func sumOfLeftLeaves(root *TreeNode) int {
	if root == nil {
		return 0
	}
	seq := make([]*TreeNode, 0)
	seq = append(seq, root)
	sum := 0
	for len(seq) > 0 {
		n := seq[0]
		seq = seq[1:]
		if n.Left != nil {
			if n.Left.Left == nil && n.Left.Right == nil {
				sum += n.Left.Val
			}
			seq = append(seq, n.Left)
		}
		if n.Right != nil {
			seq = append(seq, n.Right)
		}
	}
	return sum
}

// func main() {
// 	t1 := new(TreeNode)
// 	t1.Val = 3
// 	t2 := new(TreeNode)
// 	t2.Val = 9
// 	t3 := new(TreeNode)
// 	t3.Val = 20
// 	t4 := new(TreeNode)
// 	t4.Val = 15
// 	t5 := new(TreeNode)
// 	t5.Val = 7

// 	t1.Left = t2
// 	t1.Right = t3
// 	t2.Left = t4
// 	t2.Right = t5

// 	ret := sumOfLeftLeaves(t1)
// 	fmt.Println(ret)
// }
