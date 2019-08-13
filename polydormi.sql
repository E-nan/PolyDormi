/*
SQLyog Community v13.1.2 (64 bit)
MySQL - 5.5.62 : Database - polydormi
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`polydormi` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `polydormi`;

/*Table structure for table `baekdu_stat` */

DROP TABLE IF EXISTS `baekdu_stat`;

CREATE TABLE `baekdu_stat` (
  `room` varchar(10) NOT NULL,
  `stuA` varchar(10) DEFAULT NULL,
  `stuB` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `baekdu_stat` */

insert  into `baekdu_stat`(`room`,`stuA`,`stuB`) values 
('101','111',''),
('102','',''),
('103','',''),
('104','',''),
('105','',''),
('106','',''),
('107','',''),
('108','',''),
('109','',''),
('110','',''),
('201',NULL,NULL),
('202',NULL,NULL),
('203',NULL,NULL),
('204',NULL,NULL),
('205',NULL,NULL),
('206',NULL,NULL),
('207',NULL,NULL),
('208',NULL,NULL),
('209',NULL,NULL),
('210',NULL,NULL),
('301',NULL,NULL),
('302',NULL,NULL),
('303',NULL,NULL),
('304',NULL,NULL),
('305',NULL,NULL),
('306',NULL,NULL),
('307',NULL,NULL),
('308',NULL,NULL),
('309',NULL,NULL),
('310',NULL,NULL),
('401',NULL,NULL),
('402',NULL,NULL),
('403',NULL,NULL),
('404',NULL,NULL),
('405',NULL,NULL),
('406',NULL,NULL),
('407',NULL,NULL),
('408',NULL,NULL),
('409',NULL,NULL),
('410',NULL,NULL);

/*Table structure for table `baekdu_stu` */

DROP TABLE IF EXISTS `baekdu_stu`;

CREATE TABLE `baekdu_stu` (
  `room` varchar(10) NOT NULL,
  `stu_name` varchar(20) NOT NULL,
  `major` varchar(50) NOT NULL,
  `stu_num` varchar(11) NOT NULL,
  `grade` varchar(11) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `jointime` varchar(10) NOT NULL,
  `outtime` varchar(10) NOT NULL DEFAULT '~',
  PRIMARY KEY (`stu_num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `baekdu_stu` */

insert  into `baekdu_stu`(`room`,`stu_name`,`major`,`stu_num`,`grade`,`sex`,`jointime`,`outtime`) values 
('101','111','메카트로닉스','111','1학년','남','2019-06-24','');

/*Table structure for table `build_baekdu` */

DROP TABLE IF EXISTS `build_baekdu`;

CREATE TABLE `build_baekdu` (
  `floor` varchar(3) NOT NULL,
  `build_name` varchar(10) NOT NULL,
  `ox` varchar(2) NOT NULL DEFAULT 'x',
  `break` varchar(10) NOT NULL,
  `repair` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `build_baekdu` */

/*Table structure for table `build_halla` */

DROP TABLE IF EXISTS `build_halla`;

CREATE TABLE `build_halla` (
  `floor` varchar(3) NOT NULL,
  `build_name` varchar(10) NOT NULL,
  `ox` varchar(2) NOT NULL DEFAULT 'x',
  `break` varchar(10) NOT NULL,
  `repair` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `build_halla` */

insert  into `build_halla`(`floor`,`build_name`,`ox`,`break`,`repair`) values 
('1F','세탁기','x','2019-06-25',''),
('1F','전자레인지','x','2019-06-25',''),
('3F','TV','x','2019-06-25',''),
('4F','403호 샤워호스','x','2019-06-25',''),
('4F','408호 세면대','x','2019-06-25','');

/*Table structure for table `halla_stat` */

DROP TABLE IF EXISTS `halla_stat`;

CREATE TABLE `halla_stat` (
  `room` varchar(10) NOT NULL,
  `stuA` varchar(10) DEFAULT NULL,
  `stuB` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `halla_stat` */

insert  into `halla_stat`(`room`,`stuA`,`stuB`) values 
('101','정인환','아무개'),
('102','',''),
('103','',''),
('104','',''),
('105','',''),
('106','',''),
('107','',''),
('108','',''),
('109','',''),
('110','',''),
('201','',''),
('202','',''),
('203','',''),
('204','',''),
('205','',''),
('206','',''),
('207','',''),
('208','',''),
('209','',''),
('210','',''),
('301','',''),
('302','',''),
('303','',''),
('304','',''),
('305','',''),
('306','',''),
('307','',''),
('308','',''),
('309','',''),
('310','',''),
('401','',''),
('402','',''),
('403','',''),
('404','',''),
('405','',''),
('406','',''),
('407','',''),
('408','',''),
('409','',''),
('410','','');

/*Table structure for table `halla_stu` */

DROP TABLE IF EXISTS `halla_stu`;

CREATE TABLE `halla_stu` (
  `room` varchar(10) NOT NULL,
  `stu_name` varchar(20) NOT NULL,
  `major` varchar(50) NOT NULL,
  `stu_num` varchar(11) NOT NULL,
  `grade` varchar(11) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `jointime` varchar(10) NOT NULL,
  `outtime` varchar(10) NOT NULL DEFAULT '~',
  PRIMARY KEY (`stu_num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `halla_stu` */

insert  into `halla_stu`(`room`,`stu_name`,`major`,`stu_num`,`grade`,`sex`,`jointime`,`outtime`) values 
('101','정인환','컴퓨터정보','1502100484','2학년','남','2019-06-25',''),
('101','아무개','전기에너지시스템','1903400241','1학년','남','2019-06-25','');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
