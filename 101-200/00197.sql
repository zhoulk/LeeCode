-- 给定一个 Weather 表，编写一个 SQL 查询，来查找与之前（昨天的）日期相比温度更高的所有日期的 Id。

-- +---------+------------------+------------------+
-- | Id(INT) | RecordDate(DATE) | Temperature(INT) |
-- +---------+------------------+------------------+
-- |       1 |       2015-01-01 |               10 |
-- |       2 |       2015-01-02 |               25 |
-- |       3 |       2015-01-03 |               20 |
-- |       4 |       2015-01-04 |               30 |
-- +---------+------------------+------------------+
-- 例如，根据上述给定的 Weather 表格，返回如下 Id:

-- +----+
-- | Id |
-- +----+
-- |  2 |
-- |  4 |
-- +----+

-- 来源：力扣（LeetCode）
-- 链接：https://leetcode-cn.com/problems/rising-temperature
-- 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

-- ----------------------------
-- Table structure for weather
-- ----------------------------
DROP TABLE IF EXISTS `weather`;
CREATE TABLE `weather` (
  `id` int(11) NOT NULL,
  `RecordDate` datetime DEFAULT NULL,
  `Temperature` int(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of weather
-- ----------------------------
INSERT INTO `weather` VALUES ('1', '2015-01-01 00:00:00', '10');
INSERT INTO `weather` VALUES ('2', '2015-01-02 00:00:00', '25');
INSERT INTO `weather` VALUES ('3', '2015-01-03 00:00:00', '20');
INSERT INTO `weather` VALUES ('4', '2015-01-04 00:00:00', '30');

select a.id from weather a , weather b where DATEDIFF(a.recorddate , b.recorddate) = 1 and a.temperature > b.temperature;