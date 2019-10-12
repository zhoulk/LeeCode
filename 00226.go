package main

// 翻转一棵二叉树。

// 示例：

// 输入：

//      4
//    /   \
//   2     7
//  / \   / \
// 1   3 6   9
// 输出：

//      4
//    /   \
//   7     2
//  / \   / \
// 9   6 3   1
// 备注:
// 这个问题是受到 Max Howell 的 原问题 启发的 ：

// 谷歌：我们90％的工程师使用您编写的软件(Homebrew)，但是您却无法在面试时在白板上写出翻转二叉树这道题，这太糟糕了。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/invert-binary-tree
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
func invertTree(root *TreeNode) *TreeNode {
	if root == nil {
		return nil
	}
	nodes := make([]*TreeNode, 0)
	nodes = append(nodes, root)
	for len(nodes) > 0 {
		n := nodes[0]
		nodes = nodes[1:]

		if n != nil {
			t := n.Left
			n.Left = n.Right
			n.Right = t

			if n.Left != nil || n.Right != nil {
				nodes = append(nodes, n.Left)
				nodes = append(nodes, n.Right)
			}
		}
	}

	return root
}

// func main() {
// 	t1 := new(TreeNode)
// 	t1.Val = 4
// 	t11 := new(TreeNode)
// 	t11.Val = 2
// 	t12 := new(TreeNode)
// 	t12.Val = 7
// 	t111 := new(TreeNode)
// 	t111.Val = 1
// 	t112 := new(TreeNode)
// 	t112.Val = 3
// 	t121 := new(TreeNode)
// 	t121.Val = 6
// 	t122 := new(TreeNode)
// 	t122.Val = 9

// 	t1.Left = t11
// 	t1.Right = t12
// 	t11.Left = t111
// 	t11.Right = t112
// 	t12.Left = t121
// 	t12.Right = t122

// 	t := invertTree(t1)
// 	fmt.Println(t)

// 	// nums := []int{1, 2, 3, 4, 5, 6, 7}
// 	// fmt.Println(nums[1:1])
// }
