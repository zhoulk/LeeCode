package main

import "fmt"

// 二进制手表顶部有 4 个 LED 代表小时（0-11），底部的 6 个 LED 代表分钟（0-59）。

// 每个 LED 代表一个 0 或 1，最低位在右侧。

// 例如，上面的二进制手表读取 “3:25”。

// 给定一个非负整数 n 代表当前 LED 亮着的数量，返回所有可能的时间。

// 案例:

// 输入: n = 1
// 返回: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32"]
//

// 注意事项:

// 输出的顺序没有要求。
// 小时不会以零开头，比如 “01:00” 是不允许的，应为 “1:00”。
// 分钟必须由两位数组成，可能会以零开头，比如 “10:2” 是无效的，应为 “10:02”。

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/binary-watch
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

func readBinaryWatch(num int) []string {
	res := make([]string, 0)
	for i := 0; i < 12; i++ {
		for j := 0; j < 60; j++ {
			if int(bitCount41(i)+bitCount41(j)) == num {
				res = append(res, fmt.Sprintf("%d:%02d", i, j))
			}
		}
	}
	return res
}

func bitCount41(n int) int8 {
	n = (n & 0x5555555555555555) + ((n >> 1) & 0x5555555555555555)
	n = (n & 0x3333333333333333) + ((n >> 2) & 0x3333333333333333)
	n = (n & 0x0f0f0f0f0f0f0f0f) + ((n >> 4) & 0x0f0f0f0f0f0f0f0f)
	n = (n & 0x00ff00ff00ff00ff) + ((n >> 8) & 0x00ff00ff00ff00ff)
	n = (n & 0x0000ffff0000ffff) + ((n >> 16) & 0x0000ffff0000ffff)
	n = (n & 0x00000000ffffffff) + ((n >> 32) & 0x00000000ffffffff)

	return int8(n & 0x7f)
}

func main() {
	res := readBinaryWatch(1)
	fmt.Println(res)
}
