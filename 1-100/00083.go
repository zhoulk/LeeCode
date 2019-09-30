package main

// 给定一个排序链表，删除所有重复的元素，使得每个元素只出现一次。

// 示例 1:

// 输入: 1->1->2
// 输出: 1->2
// 示例 2:

// 输入: 1->1->2->3->3
// 输出: 1->2->3

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list
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
// func deleteDuplicates(head *ListNode) *ListNode {
// 	if head == nil {
// 		return nil
// 	}
// 	t := head
// 	last := head
// 	t = t.Next
// 	for t != nil {
// 		if t.Val == last.Val {
// 			last.Next = t.Next
// 		} else {
// 			last = t
// 		}
// 		t = t.Next
// 	}

// 	return head
// }

func deleteDuplicates(head *ListNode) *ListNode {
	if head == nil {
		return nil
	}
	t := head
	for t != nil {
		if t.Next != nil && t.Val == t.Next.Val {
			t.Next = t.Next.Next
		} else {
			t = t.Next
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
// 	n3.Val = 1
// 	n4 := new(ListNode)
// 	n4.Val = 2
// 	n5 := new(ListNode)
// 	n5.Val = 3
// 	n6 := new(ListNode)
// 	n6.Val = 4
// 	n1.Next = n2
// 	n2.Next = n3
// 	n3.Next = n4
// 	n4.Next = n5
// 	n5.Next = n6
// 	res := deleteDuplicates(n1)
// 	for res != nil {
// 		fmt.Println(res.Val)
// 		res = res.Next
// 	}
// }
