-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema eshop
--

CREATE DATABASE IF NOT EXISTS eshop;
USE eshop;

--
-- Definition of table `area`
--

DROP TABLE IF EXISTS `area`;
CREATE TABLE `area` (
  `area_id` varchar(20) NOT NULL,
  `STATE_NAME` varchar(45) NOT NULL,
  `DISTRICT_NAME` varchar(45) NOT NULL,
  `AREA_NAME` varchar(45) NOT NULL,
  PRIMARY KEY  USING BTREE (`STATE_NAME`,`DISTRICT_NAME`,`AREA_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `area`
--

/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` (`area_id`,`STATE_NAME`,`DISTRICT_NAME`,`AREA_NAME`) VALUES 
 ('GhGhugriTad','Bihar','Gaya','GhugriTad'),
 ('MaManpur','Bihar','Gaya','Manpur'),
 ('KaKankarbagh','Bihar','Patna','Kankarbagh');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;


--
-- Definition of table `customer_data`
--

DROP TABLE IF EXISTS `customer_data`;
CREATE TABLE `customer_data` (
  `CUST_FNAME` varchar(60) NOT NULL,
  `CUST_LNAME` varchar(20) NOT NULL,
  `CUST_MOB` varchar(10) NOT NULL,
  `CUST_EMAIL` varchar(20) NOT NULL,
  `CUST_STATE` varchar(20) NOT NULL default 'CUST_STATE',
  `CUST_DISTRICT` varchar(20) NOT NULL,
  `CUST_AREA` varchar(20) NOT NULL,
  `CUST_IMG_LOC` varchar(90) NOT NULL,
  `CUST_IMG_FILENAME` varchar(45) NOT NULL,
  `CUST_ID` varchar(50) NOT NULL,
  PRIMARY KEY  (`CUST_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_data`
--

/*!40000 ALTER TABLE `customer_data` DISABLE KEYS */;
INSERT INTO `customer_data` (`CUST_FNAME`,`CUST_LNAME`,`CUST_MOB`,`CUST_EMAIL`,`CUST_STATE`,`CUST_DISTRICT`,`CUST_AREA`,`CUST_IMG_LOC`,`CUST_IMG_FILENAME`,`CUST_ID`) VALUES 
 ('Gauhar','','','','','Bihar','Gaya','C:/User/Public/AppDr/SubDir','','4A4KBQ3R'),
 ('Sagar','Ali','','','Bihar','Gaya','Manpur','C:/User/Public/AppDr/SubDir','64GIPPDC.jpg','64GIPPDC'),
 ('Iftekhar','Ali','9657172984','ift@gmail.com','Bihar','Gaya','Manpur','C:/User/Public/AppDr/SubDir','AO9B2WKO.JPG','AO9B2WKO'),
 ('Danish','Ali','8055987455','danish@gmail.com','Bihar','Gaya','Bhusunda','C:/User/Public/AppDr/SubDir','GNH3VNHH.JPG','GNH3VNHH'),
 ('Taslim','Rayee','','','Bihar','Gaya','Mofassil','C:/User/Public/AppDr/SubDir','VANKAX1R.JPG','VANKAX1R'),
 ('Zafruddin','Miyan','','','Bihar','Gaya','GhugriTad','C:/User/Public/AppDr/SubDir','','YS8M9HUW');
/*!40000 ALTER TABLE `customer_data` ENABLE KEYS */;


--
-- Definition of table `district`
--

DROP TABLE IF EXISTS `district`;
CREATE TABLE `district` (
  `district_id` varchar(20) NOT NULL,
  `STATE_NAME` varchar(45) NOT NULL,
  `DISTRICT_NAME` varchar(45) NOT NULL,
  PRIMARY KEY  USING BTREE (`STATE_NAME`,`DISTRICT_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `district`
--

/*!40000 ALTER TABLE `district` DISABLE KEYS */;
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
 ('3','Bihar','Aurangabad'),
 ('BeBetiyah','Bihar','Betiyah'),
 ('1','Bihar','Gaya'),
 ('4','Bihar','Jehanabad'),
 ('MoMotihari','Bihar','Motihari'),
 ('5','Bihar','Nalanda'),
 ('2','Bihar','Nawada'),
 ('6','Bihar','Patna'),
 ('SiSiwan','Bihar','Siwan'),
 ('KaKachari','Gaya','Kachari'),
 ('SuSurat','Gujrat','Surat'),
 ('NaNasik','Maharashtra','Nasik'),
 ('LuLucknow','UP','Lucknow');
/*!40000 ALTER TABLE `district` ENABLE KEYS */;


--
-- Definition of table `goods_entry`
--

DROP TABLE IF EXISTS `goods_entry`;
CREATE TABLE `goods_entry` (
  `G_ENTRY_ID` varchar(15) NOT NULL,
  `TRDR_ID` varchar(15) NOT NULL,
  `ITEM_NAME` varchar(15) NOT NULL,
  `WT_TXT` varchar(10) NOT NULL,
  `LOT_1` varchar(3) NOT NULL,
  `LOT_2` varchar(3) NOT NULL,
  `LOT_3` varchar(3) NOT NULL,
  `LOT_4` varchar(3) NOT NULL,
  `LOT_5` varchar(3) NOT NULL,
  `LOGISTIC_DETAILS` varchar(3) NOT NULL,
  `VEHICLE_NO` varchar(15) NOT NULL,
  `FARE_RATE` varchar(5) NOT NULL,
  `TOTAL_FARE` varchar(8) NOT NULL,
  `QTY_RCVD` varchar(4) NOT NULL,
  `ORIGIN` varchar(15) NOT NULL,
  `RECV_DATE` date NOT NULL,
  `SHORT_BOX` varchar(3) NOT NULL,
  `WT_BOX_TYPE` varchar(10) NOT NULL,
  `TRDR_FNAME_TMARK` varchar(20) NOT NULL,
  `LOT_NO_SHORT` varchar(2) NOT NULL,
  PRIMARY KEY  USING BTREE (`G_ENTRY_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `goods_entry`
--

/*!40000 ALTER TABLE `goods_entry` DISABLE KEYS */;
INSERT INTO `goods_entry` (`G_ENTRY_ID`,`TRDR_ID`,`ITEM_NAME`,`WT_TXT`,`LOT_1`,`LOT_2`,`LOT_3`,`LOT_4`,`LOT_5`,`LOGISTIC_DETAILS`,`VEHICLE_NO`,`FARE_RATE`,`TOTAL_FARE`,`QTY_RCVD`,`ORIGIN`,`RECV_DATE`,`SHORT_BOX`,`WT_BOX_TYPE`,`TRDR_FNAME_TMARK`,`LOT_NO_SHORT`) VALUES 
 ('GETRYID159TQKYM','TID2A9FSD6U','Anar','50','40','','','','','','','','','40','','2016-10-26','','Cartoon','ABU(AB)',''),
 ('GETRYID2JCB6H4P','TID2A9FSD6U','Anar','10','10','','','','','','','','','9','','2016-10-26','1','Cartoon','ABU(AB)','1'),
 ('GETRYID2L3X1MQ6','TID2A9FSD6U','Anar','20','50','30','12','2','23','YES','MH 12 3456','65','7540','116','Nasik','2016-10-24','1','Jali','ABU(AB)',''),
 ('GETRYIDEKXK7NO5','TID2A9FSD6U','Anar','10','30','5','','','','YES','MH12345','67','2278','34','Nasik','2016-10-26','1','Jali','ABU(AB)','1'),
 ('GETRYIDF2WY5EA5','TID2A9FSD6U','Anar','10','10','','','','','','','','','9','','2016-10-26','1','Cartoon','ABU(AB)','2'),
 ('GETRYIDFOC27CF1','TIDEXVHUJ0R','Anar','10','40','','','','','','','','','40','','2016-10-23','','Jali','Gauhar',''),
 ('GETRYIDN9VE9PS9','TID2A9FSD6U','Bhindi','40','50','20','','','','','','','','69','','2016-11-06','1','Bora','ABU(AB)','2'),
 ('GETRYIDNKKPNRLN','TID3R7A2P75','Grapes','4','60','','','','','','','','','55','','2016-10-24','5','Cartoon','Rahat(RA)','2'),
 ('GETRYIDNVZR4DJ6','TID2A9FSD6U','Anar','10','10','','','','','','','','','9','','2016-10-26','1','Cartoon','ABU(AB)','2'),
 ('GETRYIDOZRU4DEU','TID2A9FSD6U','Anar','69','78','','','','','','','','','73','','2016-10-24','5','Cartoon','ABU(AB)','2'),
 ('GETRYIDSO41IVR5','TID2A9FSD6U','Anar','10','10','','','','','','','','','9','','2016-10-26','1','Cartoon','ABU(AB)','3'),
 ('GETRYIDSVEUYRSM','TID2A9FSD6U','Pinapple','10','20','30','','','','','','','','48','','2016-11-06','2','Jali','ABU(AB)','2'),
 ('GETRYIDT8TBW59X','TID2A9FSD6U','Anar','20','50','','','','','','','','','45','','2016-10-24','5','Jali','ABU(AB)','1'),
 ('GETRYIDZHQUKXD1','TID3R7A2P75','Anar','10','20','','','','','','','','','20','','2016-11-04','','Cartoon','Rahat(RA)','');
/*!40000 ALTER TABLE `goods_entry` ENABLE KEYS */;


--
-- Definition of table `item_details`
--

DROP TABLE IF EXISTS `item_details`;
CREATE TABLE `item_details` (
  `ITEM_ID` varchar(20) NOT NULL,
  `ITEM_NAME` varchar(20) NOT NULL,
  `ITEM_CATEGORY` varchar(20) NOT NULL,
  PRIMARY KEY  USING BTREE (`ITEM_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `item_details`
--

/*!40000 ALTER TABLE `item_details` DISABLE KEYS */;
INSERT INTO `item_details` (`ITEM_ID`,`ITEM_NAME`,`ITEM_CATEGORY`) VALUES 
 ('TCWFB','Anar','Fruit'),
 ('EWNKS','Bhindi','Vegetables'),
 ('OZXJ5','Grapes','Fruit'),
 ('WVTBD','Orange','Fruit'),
 ('BP1ZO','Pinapple','Fruit');
/*!40000 ALTER TABLE `item_details` ENABLE KEYS */;


--
-- Definition of table `location`
--

DROP TABLE IF EXISTS `location`;
CREATE TABLE `location` (
  `LOCATION_ID` varchar(20) NOT NULL,
  `AREA` varchar(45) NOT NULL,
  `SUB_AREA` varchar(45) NOT NULL,
  PRIMARY KEY  USING BTREE (`LOCATION_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `location`
--

/*!40000 ALTER TABLE `location` DISABLE KEYS */;
/*!40000 ALTER TABLE `location` ENABLE KEYS */;


--
-- Definition of table `lot_details`
--

DROP TABLE IF EXISTS `lot_details`;
CREATE TABLE `lot_details` (
  `LOT_ID` varchar(20) NOT NULL,
  `TOT_BOX` varchar(20) NOT NULL,
  `G_ENTRY_ID` varchar(45) NOT NULL,
  PRIMARY KEY  (`LOT_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lot_details`
--

/*!40000 ALTER TABLE `lot_details` DISABLE KEYS */;
INSERT INTO `lot_details` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`) VALUES 
 ('LOTDDYYIDCD','','GETRYIDN9VE9PS9'),
 ('LOTG1ZLRPHX','','GETRYIDN9VE9PS9'),
 ('LOTLVZV4VXJ','28','GETRYIDSVEUYRSM'),
 ('LOTOGXHOVQY','19','GETRYIDN9VE9PS9'),
 ('LOTOWJU3LLY','','GETRYIDN9VE9PS9'),
 ('LOTPREYCIYZ','','GETRYIDSVEUYRSM'),
 ('LOTSTODV7S1','20','GETRYIDSVEUYRSM'),
 ('LOTTJ9CF0NI','','GETRYIDSVEUYRSM'),
 ('LOTUCVGZMPU','','GETRYIDSVEUYRSM'),
 ('LOTX63HOT1M','50','GETRYIDN9VE9PS9');
/*!40000 ALTER TABLE `lot_details` ENABLE KEYS */;


--
-- Definition of table `product_category`
--

DROP TABLE IF EXISTS `product_category`;
CREATE TABLE `product_category` (
  `PRODUCT_CATEGORY_ID` varchar(20) NOT NULL,
  `PRODUCT_CATEGORY_NAME` varchar(45) NOT NULL,
  PRIMARY KEY  (`PRODUCT_CATEGORY_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product_category`
--

/*!40000 ALTER TABLE `product_category` DISABLE KEYS */;
INSERT INTO `product_category` (`PRODUCT_CATEGORY_ID`,`PRODUCT_CATEGORY_NAME`) VALUES 
 ('clothes20160927','Clothes'),
 ('cosmetics20160904','Cosmetics'),
 ('fruits20160826','Fruit'),
 ('rahat20160826','Grains'),
 ('vegetables20160826','Vegetables');
/*!40000 ALTER TABLE `product_category` ENABLE KEYS */;


--
-- Definition of table `sells_details`
--

DROP TABLE IF EXISTS `sells_details`;
CREATE TABLE `sells_details` (
  `SELLS_ID` varchar(20) NOT NULL,
  `CUST_ID` varchar(45) NOT NULL,
  `G_ENRTY_ID` varchar(45) NOT NULL,
  `STOCK_ID` varchar(45) NOT NULL,
  `LOT_ID` varchar(45) NOT NULL,
  `SELLS_DATE` date NOT NULL,
  `ITEM_NAME` varchar(45) NOT NULL,
  `TOTAL_QTY` varchar(45) NOT NULL,
  `RATE` varchar(45) NOT NULL,
  `T_AMOUNT` varchar(45) NOT NULL,
  PRIMARY KEY  (`SELLS_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sells_details`
--

/*!40000 ALTER TABLE `sells_details` DISABLE KEYS */;
/*!40000 ALTER TABLE `sells_details` ENABLE KEYS */;


--
-- Definition of table `sells_track`
--

DROP TABLE IF EXISTS `sells_track`;
CREATE TABLE `sells_track` (
  `G_ENTRY_ID` varchar(20) NOT NULL,
  `LOT_ID` varchar(45) NOT NULL,
  `TOT_QTY` varchar(45) NOT NULL,
  `TOT_BAL` varchar(45) NOT NULL,
  `TOT_SHORT` varchar(45) NOT NULL,
  PRIMARY KEY  (`G_ENTRY_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sells_track`
--

/*!40000 ALTER TABLE `sells_track` DISABLE KEYS */;
/*!40000 ALTER TABLE `sells_track` ENABLE KEYS */;


--
-- Definition of table `state`
--

DROP TABLE IF EXISTS `state`;
CREATE TABLE `state` (
  `State_Id` varchar(20) NOT NULL,
  `STATE_NAME` varchar(45) NOT NULL,
  PRIMARY KEY  USING BTREE (`STATE_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `state`
--

/*!40000 ALTER TABLE `state` DISABLE KEYS */;
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
 ('1','Bihar'),
 ('DeDelhi','Delhi'),
 ('GaGaya','Gaya'),
 ('GuGujrat','Gujrat'),
 ('MaMadhya Pardesh','Madhya Pardesh'),
 ('3','Maharashtra'),
 ('TaTamil','Tamil'),
 ('WeWest Bengal','West Bengal');
/*!40000 ALTER TABLE `state` ENABLE KEYS */;


--
-- Definition of table `stock_details`
--

DROP TABLE IF EXISTS `stock_details`;
CREATE TABLE `stock_details` (
  `G_ENTRY_ID` varchar(15) NOT NULL,
  `LOTID_1` varchar(15) NOT NULL,
  `LOTID_2` varchar(15) NOT NULL,
  `LOTID_3` varchar(15) NOT NULL,
  `LOTID_4` varchar(15) NOT NULL,
  `LOTID_5` varchar(15) NOT NULL,
  `STOCK_ID` varchar(15) NOT NULL,
  `SHORT_LOT_IND` varchar(15) NOT NULL,
  PRIMARY KEY  USING BTREE (`G_ENTRY_ID`,`STOCK_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock_details`
--

/*!40000 ALTER TABLE `stock_details` DISABLE KEYS */;
INSERT INTO `stock_details` (`G_ENTRY_ID`,`LOTID_1`,`LOTID_2`,`LOTID_3`,`LOTID_4`,`LOTID_5`,`STOCK_ID`,`SHORT_LOT_IND`) VALUES 
 ('GETRYIDN9VE9PS9','LOTX63HOT1M','LOTOGXHOVQY','LOTG1ZLRPHX','LOTDDYYIDCD','LOTOWJU3LLY','STOCK5LL8U5W2','Y,LOTOGXHOVQY');
/*!40000 ALTER TABLE `stock_details` ENABLE KEYS */;


--
-- Definition of table `trader_info`
--

DROP TABLE IF EXISTS `trader_info`;
CREATE TABLE `trader_info` (
  `TRDR_ID` varchar(20) NOT NULL,
  `TRDR_FNAME` varchar(45) NOT NULL,
  `TRDR_LNAME` varchar(45) NOT NULL,
  `TRDR_MOB` varchar(45) NOT NULL,
  `TRDR_EMAIL` varchar(45) NOT NULL,
  `TRDR_TMARK` varchar(45) NOT NULL,
  `TRDR_STATE` varchar(45) NOT NULL,
  `TRDR_DIST` varchar(45) NOT NULL,
  `TRDR_PIN` varchar(45) NOT NULL,
  PRIMARY KEY  (`TRDR_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trader_info`
--

/*!40000 ALTER TABLE `trader_info` DISABLE KEYS */;
INSERT INTO `trader_info` (`TRDR_ID`,`TRDR_FNAME`,`TRDR_LNAME`,`TRDR_MOB`,`TRDR_EMAIL`,`TRDR_TMARK`,`TRDR_STATE`,`TRDR_DIST`,`TRDR_PIN`) VALUES 
 ('TID2A9FSD6U','ABU','BABA','9370238539','abubaba@saheb.com','AB','Maharashtra','Nasik','4221101'),
 ('TID3R7A2P75','Rahat','Ali','','','RA','Bihar','Gaya','823003'),
 ('TIDEXVHUJ0R','Gauhar','','','','','Bihar','Gaya','823003'),
 ('TIDOW7NZU0N','Mustaque','Ahmad','','','','Bihar','Gaya','230000');
/*!40000 ALTER TABLE `trader_info` ENABLE KEYS */;


--
-- Definition of table `user_info`
--

DROP TABLE IF EXISTS `user_info`;
CREATE TABLE `user_info` (
  `USERNAME` varchar(20) NOT NULL,
  `PASSWORD` varchar(20) NOT NULL,
  `USER_TYPE` varchar(10) NOT NULL,
  PRIMARY KEY  (`USERNAME`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_info`
--

/*!40000 ALTER TABLE `user_info` DISABLE KEYS */;
INSERT INTO `user_info` (`USERNAME`,`PASSWORD`,`USER_TYPE`) VALUES 
 ('danish','123','admin'),
 ('rahat','123','admin');
/*!40000 ALTER TABLE `user_info` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
