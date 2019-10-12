package main

import (
	"fmt"
	"strconv"
)

// 给定一个二叉树，返回所有从根节点到叶子节点的路径。

// 说明: 叶子节点是指没有子节点的节点。

// 示例:

// 输入:

//    1
//  /   \
// 2     3
//  \
//   5

// 输出: ["1->2->5", "1->3"]

// 解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/binary-tree-paths
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
func binaryTreePaths(root *TreeNode) []string {
	if root == nil {
		return nil
	}

	res := make([]string, 0)
	path := make([]string, 0)
	nodes := make([]*TreeNode, 0)
	nodes = append(nodes, root)
	path = append(path, strconv.Itoa(root.Val))
	for len(nodes) > 0 {
		n := nodes[0]
		nodes = nodes[1:]
		r := path[0]
		path = path[1:]

		if n != nil {

			if n.Left == nil && n.Right == nil {
				res = append(res, r)
			}

			if n.Left != nil {
				nodes = append(nodes, n.Left)
				path = append(path, r+"->"+strconv.Itoa(n.Left.Val))
			}

			if n.Right != nil {
				nodes = append(nodes, n.Right)
				path = append(path, r+"->"+strconv.Itoa(n.Right.Val))
			}
		}
	}
	return res
}

// [2,1,6,null,null,5,null,4,null,3]
func main() {
	t1 := new(TreeNode)
	t1.Val = 4
	t11 := new(TreeNode)
	t11.Val = 2
	t12 := new(TreeNode)
	t12.Val = 7
	t111 := new(TreeNode)
	t111.Val = 1
	t112 := new(TreeNode)
	t112.Val = 3
	t121 := new(TreeNode)
	t121.Val = 6
	t122 := new(TreeNode)
	t122.Val = 9

	t1.Left = t11
	t1.Right = t12
	// t11.Left = t111
	// t11.Right = t112
	t12.Left = t121
	t121.Left = t122
	t122.Left = t111

	ret := binaryTreePaths(t1)
	fmt.Println(ret)
}
