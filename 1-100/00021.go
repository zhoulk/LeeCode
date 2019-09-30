package main

// 将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。

// 示例：

// 输入：1->2->4, 1->3->4
// 输出：1->1->2->3->4->4

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/merge-two-sorted-lists
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */

type ListNode struct {
	Val  int
	Next *ListNode
}

func mergeTwoLists(l1 *ListNode, l2 *ListNode) *ListNode {
	res := new(ListNode)
	var first *ListNode
	if l1 != nil || l2 != nil {
		first = res
	}
	for {
		if l1 != nil || l2 != nil {
			if l1 == nil {
				res.Val = l2.Val
				l2 = l2.Next
			} else if l2 == nil {
				res.Val = l1.Val
				l1 = l1.Next
			} else {
				if l1.Val <= l2.Val {
					res.Val = l1.Val
					l1 = l1.Next
				} else {
					res.Val = l2.Val
					l2 = l2.Next
				}
			}

			if l1 != nil || l2 != nil {
				res.Next = new(ListNode)
			}

			res = res.Next
		} else {
			break
		}

		if res == nil {
			break
		}
	}

	return first
}

// func main() {
// 	n1 := new(ListNode)
// 	n1.Val = 1
// 	n11 := new(ListNode)
// 	n11.Val = 2
// 	n12 := new(ListNode)
// 	n12.Val = 4
// 	n1.Next = n11
// 	n11.Next = n12

// 	n2 := new(ListNode)
// 	n2.Val = 1
// 	n21 := new(ListNode)
// 	n21.Val = 3
// 	n22 := new(ListNode)
// 	n22.Val = 4
// 	n2.Next = n21
// 	n21.Next = n22

// 	n3 := mergeTwoLists(nil, nil)

// 	for {
// 		if n3 == nil {
// 			break
// 		}

// 		fmt.Println(n3.Val)
// 		n3 = n3.Next

// 	}
// }
