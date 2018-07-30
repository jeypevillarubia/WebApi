-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 31, 2018 at 12:27 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `practice311`
--

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE IF NOT EXISTS `grades` (
  `Id` int(10) NOT NULL AUTO_INCREMENT,
  `GradeId` int(11) NOT NULL,
  `prelim` double NOT NULL,
  `midterm` double NOT NULL,
  `ave` double NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `GradeId` (`GradeId`),
  KEY `GradeId_2` (`GradeId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `studentinfo`
--

CREATE TABLE IF NOT EXISTS `studentinfo` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `fn` varchar(40) NOT NULL,
  `ln` varchar(40) NOT NULL,
  `course` varchar(40) NOT NULL,
  `prelim` double NOT NULL,
  `midterm` double NOT NULL,
  `ave` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=95 ;

--
-- Dumping data for table `studentinfo`
--

INSERT INTO `studentinfo` (`ID`, `fn`, `ln`, `course`, `prelim`, `midterm`, `ave`) VALUES
(90, 'John', 'malbas', 'BSIT', 0, 0, 0),
(91, 'Murlock', 'nightCrawler', 'shadowDancer', 0, 0, 0),
(93, 'Luna', 'moonfang', 'nuker', 0, 0, 0),
(94, 'Mirana', 'priestesOfMoon', 'BEED', 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE IF NOT EXISTS `subject` (
  `subId` int(30) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`subId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
