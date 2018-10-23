-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2018 at 05:41 PM
-- Server version: 10.1.35-MariaDB
-- PHP Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `test`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `AccountId` varchar(225) NOT NULL,
  `UserId` varchar(225) NOT NULL,
  `AccountName` varchar(225) NOT NULL,
  `SoldDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Installment` decimal(10,0) NOT NULL,
  `StatusId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`AccountId`, `UserId`, `AccountName`, `SoldDate`, `Installment`, `StatusId`) VALUES
('98621f76-d6af-11e8-90cb-f48e38e878a3', '96dd5311-d63c-11e8-951a-f48e38e878a3', 'Starter Account', '2018-10-23 12:37:09', '500', 1),
('986f3339-d6af-11e8-90cb-f48e38e878a3', '46aaace2-d63d-11e8-951a-f48e38e878a3', 'Gold Account', '2018-10-23 12:37:09', '2500', 1),
('986f347d-d6af-11e8-90cb-f48e38e878a3', '46aab1a2-d63d-11e8-951a-f48e38e878a3', 'Platinum Account', '2018-10-23 12:37:09', '5000', 1),
('b7861f74-d6af-11e8-90cb-f48e38e878a3', '96dd4ec3-d63c-11e8-951a-f48e38e878a3\r\n', 'Savings Account', '2018-10-23 12:32:01', '1500', 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserId` varchar(225) NOT NULL COMMENT 'Guid Field',
  `FirstName` varchar(150) NOT NULL,
  `Surname` varchar(150) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `StatusId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserId`, `FirstName`, `Surname`, `Email`, `StatusId`) VALUES
('96dd4ec3-d63c-11e8-951a-f48e38e878a3', 'Freedom', 'Khanyile', 'freedom@mail.com', 1),
('96dd5311-d63c-11e8-951a-f48e38e878a3', 'Ndumiso', 'Mthembu', 'ndumiso@mail.com', 1),
('46aaace2-d63d-11e8-951a-f48e38e878a3', 'Clair', 'Simons', 'clair@mail.com', 1),
('46aab1a2-d63d-11e8-951a-f48e38e878a3', 'Rick', 'Automn', 'rick@mail.com', 1),
('cb3cdcfb-4e9d-4957-a9fb-91959fc4f276', 'Lucas', 'Radebe', 'lucas@mail.com', 1),
('b920ac56-02fe-4ab0-836f-8d322b8f80b3', 'Shaka', 'Zulu', 'shaka@mail.com', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`AccountId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
