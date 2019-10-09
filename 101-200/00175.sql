// 表1: Person

// +-------------+---------+
// | 列名         | 类型     |
// +-------------+---------+
// | PersonId    | int     |
// | FirstName   | varchar |
// | LastName    | varchar |
// +-------------+---------+
// PersonId 是上表主键
// 表2: Address

// +-------------+---------+
// | 列名         | 类型    |
// +-------------+---------+
// | AddressId   | int     |
// | PersonId    | int     |
// | City        | varchar |
// | State       | varchar |
// +-------------+---------+
// AddressId 是上表主键
//

// 编写一个 SQL 查询，满足条件：无论 person 是否有地址信息，都需要基于上述两表提供 person 的以下信息：

//

// FirstName, LastName, City, State

// 来源：力扣（LeetCode）
// 链接：https://leetcode-cn.com/problems/combine-two-tables
// 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

-- ----------------------------
-- Table structure for person
-- ----------------------------
DROP TABLE IF EXISTS `person`;
CREATE TABLE `person` (
  `PersonId` int(32) NOT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`PersonId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of person
-- ----------------------------
INSERT INTO `person` VALUES ('1', 'aa', 'bb');


-- ----------------------------
-- Table structure for address
-- ----------------------------
DROP TABLE IF EXISTS `address`;
CREATE TABLE `address` (
  `AddressId` int(11) NOT NULL,
  `PersonId` int(11) DEFAULT NULL,
  `City` varchar(255) DEFAULT NULL,
  `State` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`AddressId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


select a.FirstName, a.LastName, b.City, b.State from person a left join address b on a.PersonId = b.PersonId;