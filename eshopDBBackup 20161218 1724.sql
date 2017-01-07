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
  ('GhGhugriTad','Bihar','Gaya','GhugriTad');
INSERT INTO `area` (`area_id`,`STATE_NAME`,`DISTRICT_NAME`,`AREA_NAME`) VALUES 
  ('MaManpur','Bihar','Gaya','Manpur');
INSERT INTO `area` (`area_id`,`STATE_NAME`,`DISTRICT_NAME`,`AREA_NAME`) VALUES 
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
  ('Gauhar','','','','','Bihar','Gaya','C:/User/Public/AppDr/SubDir','','4A4KBQ3R');
INSERT INTO `customer_data` (`CUST_FNAME`,`CUST_LNAME`,`CUST_MOB`,`CUST_EMAIL`,`CUST_STATE`,`CUST_DISTRICT`,`CUST_AREA`,`CUST_IMG_LOC`,`CUST_IMG_FILENAME`,`CUST_ID`) VALUES 
  ('Sagar','Ali','','','Bihar','Gaya','Manpur','C:/User/Public/AppDr/SubDir','64GIPPDC.jpg','64GIPPDC');
INSERT INTO `customer_data` (`CUST_FNAME`,`CUST_LNAME`,`CUST_MOB`,`CUST_EMAIL`,`CUST_STATE`,`CUST_DISTRICT`,`CUST_AREA`,`CUST_IMG_LOC`,`CUST_IMG_FILENAME`,`CUST_ID`) VALUES 
  ('Iftekhar','Ali','9657172984','ift@gmail.com','Bihar','Gaya','Manpur','C:/User/Public/AppDr/SubDir','AO9B2WKO.JPG','AO9B2WKO');
INSERT INTO `customer_data` (`CUST_FNAME`,`CUST_LNAME`,`CUST_MOB`,`CUST_EMAIL`,`CUST_STATE`,`CUST_DISTRICT`,`CUST_AREA`,`CUST_IMG_LOC`,`CUST_IMG_FILENAME`,`CUST_ID`) VALUES 
  ('Danish','Ali','8055987455','danish@gmail.com','Bihar','Gaya','Bhusunda','C:/User/Public/AppDr/SubDir','GNH3VNHH.JPG','GNH3VNHH');
INSERT INTO `customer_data` (`CUST_FNAME`,`CUST_LNAME`,`CUST_MOB`,`CUST_EMAIL`,`CUST_STATE`,`CUST_DISTRICT`,`CUST_AREA`,`CUST_IMG_LOC`,`CUST_IMG_FILENAME`,`CUST_ID`) VALUES 
  ('Taslim','Rayee','','','Bihar','Gaya','Mofassil','C:/User/Public/AppDr/SubDir','VANKAX1R.JPG','VANKAX1R');
INSERT INTO `customer_data` (`CUST_FNAME`,`CUST_LNAME`,`CUST_MOB`,`CUST_EMAIL`,`CUST_STATE`,`CUST_DISTRICT`,`CUST_AREA`,`CUST_IMG_LOC`,`CUST_IMG_FILENAME`,`CUST_ID`) VALUES 
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
  ('3','Bihar','Aurangabad');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('BeBetiyah','Bihar','Betiyah');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('1','Bihar','Gaya');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('4','Bihar','Jehanabad');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('MoMotihari','Bihar','Motihari');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('5','Bihar','Nalanda');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('2','Bihar','Nawada');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('6','Bihar','Patna');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('SiSiwan','Bihar','Siwan');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('KaKachari','Gaya','Kachari');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('SuSurat','Gujrat','Surat');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
  ('NaNasik','Maharashtra','Nasik');
INSERT INTO `district` (`district_id`,`STATE_NAME`,`DISTRICT_NAME`) VALUES 
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
  ('GETRYID746JEG86','TIDR3R3ERR3','Orange','20','23','46','21','12','','','','','','102','','2016-10-26','','Cartoon','Danish(DNS)','');
INSERT INTO `goods_entry` (`G_ENTRY_ID`,`TRDR_ID`,`ITEM_NAME`,`WT_TXT`,`LOT_1`,`LOT_2`,`LOT_3`,`LOT_4`,`LOT_5`,`LOGISTIC_DETAILS`,`VEHICLE_NO`,`FARE_RATE`,`TOTAL_FARE`,`QTY_RCVD`,`ORIGIN`,`RECV_DATE`,`SHORT_BOX`,`WT_BOX_TYPE`,`TRDR_FNAME_TMARK`,`LOT_NO_SHORT`) VALUES 
  ('GETRYID7KTU0KWR','TIDR3R3ERR3','Anar','10','20','56','31','','','YES','MH 12 4567','56','5936','106','Nasik','2016-10-26','1','Cartoon','Danish(DNS)','1');
