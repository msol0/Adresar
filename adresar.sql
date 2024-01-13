-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jan 13, 2024 at 09:42 AM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `adresar`
--

-- --------------------------------------------------------

--
-- Table structure for table `kontakti`
--

DROP TABLE IF EXISTS `kontakti`;
CREATE TABLE IF NOT EXISTS `kontakti` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Ime` varchar(30) NOT NULL,
  `Prezime` varchar(30) NOT NULL,
  `Adresa` varchar(50) NOT NULL,
  `Broj_telefona` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `kontakti`
--

INSERT INTO `kontakti` (`ID`, `Ime`, `Prezime`, `Adresa`, `Broj_telefona`) VALUES
(1, 'Ivan', 'Horvatić', 'Trg bana Jelačića 1', '012345678'),
(2, 'Ana', 'Babić', 'Ilica 10', '012345679'),
(3, 'Marko', 'Marić', 'Riva 1', '0212345678'),
(4, 'Marija', 'Radić', 'Poljana kraljice Jelene 1', '021234574'),
(5, 'Tomislav', 'Jurić', 'Korzo 1', '0512345678'),
(6, 'Denis', 'Novak', 'Radićeva 62', '051234568');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
