-- 编写一个 SQL 查询，查找 Person 表中所有重复的电子邮箱。

-- 示例：

-- +----+---------+
-- | Id | Email   |
-- +----+---------+
-- | 1  | a@b.com |
-- | 2  | c@d.com |
-- | 3  | a@b.com |
-- +----+---------+
-- 根据以上输入，你的查询应返回以下结果：

-- +---------+
-- | Email   |
-- +---------+
-- | a@b.com |
-- +---------+
-- 说明：所有电子邮箱都是小写字母。

-- 来源：力扣（LeetCode）
-- 链接：https://leetcode-cn.com/problems/duplicate-emails
-- 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。


-- ----------------------------
-- Table structure for person
-- ----------------------------
DROP TABLE IF EXISTS `person`;
CREATE TABLE `person` (
  `PersonId` int(32) NOT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`PersonId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of person
-- ----------------------------
INSERT INTO `person` VALUES ('1', 'aa', 'bb', 'a@b.com');
INSERT INTO `person` VALUES ('2', 'a', 'b', 'a@b.com');
INSERT INTO `person` VALUES ('3', 'b', 'a', 'b@b.com');


select distinct email from person group by email having count(email)
 > 1;