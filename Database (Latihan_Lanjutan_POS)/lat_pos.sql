-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: lat_pos
-- ------------------------------------------------------
-- Server version	5.7.16-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `daftar_brg`
--

DROP TABLE IF EXISTS `daftar_brg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daftar_brg` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Jlh_Awal` int(10) DEFAULT NULL,
  `Hrg_HPP` decimal(16,2) DEFAULT NULL,
  `Hrg_Jual` decimal(16,2) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daftar_brg`
--

LOCK TABLES `daftar_brg` WRITE;
/*!40000 ALTER TABLE `daftar_brg` DISABLE KEYS */;
/*!40000 ALTER TABLE `daftar_brg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daftar_customer`
--

DROP TABLE IF EXISTS `daftar_customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daftar_customer` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Alamat` varchar(150) DEFAULT NULL,
  `Telp` varchar(20) DEFAULT NULL,
  `HP` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daftar_customer`
--

LOCK TABLES `daftar_customer` WRITE;
/*!40000 ALTER TABLE `daftar_customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `daftar_customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daftar_pembeliandetail`
--

DROP TABLE IF EXISTS `daftar_pembeliandetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daftar_pembeliandetail` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Kode` varchar(20) NOT NULL,
  `ID_Supplier` int(10) NOT NULL,
  `ID_Barang` int(10) NOT NULL,
  `Harga_Barang` decimal(16,2) NOT NULL,
  `Kuantitas` int(100) NOT NULL,
  `Total_Harga` decimal(16,2) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daftar_pembeliandetail`
--

LOCK TABLES `daftar_pembeliandetail` WRITE;
/*!40000 ALTER TABLE `daftar_pembeliandetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `daftar_pembeliandetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daftar_penjualandetail`
--

DROP TABLE IF EXISTS `daftar_penjualandetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daftar_penjualandetail` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Kode` varchar(20) NOT NULL,
  `ID_Customer` int(10) NOT NULL,
  `ID_Barang` int(10) NOT NULL,
  `Harga_Barang` decimal(16,2) NOT NULL,
  `Kuantitas` int(100) NOT NULL,
  `Total_Harga` decimal(16,2) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daftar_penjualandetail`
--

LOCK TABLES `daftar_penjualandetail` WRITE;
/*!40000 ALTER TABLE `daftar_penjualandetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `daftar_penjualandetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `daftar_supplier`
--

DROP TABLE IF EXISTS `daftar_supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `daftar_supplier` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Alamat` varchar(150) DEFAULT NULL,
  `Telp` varchar(20) DEFAULT NULL,
  `HP` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `daftar_supplier`
--

LOCK TABLES `daftar_supplier` WRITE;
/*!40000 ALTER TABLE `daftar_supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `daftar_supplier` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-29  0:59:26
