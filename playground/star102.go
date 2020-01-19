package main

import (
	"fmt"
	"math"
)

//  https://www.jianshu.com/p/c5daabbb7719
//  https://allknowboy.com/posts/921bf6d5/
/*
一共40*3套衣服，

产生 100颗星星


合成衣服获得经验，生产衣服消耗绿钞
增加经验获得星星，增加星星获得更高的收益效率
绿钞每秒增加一次，绿钞可以购买衣服

求  解锁每套衣服需要的时间
*/

/*
衣服的价格 和 产出的经验产出 成正比
*/

/*
1 1 2 3 4 5 6 7 8 9 10
*/

const MAX_CLOTH = 40

func main() {
	prices := make([]int64, MAX_CLOTH)
	//power := int64(0)
	total := int64(0)
	for i := 0; i < MAX_CLOTH; i++ {
		// prices[i] = int64(10*(i+1)) + power
		// power += 200
		// if i%10 == 0 && i > 0 {
		// 	power *= 2
		// }

		prices[i] = int64(50 * math.Pow(1.49, float64(i+1)))

		total += prices[i]
	}
	fmt.Println("price  ", total, prices)

	starExp := CalStarExp4()
	fmt.Println("starExp  ", starExp)

	lvChao := int64(0)
	star := int64(1)
	exp := int64(0)
	seconds := int64(0)
	maxCloth := 0
	for star < 200 {
		seconds++
		lvChao += star

		// 买衣服
		if lvChao > prices[maxCloth] {
			exp += prices[maxCloth]
			if maxCloth < MAX_CLOTH-1 {
				maxCloth++
			}
		}
		if exp >= starExp[star] {
			exp -= starExp[star]
			star++

			if star%10 == 0 {
				fmt.Println("star  ", star, " cloth ", maxCloth, "   time  ", seconds/(24*3600), "天", (seconds%(24*3600))/3600, "小时", (seconds%3600)/60, "分钟", seconds%60, "秒")
			}
		}
	}
}

func CalStarExp4() []int64 {
	starExp := make([]int64, 200)
	total := int64(0)
	for i := 0; i < len(starExp); i++ {
		starExp[i] = int64(10 * math.Pow(1.08, float64(i+1)))
		//prices[i] = int64(100 * math.Pow(1.5, float64(i+1)))
		total += starExp[i]
	}
	fmt.Println(total)
	return starExp
}
