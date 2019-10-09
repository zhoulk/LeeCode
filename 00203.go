package main

// 删除链表中等于给定值 val 的所有节点。

// 示例:

// 输入: 1->2->6->3->4->5->6, val = 6
// 输出: 1->2->3->4->5

type ListNode struct {
	Val  int
	Next *ListNode
}

/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func removeElements(head *ListNode, val int) *ListNode {
	if head == nil {
		return head
	}
	for head != nil && head.Val == val {
		head = head.Next
	}

	if head == nil {
		return head
	}

	pre := head
	current := head.Next
	for current != nil {
		if current.Val == val {
			pre.Next = current.Next
			current = current.Next
		} else {
			pre = pre.Next
			current = current.Next
		}
	}

	return head
}

// func main() {
// 	n1 := new(ListNode)
// 	n1.Val = 1
// 	n2 := new(ListNode)
// 	n2.Val = 1
// 	n3 := new(ListNode)
// 	n3.Val = 2
// 	n4 := new(ListNode)
// 	n4.Val = 3
// 	n5 := new(ListNode)
// 	n5.Val = 4
// 	n6 := new(ListNode)
// 	n6.Val = 1

// 	n1.Next = n2
// 	n2.Next = n3
// 	n3.Next = n4
// 	n4.Next = n5
// 	n5.Next = n6

// 	ret := removeElements(n1, 1)
// 	fmt.Println(ret)
// }
