package main

// 编写一个函数，以字符串作为输入，反转该字符串中的元音字母。

// 示例 1:

// 输入: "hello"
// 输出: "holle"
// 示例 2:

// 输入: "leetcode"
// 输出: "leotcede"
// 说明:
// 元音字母不包含字母"y"。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/reverse-vowels-of-a-string
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func reverseVowels(s string) string {
	left := 0
	right := len(s) - 1
	b := []byte(s)
	for left < right {

		if isVowel(s[left]) && isVowel(s[right]) {
			b[left], b[right] = b[right], b[left]

			left++
			right--
		} else {
			if !isVowel(s[left]) {
				left++
			}
			if !isVowel(s[right]) {
				right--
			}
		}
	}
	return string(b)
}

func isVowel(c byte) bool {
	switch c {
	case 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U':
		return true
	default:
		return false
	}
}

// func main() {
// 	ret := reverseVowels("a.")
// 	fmt.Println(ret)
// }
