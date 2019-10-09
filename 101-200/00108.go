package main

// 将一个按照升序排列的有序数组，转换为一棵高度平衡二叉搜索树。

// 本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差的绝对值不超过 1。

// 示例:

// 给定有序数组: [-10,-3,0,5,9],
//                  [0,-3,5,-10,9]
//                  [0,-3,null,-10]
//                  [0,-3,9,-10,5]
//                  [0,-3,9,-10,null,null,5]
// 一个可能的答案是：[0,-3,9,-10,null,5]，它可以表示下面这个高度平衡二叉搜索树：

//       0
//      / \
//    -3   9
//    /   /
//  -10  5

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/convert-sorted-array-to-binary-search-tree
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
// func sortedArrayToBST(nums []int) *TreeNode {
// 	if len(nums) == 0 {
// 		return nil
// 	}
// 	left := len(nums) / 2
// 	right := len(nums)
// 	num := nums[left]
// 	root := new(TreeNode)
// 	root.Val = num
// 	queue := make([]*TreeNode, 0)
// 	queue = append(queue, root)
// 	for len(queue) > 0 {
// 		l := len(queue)
// 		for i := 0; i < l; i++ {
// 			q := queue[i]
// 			p := queue[l-i-1]

// 			if left-1 >= 0 {
// 				left--
// 				leftNode := new(TreeNode)
// 				leftNode.Val = nums[left]
// 				q.Left = leftNode

// 				queue = append(queue, leftNode)
// 			}
// 			if l-i-1 != i {
// 				if left-1 >= 0 {
// 					left--
// 					rightNode := new(TreeNode)
// 					rightNode.Val = nums[left]
// 					q.Left = rightNode

// 					queue = append(queue, rightNode)
// 				}
// 			}

// 			if right-1 > len(nums)/2 {
// 				right--
// 				leftNode := new(TreeNode)
// 				leftNode.Val = nums[right]
// 				p.Right = leftNode

// 				queue = append(queue, leftNode)
// 			}

// 			if l-i-1 != i {
// 				if right-1 > len(nums)/2 {
// 					right--
// 					rightNode := new(TreeNode)
// 					rightNode.Val = nums[right]
// 					p.Right = rightNode

// 					queue = append(queue, rightNode)
// 				}
// 			}
// 		}
// 		queue = queue[l:]

// 	}
// 	return root
// }

// func sortedArrayToBST(nums []int) *TreeNode {
// 	if len(nums) == 0 {
// 		return nil
// 	}

// 	mid := len(nums) / 2
// 	node := new(TreeNode)
// 	node.Val = nums[mid]

// 	node.Left = sortedArrayToBST(nums[0:mid])
// 	node.Right = sortedArrayToBST(nums[mid+1:])

// 	return node
// }

func sortedArrayToBST(nums []int) *TreeNode {
	if len(nums) < 1 {
		return nil
	}
	return &TreeNode{
		Val:   nums[(len(nums)-1)>>1],
		Right: sortedArrayToBST(nums[(len(nums)-1)>>1+1:]),
		Left:  sortedArrayToBST(nums[:(len(nums)-1)>>1]),
	}
}

// func main() {
// 	nums := []int{-10, -3, 0, 5, 9}
// 	res := sortedArrayToBST(nums)
// 	fmt.Println(res)
// }