INSERT INTO `goods_entry` (`G_ENTRY_ID`,`TRDR_ID`,`ITEM_NAME`,`WT_TXT`,`LOT_1`,`LOT_2`,`LOT_3`,`LOT_4`,`LOT_5`,`LOGISTIC_DETAILS`,`VEHICLE_NO`,`FARE_RATE`,`TOTAL_FARE`,`QTY_RCVD`,`ORIGIN`,`RECV_DATE`,`SHORT_BOX`,`WT_BOX_TYPE`,`TRDR_FNAME_TMARK`,`LOT_NO_SHORT`) VALUES 
  ('GETRYIDFG16DE3J','TID2A9FSD6U','Orange','40','40','21','','','','','','','','60','','2016-11-20','1','Tokri','ABU(AB)','2');
INSERT INTO `goods_entry` (`G_ENTRY_ID`,`TRDR_ID`,`ITEM_NAME`,`WT_TXT`,`LOT_1`,`LOT_2`,`LOT_3`,`LOT_4`,`LOT_5`,`LOGISTIC_DETAILS`,`VEHICLE_NO`,`FARE_RATE`,`TOTAL_FARE`,`QTY_RCVD`,`ORIGIN`,`RECV_DATE`,`SHORT_BOX`,`WT_BOX_TYPE`,`TRDR_FNAME_TMARK`,`LOT_NO_SHORT`) VALUES 
  ('GETRYIDTUE0JRFI','TID3R7A2P75','Anar','20','40','30','','','','','','','','68','','2016-11-07','2','Cartoon','Rahat(RA)','2');
INSERT INTO `goods_entry` (`G_ENTRY_ID`,`TRDR_ID`,`ITEM_NAME`,`WT_TXT`,`LOT_1`,`LOT_2`,`LOT_3`,`LOT_4`,`LOT_5`,`LOGISTIC_DETAILS`,`VEHICLE_NO`,`FARE_RATE`,`TOTAL_FARE`,`QTY_RCVD`,`ORIGIN`,`RECV_DATE`,`SHORT_BOX`,`WT_BOX_TYPE`,`TRDR_FNAME_TMARK`,`LOT_NO_SHORT`) VALUES 
  ('GETRYIDUKQTXY4W','TID3R7A2P75','Anar','20','30','20','10','','','','','','','55','','2016-11-07','5','Cartoon','Rahat(RA)','2');
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
  ('TCWFB','Anar','Fruit');
INSERT INTO `item_details` (`ITEM_ID`,`ITEM_NAME`,`ITEM_CATEGORY`) VALUES 
  ('EWNKS','Bhindi','Vegetables');
INSERT INTO `item_details` (`ITEM_ID`,`ITEM_NAME`,`ITEM_CATEGORY`) VALUES 
  ('OZXJ5','Grapes','Fruit');
INSERT INTO `item_details` (`ITEM_ID`,`ITEM_NAME`,`ITEM_CATEGORY`) VALUES 
  ('WVTBD','Orange','Fruit');
INSERT INTO `item_details` (`ITEM_ID`,`ITEM_NAME`,`ITEM_CATEGORY`) VALUES 
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
-- Definition of table `lot_status`
--

