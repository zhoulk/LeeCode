package main

// 反转一个单链表。

// 示例:

// 输入: 1->2->3->4->5->NULL
// 输出: 5->4->3->2->1->NULL
// 进阶:
// 你可以迭代或递归地反转链表。你能否用两种方法解决这道题？

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/reverse-linked-list
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

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
// func reverseList(head *ListNode) *ListNode {
// 	if head == nil {
// 		return head
// 	}
// 	st := make([]*ListNode, 0)
// 	for head != nil {
// 		st = append(st, head)
// 		head = head.Next
// 	}
// 	for i := len(st) - 1; i >= 1; i-- {
// 		st[i].Next = st[i-1]
// 	}
// 	return st[len(st)-1]
// }

func reverseList(head *ListNode) *ListNode {
	if head == nil {
		return head
	}
	pre := head
	current := head.Next
	pre.Next = nil
	for pre != nil && current != nil {
		next := current.Next
		current.Next = pre
		pre = current
		current = next
	}
	return pre
}

// func main() {
// 	n1 := new(ListNode)
// 	n1.Val = 1
// 	n2 := new(ListNode)
// 	n2.Val = 2
// 	n3 := new(ListNode)
// 	n3.Val = 3
// 	n4 := new(ListNode)
// 	n4.Val = 4
// 	n5 := new(ListNode)
// 	n5.Val = 5
// 	n6 := new(ListNode)
// 	n6.Val = 6

// 	n1.Next = n2
// 	n2.Next = n3
// 	n3.Next = n4
// 	n4.Next = n5
// 	n5.Next = n6

// 	ret := reverseList(n1)
// 	fmt.Println(ret)
// }
