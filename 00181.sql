-- Employee 表包含所有员工，他们的经理也属于员工。每个员工都有一个 Id，此外还有一列对应员工的经理的 Id。

-- +----+-------+--------+-----------+
-- | Id | Name  | Salary | ManagerId |
-- +----+-------+--------+-----------+
-- | 1  | Joe   | 70000  | 3         |
-- | 2  | Henry | 80000  | 4         |
-- | 3  | Sam   | 60000  | NULL      |
-- | 4  | Max   | 90000  | NULL      |
-- +----+-------+--------+-----------+
-- 给定 Employee 表，编写一个 SQL 查询，该查询可以获取收入超过他们经理的员工的姓名。在上面的表格中，Joe 是唯一一个收入超过他的经理的员工。

-- +----------+
-- | Employee |
-- +----------+
-- | Joe      |
-- +----------+

-- 来源：力扣（LeetCode）
-- 链接：https://leetcode-cn.com/problems/employees-earning-more-than-their-managers
-- 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `Salary` int(10) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `ManagerId` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES ('1', '7000', 'Joe', '3');
INSERT INTO `employee` VALUES ('2', '8000', 'Henry', '4');
INSERT INTO `employee` VALUES ('3', '6000', 'Sam', null);
INSERT INTO `employee` VALUES ('4', '9000', 'Max', null);


select a.name as employee
 from employee a left join employee b on a.managerid = b.id where a.salary > b.salary;