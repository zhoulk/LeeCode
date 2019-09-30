package main

// 给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。

// 说明: 叶子节点是指没有子节点的节点。

// 示例:
// 给定如下二叉树，以及目标和 sum = 22，

//               5
//              / \
//             4   8
//            /   / \
//           11  13  4
//          /  \      \
//         7    2      1
// 返回 true, 因为存在目标和为 22 的根节点到叶子节点的路径 5->4->11->2。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/path-sum
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func hasPathSum(root *TreeNode, sum int) bool {
	if root == nil {
		return false
	}
	if root.Left == nil && root.Right == nil {
		if root.Val == sum {
			return true
		}
	}
	return hasPathSum(root.Left, sum-root.Val) || hasPathSum(root.Right, sum-root.Val)
}

// func main() {
// 	t1 := new(TreeNode)
// 	t1.Val = 5
// 	t12 := new(TreeNode)
// 	t12.Val = 4
// 	t13 := new(TreeNode)
// 	t13.Val = 8
// 	t14 := new(TreeNode)
// 	t14.Val = 11
// 	t15 := new(TreeNode)
// 	t15.Val = 13
// 	t16 := new(TreeNode)
// 	t16.Val = 4
// 	t17 := new(TreeNode)
// 	t17.Val = 7
// 	t18 := new(TreeNode)
// 	t18.Val = 2
// 	t19 := new(TreeNode)
// 	t19.Val = 1
// 	t1.Left = t12
// 	t1.Right = t13
// 	t12.Left = t14
// 	t13.Left = t15
// 	t13.Right = t16
// 	t14.Left = t17
// 	t14.Right = t18
// 	t16.Right = t19
// 	ret := hasPathSum(t1, 22)
// 	fmt.Println(ret)
// }
