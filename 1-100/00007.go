package main

// 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

// 示例 1:

// 输入: 123
// 输出: 321
//  示例 2:

// 输入: -123
// 输出: -321
// 示例 3:

// 输入: 120
// 输出: 21
// 注意:

// 假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/reverse-integer
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

// func reverse(x int) int {
// 	nums := make([]int, 0)
// 	for {
// 		if math.Abs(float64(x)) < 10 {
// 			break
// 		}
// 		nums = append(nums, x%10)
// 		x = x / 10
// 	}
// 	nums = append(nums, x)

// 	res := 0
// 	pow := 1
// 	for i := len(nums) - 1; i >= 0; i-- {
// 		res += nums[i] * pow
// 		pow *= 10
// 	}

// 	fmt.Println(2<<30 - 1)

// 	if res > 2<<30-1 || res < -2<<30 {
// 		res = 0
// 	}

// 	return res
// }

func reverse(x int) int {
	rev := 0
	for x != 0 {
		pop := x % 10

		x = x / 10
		rev = rev*10 + pop
	}
	if rev < -(1<<31) || rev > ((1<<31)-1) {
		return 0
	}
	return rev
}

// func main() {
// 	res := reverse(1563847412)
// 	fmt.Println(res)
// }