DROP TABLE IF EXISTS `lot_status`;
CREATE TABLE `lot_status` (
  `LOT_ID` varchar(20) NOT NULL,
  `TOT_BOX` varchar(4) NOT NULL,
  `G_ENTRY_ID` varchar(20) NOT NULL,
  `TOT_SOLD` varchar(4) NOT NULL,
  `TOT_BAL` varchar(4) NOT NULL,
  `LOT_SERIAL` varchar(2) NOT NULL,
  `TOT_SOLD_IND` varchar(3) NOT NULL,
  PRIMARY KEY  USING BTREE (`LOT_ID`,`G_ENTRY_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lot_status`
--

/*!40000 ALTER TABLE `lot_status` DISABLE KEYS */;
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOT1P8LMCI2','56','GETRYID7KTU0KWR','0','56','2','N');
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOT283EIICF','40','GETRYIDFG16DE3J','0','40','1','N');
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOT8VI39FG5','31','GETRYID7KTU0KWR','0','31','3','N');
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOTCBTHHY92','20','GETRYIDFG16DE3J','0','20','2','N');
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOTCHRVCAJ4','28','GETRYIDTUE0JRFI','0','28','2','N');
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOTP0CCOSKE','19','GETRYID7KTU0KWR','0','19','1','N');
INSERT INTO `lot_status` (`LOT_ID`,`TOT_BOX`,`G_ENTRY_ID`,`TOT_SOLD`,`TOT_BAL`,`LOT_SERIAL`,`TOT_SOLD_IND`) VALUES 
  ('LOTRQHLRYH9','40','GETRYIDTUE0JRFI','0','40','1','N');
/*!40000 ALTER TABLE `lot_status` ENABLE KEYS */;


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
  ('clothes20160927','Clothes');
INSERT INTO `product_category` (`PRODUCT_CATEGORY_ID`,`PRODUCT_CATEGORY_NAME`) VALUES 
  ('cosmetics20160904','Cosmetics');
INSERT INTO `product_category` (`PRODUCT_CATEGORY_ID`,`PRODUCT_CATEGORY_NAME`) VALUES 
  ('fruits20160826','Fruit');
INSERT INTO `product_category` (`PRODUCT_CATEGORY_ID`,`PRODUCT_CATEGORY_NAME`) VALUES 
  ('rahat20160826','Grains');
INSERT INTO `product_category` (`PRODUCT_CATEGORY_ID`,`PRODUCT_CATEGORY_NAME`) VALUES 
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
  ('1','Bihar');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
  ('DeDelhi','Delhi');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
  ('GaGaya','Gaya');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
  ('GuGujrat','Gujrat');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
  ('MaMadhya Pardesh','Madhya Pardesh');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
  ('3','Maharashtra');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
  ('TaTamil','Tamil');
INSERT INTO `state` (`State_Id`,`STATE_NAME`) VALUES 
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
  ('GETRYID746JEG86','LOTO8YXB7L1','LOT8042075C','LOTF4AP6JYX','LOTPEDEOUVK','LOTMQA25UX0','STOCK6VIU0V1A','N');
INSERT INTO `stock_details` (`G_ENTRY_ID`,`LOTID_1`,`LOTID_2`,`LOTID_3`,`LOTID_4`,`LOTID_5`,`STOCK_ID`,`SHORT_LOT_IND`) VALUES 
  ('GETRYID7KTU0KWR','LOTP0CCOSKE','LOT1P8LMCI2','LOT8VI39FG5','LOTQXI184QD','LOTTIF3PK3F','STOCKYCPAR5I4','Y,LOTP0CCOSKE');
INSERT INTO `stock_details` (`G_ENTRY_ID`,`LOTID_1`,`LOTID_2`,`LOTID_3`,`LOTID_4`,`LOTID_5`,`STOCK_ID`,`SHORT_LOT_IND`) VALUES 
  ('GETRYIDFG16DE3J','LOT283EIICF','LOTCBTHHY92','LOT7HOWNYU6','LOTNK1FGC9H','LOT8P6MAD1D','STOCK97KLBCUR','Y,LOTCBTHHY92');
INSERT INTO `stock_details` (`G_ENTRY_ID`,`LOTID_1`,`LOTID_2`,`LOTID_3`,`LOTID_4`,`LOTID_5`,`STOCK_ID`,`SHORT_LOT_IND`) VALUES 
  ('GETRYIDTUE0JRFI','LOTRQHLRYH9','LOTCHRVCAJ4','LOTL757K7KS','LOT25DOMHMA','LOTA073MZQ7','STOCK5PAQ91AT','Y,LOTCHRVCAJ4');
INSERT INTO `stock_details` (`G_ENTRY_ID`,`LOTID_1`,`LOTID_2`,`LOTID_3`,`LOTID_4`,`LOTID_5`,`STOCK_ID`,`SHORT_LOT_IND`) VALUES 
  ('GETRYIDUKQTXY4W','LOTG487QW7K','LOTD2PLDDMW','LOTWOTYXJQ9','LOTJ3VA8L3Z','LOTQKNP1TIY','STOCKYINGKVNR','Y,LOTD2PLDDMW');
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
  ('TID2A9FSD6U','ABU','BABA','9370238539','abubaba@saheb.com','AB','Maharashtra','Nasik','4221101');
INSERT INTO `trader_info` (`TRDR_ID`,`TRDR_FNAME`,`TRDR_LNAME`,`TRDR_MOB`,`TRDR_EMAIL`,`TRDR_TMARK`,`TRDR_STATE`,`TRDR_DIST`,`TRDR_PIN`) VALUES 
  ('TID3R7A2P75','Rahat','Ali','','','RA','Bihar','Gaya','823003');
INSERT INTO `trader_info` (`TRDR_ID`,`TRDR_FNAME`,`TRDR_LNAME`,`TRDR_MOB`,`TRDR_EMAIL`,`TRDR_TMARK`,`TRDR_STATE`,`TRDR_DIST`,`TRDR_PIN`) VALUES 
  ('TIDR3R3ERR3','Danish','Ali','8055987455','danishali@gmail.com','DNS','Bihar','Jehanabad','811999');
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
  ('danish','123','admin');
INSERT INTO `user_info` (`USERNAME`,`PASSWORD`,`USER_TYPE`) VALUES 
  ('rahat','123','admin');
/*!40000 ALTER TABLE `user_info` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
