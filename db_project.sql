-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: project
-- ------------------------------------------------------
-- Server version	8.0.30

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  `inventory_id` int DEFAULT NULL,
  `f_id` int DEFAULT NULL,
  KEY `user_id` (`user_id`),
  KEY `inventory_id` (`inventory_id`),
  KEY `f_id` (`f_id`),
  CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`User_id`),
  CONSTRAINT `admin_ibfk_2` FOREIGN KEY (`inventory_id`) REFERENCES `inventory` (`Product_id`),
  CONSTRAINT `admin_ibfk_3` FOREIGN KEY (`f_id`) REFERENCES `feedback` (`f_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES ('ali','ali.123',NULL,NULL,NULL);
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cart`
--

DROP TABLE IF EXISTS `cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cart` (
  `p_id` int DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  KEY `p_id` (`p_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`p_id`) REFERENCES `inventory` (`Product_id`),
  CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `user` (`User_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cart`
--

LOCK TABLES `cart` WRITE;
/*!40000 ALTER TABLE `cart` DISABLE KEYS */;
/*!40000 ALTER TABLE `cart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `cat_id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Chargers'),(2,'Data-Cables'),(3,'Headphones'),(4,'Computer-Accessories'),(5,'Gaming-Accessories'),(6,'RAM'),(7,'HDD'),(8,'Laptop');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedback`
--

DROP TABLE IF EXISTS `feedback`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `feedback` (
  `f_id` int NOT NULL,
  `date` date DEFAULT NULL,
  `comment` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`f_id`),
  CONSTRAINT `feedback_ibfk_1` FOREIGN KEY (`f_id`) REFERENCES `user` (`User_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedback`
--

LOCK TABLES `feedback` WRITE;
/*!40000 ALTER TABLE `feedback` DISABLE KEYS */;
/*!40000 ALTER TABLE `feedback` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `Product_id` int NOT NULL,
  `Price` int DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Stock` int DEFAULT NULL,
  `cat_id` int DEFAULT NULL,
  PRIMARY KEY (`Product_id`),
  KEY `cat_id` (`cat_id`),
  CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`cat_id`) REFERENCES `category` (`cat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES (1,450,'Type-C Charger',5,1),(2,450,'Type-A Charger',5,1),(3,300,'Type-A Data-Cable',5,2),(4,300,'Type-C Data-Cable',5,2),(6,700,'Wired-Earphones',10,3),(7,1500,'Wireless-Earphones',3,3),(8,800,'Mouse',5,4),(9,1000,'Keyboard',5,4),(10,1500,'Gaming-Mouse',2,5),(11,2500,'Gaming Keyboard',2,5),(12,1500,'Ram 4GB',2,6),(13,2500,'Ram 8GB',2,6),(14,2000,'HDD 250GB',3,7),(15,3500,'HDD 500GB',3,7),(16,60000,'HP-15',1,8),(17,145000,'ASUS VivoBook 15',1,8),(18,90000,'HP 255',1,8),(19,13500,'DELL 3511',1,8),(20,70000,'Lenovo Thinkpad',1,8);
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `laptop`
--

DROP TABLE IF EXISTS `laptop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `laptop` (
  `Generation` varchar(45) DEFAULT NULL,
  `Storage` varchar(45) DEFAULT NULL,
  `RAM` varchar(45) DEFAULT NULL,
  `Processor` varchar(45) DEFAULT NULL,
  `Inventory_Product_id` int NOT NULL,
  PRIMARY KEY (`Inventory_Product_id`),
  KEY `fk_Laptop_Inventory_idx` (`Inventory_Product_id`),
  CONSTRAINT `fk_Laptop_Inventory` FOREIGN KEY (`Inventory_Product_id`) REFERENCES `inventory` (`Product_id`),
  CONSTRAINT `laptop_ibfk_1` FOREIGN KEY (`Inventory_Product_id`) REFERENCES `inventory` (`Product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `laptop`
--

LOCK TABLES `laptop` WRITE;
/*!40000 ALTER TABLE `laptop` DISABLE KEYS */;
INSERT INTO `laptop` VALUES ('5th','500GB HDD','4GB','i5',16),('11th','500GB SSD','8GB','i5',17),('11th','500GB SSD','8GB','AMD',18),('9th','500GB SSD','8GB','i7',19),('10th','500GB HDD','8GB','i5',20);
/*!40000 ALTER TABLE `laptop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `Order_id` int NOT NULL,
  `Date` date DEFAULT NULL,
  `COD` tinyint DEFAULT NULL,
  `Online` tinyint DEFAULT NULL,
  `Inventory_Product_id` int NOT NULL,
  PRIMARY KEY (`Order_id`),
  KEY `fk_Order_Inventory1_idx` (`Inventory_Product_id`),
  CONSTRAINT `fk_Order_Inventory1` FOREIGN KEY (`Inventory_Product_id`) REFERENCES `inventory` (`Product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `User_id` int NOT NULL,
  `F_name` varchar(45) DEFAULT NULL,
  `L_name` varchar(45) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`User_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (2,'Muhammad Akmal',NULL,'akmal.123','Sialkot'),(3,'Muhammad Saim','Arshad','saim.123','Abbottabad');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'project'
--

--
-- Dumping routines for database 'project'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-12-22 18:15:59
