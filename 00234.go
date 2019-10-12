package main

// 请判断一个链表是否为回文链表。

// 示例 1:

// 输入: 1->2
// 输出: false
// 示例 2:

// 输入: 1->2->2->1
// 输出: true
// 进阶：
// 你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/palindrome-linked-list
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
func isPalindrome(head *ListNode) bool {
	slow := head
	fast := head
	var font *ListNode
	for fast != nil {
		fast = fast.Next
		if fast != nil {
			fast = fast.Next
		} else {
			slow = slow.Next
			break
		}

		next := slow.Next

		temp := font
		font = slow
		font.Next = temp

		slow = next
	}
	fast = font
	// slow.Next = font

	// fmt.Println(slow, fast)

	for fast != nil && slow != nil {
		if fast.Val != slow.Val {
			return false
		}
		fast = fast.Next
		slow = slow.Next
	}

	return true
}

// func main() {
// 	n1 := new(ListNode)
// 	n1.Val = 1
// 	n2 := new(ListNode)
// 	n2.Val = 2
// 	n3 := new(ListNode)
// 	n3.Val = 3
// 	n4 := new(ListNode)
// 	n4.Val = 2
// 	n5 := new(ListNode)
// 	n5.Val = 1

// 	n1.Next = n2
// 	n2.Next = n3
// 	n3.Next = n4
// 	n4.Next = n5

// 	ret := isPalindrome(n1)
// 	fmt.Println(ret)
// }
