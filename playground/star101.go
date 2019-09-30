package main

import (
	"fmt"
	"math"
)

/*
一共40套衣服，每10星解锁一套衣服
合成衣服获得经验，生产衣服消耗绿钞
增加经验获得星星，增加星星获得更高的收益效率
绿钞每秒增加一次，绿钞可以购买衣服

求  解锁每套衣服需要的时间
*/

/*
衣服的价格 和 产出的经验产出 成正比
*/

const MAX_CLOTH = 40

func main() {
	prices := make([]int64, MAX_CLOTH)
	for i := 0; i < MAX_CLOTH; i++ {
		prices[i] = int64(1 * 200 * (i + 1))
	}
	fmt.Println(prices)

	starExp := CalStarExp3()
	fmt.Println(starExp)

	lvChao := int64(0)
	star := int64(1)
	exp := int64(0)
	seconds := int64(0)
	for star < MAX_CLOTH*10 {
		seconds++
		lvChao += star * 10

		// 买衣服
		if lvChao > prices[star/10] {
			exp += prices[star/10]
		}
		if exp >= starExp[star] {
			exp -= starExp[star]
			star++

			if star%10 == 0 {
				fmt.Println("star  ", star, "   time  ", seconds/(24*3600), "天", (seconds%(24*3600))/3600, "小时", (seconds%3600)/60, "分钟", seconds%60, "秒")
			}
		}
	}
}

func CalStarExp1() []int64 {
	starExp := make([]int64, MAX_CLOTH*10)
	for i := 0; i < len(starExp); i++ {
		starExp[i] = int64(100 * math.Pow(1.05, float64(i+1)))
	}
	return starExp
}

func CalStarExp2() []int64 {
	starExp := make([]int64, MAX_CLOTH*10)
	step := float32(0)
	for i := 0; i < len(starExp); i++ {
		starExp[i] = int64(starExp[i-1] + int64(step))
		step = step + 500
		if i%10 == 0 {
			step = step * 1.1
		}
	}
	return starExp
}

func CalStarExp3() []int64 {
	starExp := make([]int64, MAX_CLOTH*10)
	step := float32(0)
	for i := 0; i < len(starExp); i++ {
		starExp[i] = int64(starExp[i-1] + int64(step))
		step = step + 200
		if i%10 == 0 {
			step = step * 1.1
		}
	}
	return starExp
}
