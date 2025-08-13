-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- 主機: 127.0.0.1
-- 產生時間： 2025-08-12 15:23:49
-- 伺服器版本: 10.1.30-MariaDB
-- PHP 版本： 5.6.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `4511asm`
--
CREATE DATABASE IF NOT EXISTS `4511asm` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `4511asm`;

-- --------------------------------------------------------

--
-- 資料表結構 `city`
--

CREATE TABLE `city` (
  `cityId` int(2) NOT NULL,
  `city` varchar(255) NOT NULL,
  `country` enum('China','Japan','USA') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `city`
--

INSERT INTO `city` (`cityId`, `city`, `country`) VALUES
(1, 'Tokyo', 'Japan'),
(2, 'Kyoto', 'Japan'),
(3, 'New York', 'USA'),
(4, 'Hong Kong', 'China');

-- --------------------------------------------------------

--
-- 資料表結構 `delivery_log`
--

CREATE TABLE `delivery_log` (
  `number` varchar(11) NOT NULL,
  `source` int(11) NOT NULL,
  `destination` int(11) NOT NULL,
  `fruitId` int(3) NOT NULL,
  `quantity` int(11) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `delivery_log`
--

INSERT INTO `delivery_log` (`number`, `source`, `destination`, `fruitId`, `quantity`, `date`) VALUES
('11202503254', 11, 4, 4, 7, '2025-04-24'),
('11202504031', 11, 1, 1, 5, '2025-04-28'),
('11202504031', 11, 1, 2, 5, '2025-04-28'),
('11202504031', 11, 1, 3, 5, '2025-04-24'),
('11202504034', 11, 4, 2, 3, '2025-04-24'),
('11202504034', 11, 4, 3, 3, '2025-04-24'),
('11202504096', 11, 6, 1, 2, '2025-04-24'),
('11202504096', 11, 6, 2, 2, '2025-04-24'),
('11202504096', 11, 6, 3, 2, '2025-04-24'),
('11202504102', 11, 2, 2, 3, '2025-04-28'),
('11202504102', 11, 2, 4, 3, '2025-04-24'),
('11202504102', 11, 2, 10, 3, '2025-04-24'),
('13202504151', 13, 1, 5, 4, '2025-04-24'),
('13202504221', 13, 1, 5, 2, '2025-04-24'),
('14202504135', 14, 5, 9, 3, '2025-04-24'),
('14202504141', 14, 1, 8, 6, '2025-04-24'),
('14202504151', 14, 1, 7, 2, '2025-04-24'),
('14202504221', 14, 1, 7, 3, '2025-04-24'),
('9202504151', 9, 1, 6, 1, '2025-04-15');

-- --------------------------------------------------------

--
-- 資料表結構 `fruit`
--

CREATE TABLE `fruit` (
  `fruitId` int(3) NOT NULL,
  `fruitName` varchar(255) NOT NULL,
  `source_country` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `fruit`
--

INSERT INTO `fruit` (`fruitId`, `fruitName`, `source_country`) VALUES
(1, 'Strawberry', 'Japan'),
(2, 'Blueberry', 'Japan'),
(3, 'Mango', 'Japan'),
(4, 'Dragon Fruit', 'Japan'),
(5, 'Kiwi', 'USA'),
(6, 'Banana', 'USA'),
(7, 'Peach', 'China'),
(8, 'Pineapple', 'China'),
(9, 'Raspberry', 'China'),
(10, 'Durian', 'Japan');

-- --------------------------------------------------------

--
-- 資料表結構 `location`
--

CREATE TABLE `location` (
  `locationId` int(3) NOT NULL,
  `cityId` int(2) NOT NULL,
  `locationName` varchar(255) NOT NULL,
  `locationType` enum('Shop','SourceWarehouse','CentralWarehouse') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `location`
--

INSERT INTO `location` (`locationId`, `cityId`, `locationName`, `locationType`) VALUES
(1, 1, 'Shibuya Bakery', 'Shop'),
(2, 1, 'Ueno Sweet House', 'Shop'),
(3, 2, 'Manhattan Bakes', 'Shop'),
(4, 2, 'Brooklyn Bread Shop', 'Shop'),
(5, 3, 'Kowloon Golden Oven', 'Shop'),
(6, 4, 'Central Sugar House', 'Shop'),
(7, 4, 'Kyoto Delights', 'Shop'),
(8, 1, 'Tokyo Central WH', 'CentralWarehouse'),
(9, 3, 'New York Central WH', 'CentralWarehouse'),
(10, 4, 'Hong Kong Central WH', 'CentralWarehouse'),
(11, 1, 'Hokkaido WH', 'SourceWarehouse'),
(12, 2, 'California WH', 'SourceWarehouse'),
(13, 3, 'Manila WH', 'SourceWarehouse'),
(14, 4, 'Hanoi WH', 'SourceWarehouse'),
(15, 1, 'New shop open', 'Shop');

-- --------------------------------------------------------

--
-- 資料表結構 `reservation`
--

CREATE TABLE `reservation` (
  `locationId` int(3) NOT NULL,
  `fruitId` int(3) NOT NULL,
  `date` date NOT NULL,
  `quantity` int(11) NOT NULL,
  `status` enum('Pending','Approved','Rejected','Delivering','Delivered') NOT NULL,
  `updateAt` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `reservation`
--

INSERT INTO `reservation` (`locationId`, `fruitId`, `date`, `quantity`, `status`, `updateAt`) VALUES
(1, 1, '2025-04-03', 5, 'Delivered', '2025-04-18 15:47:55'),
(1, 1, '2025-04-15', 1, 'Delivered', '2025-04-18 15:47:55'),
(1, 1, '2025-04-22', 1, 'Delivered', '2025-04-22 13:06:15'),
(1, 1, '2025-04-24', 15, 'Delivered', '2025-04-24 07:23:01'),
(1, 2, '2025-04-15', 2, 'Delivered', '2025-04-18 15:47:55'),
(1, 2, '2025-04-22', 2, 'Delivered', '2025-04-22 13:12:37'),
(1, 2, '2025-04-24', 2, 'Delivered', '2025-04-24 07:23:01'),
(1, 2, '2025-04-29', 15, 'Delivered', '2025-04-29 04:28:41'),
(1, 3, '2025-04-15', 1, 'Delivered', '2025-04-18 15:47:55'),
(1, 3, '2025-04-24', 15, 'Approved', '2025-04-24 07:23:01'),
(1, 4, '2025-04-15', 3, 'Delivered', '2025-04-18 15:47:55'),
(1, 4, '2025-04-22', 2, 'Delivered', '2025-04-22 13:14:18'),
(1, 4, '2025-04-24', 10, 'Delivering', '2025-04-24 07:23:01'),
(1, 5, '2025-04-15', 4, 'Delivering', '2025-04-18 15:47:55'),
(1, 5, '2025-04-22', 2, 'Delivering', '2025-04-22 13:06:15'),
(1, 5, '2025-04-24', 30, 'Approved', '2025-04-24 07:23:01'),
(1, 5, '2025-04-29', 20, 'Pending', '2025-04-29 04:28:41'),
(1, 5, '2025-07-15', 10, 'Rejected', '2025-04-18 15:47:55'),
(1, 6, '2025-08-15', 1, 'Delivered', '2025-04-18 15:47:55'),
(1, 7, '2025-04-15', 2, 'Delivering', '2025-04-18 15:47:55'),
(1, 7, '2025-04-22', 3, 'Delivering', '2025-04-22 13:06:15'),
(1, 8, '2025-04-14', 6, 'Delivering', '2025-04-18 15:47:55'),
(1, 8, '2025-04-22', 1, 'Approved', '2025-04-22 13:14:43'),
(1, 8, '2025-04-24', 6, 'Approved', '2025-04-24 07:23:01'),
(1, 9, '2025-04-15', 1, 'Pending', '2025-04-18 15:47:55'),
(1, 9, '2025-04-24', 50, 'Pending', '2025-04-24 07:23:01'),
(1, 9, '2025-04-29', 5, 'Pending', '2025-04-29 04:28:41'),
(1, 10, '2025-04-22', 1, 'Delivering', '2025-04-22 15:33:04'),
(1, 10, '2025-04-24', 14, 'Pending', '2025-04-24 07:23:01'),
(2, 2, '2025-04-10', 3, 'Delivering', '2025-04-18 15:47:55'),
(2, 6, '2025-04-02', 8, 'Delivered', '2025-04-18 15:47:55'),
(2, 9, '2025-03-20', 1, 'Rejected', '2025-04-18 15:47:55'),
(3, 3, '2025-04-15', 10, 'Rejected', '2025-04-18 15:47:55'),
(3, 7, '2025-01-22', 1, 'Pending', '2025-04-18 15:47:55'),
(3, 10, '2025-12-11', 9, 'Approved', '2025-04-18 15:47:55'),
(4, 1, '2025-04-24', 50, 'Delivering', '2025-04-24 07:23:26'),
(4, 1, '2025-10-03', 3, 'Delivering', '2025-04-18 15:47:55'),
(4, 3, '2025-04-24', 40, 'Delivering', '2025-04-24 07:23:26'),
(4, 4, '2025-03-25', 7, 'Delivering', '2025-04-18 15:47:55'),
(4, 4, '2025-04-24', 50, 'Approved', '2025-04-24 07:23:26'),
(4, 5, '2025-04-24', 20, 'Delivering', '2025-04-24 07:23:26'),
(4, 6, '2025-04-24', 15, 'Approved', '2025-04-24 07:23:26'),
(4, 8, '2025-04-08', 7, 'Rejected', '2025-04-18 15:47:55'),
(4, 8, '2025-04-24', 10, 'Approved', '2025-04-24 07:23:26'),
(5, 2, '2025-03-28', 5, 'Rejected', '2025-04-18 15:47:55'),
(5, 4, '2025-04-24', 50, 'Delivering', '2025-04-24 07:23:53'),
(5, 5, '2025-04-01', 2, 'Pending', '2025-04-18 15:47:55'),
(5, 5, '2025-04-24', 56, 'Approved', '2025-04-24 07:23:53'),
(5, 9, '2025-04-13', 3, 'Delivering', '2025-04-18 15:47:55'),
(5, 9, '2025-04-24', 44, 'Pending', '2025-04-24 07:23:53'),
(5, 10, '2025-04-24', 63, 'Pending', '2025-04-24 07:23:53'),
(6, 3, '2025-04-09', 2, 'Delivering', '2025-04-18 15:47:55'),
(6, 6, '2025-03-30', 4, 'Rejected', '2025-04-18 15:47:55'),
(6, 10, '2025-03-29', 6, 'Pending', '2025-04-18 15:47:55'),
(7, 1, '2025-04-04', 5, 'Rejected', '2025-04-18 15:47:55'),
(7, 4, '2025-04-06', 4, 'Pending', '2025-04-18 15:47:55'),
(7, 7, '2025-04-05', 8, 'Delivering', '2025-04-18 15:47:55');

-- --------------------------------------------------------

--
-- 資料表結構 `stock`
--

CREATE TABLE `stock` (
  `locationId` int(11) NOT NULL,
  `fruitId` int(11) NOT NULL,
  `quantity` int(11) DEFAULT NULL,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `stock`
--

INSERT INTO `stock` (`locationId`, `fruitId`, `quantity`, `updated_at`) VALUES
(1, 1, 380, '2025-04-28 16:52:20'),
(1, 2, 55, '2025-04-29 04:35:25'),
(1, 3, 70, '2025-04-29 04:30:31'),
(1, 4, 94, '2025-04-29 04:35:25'),
(1, 5, 118, '2025-04-29 04:30:31'),
(1, 6, 30, '2025-04-28 16:47:18'),
(1, 7, 60, '2025-04-28 16:48:27'),
(1, 8, 31, '2025-04-16 12:56:45'),
(1, 9, 19, '2025-04-16 12:56:45'),
(1, 10, 13, '2025-04-16 12:56:45'),
(2, 1, 50, '2025-04-28 16:03:52'),
(2, 2, 20, '2025-04-28 15:49:16'),
(2, 3, 45, '2025-04-28 15:50:21'),
(2, 4, 45, '2025-04-16 12:56:45'),
(2, 5, 24, '2025-04-28 15:50:21'),
(2, 6, 42, '2025-04-18 16:19:06'),
(2, 7, 25, '2025-04-16 12:56:45'),
(2, 8, 49, '2025-04-16 12:56:45'),
(2, 9, 50, '2025-04-28 14:06:58'),
(2, 10, 30, '2025-04-16 12:56:45'),
(3, 1, 39, '2025-04-16 12:56:45'),
(3, 2, 21, '2025-04-16 12:56:45'),
(3, 3, 11, '2025-04-16 12:56:45'),
(3, 4, 8, '2025-04-16 12:56:45'),
(3, 5, 41, '2025-04-16 12:56:45'),
(3, 6, 24, '2025-04-16 12:56:45'),
(3, 7, 20, '2025-04-16 12:56:45'),
(3, 8, 32, '2025-04-16 12:56:45'),
(3, 9, 29, '2025-04-16 12:56:45'),
(3, 10, 12, '2025-04-16 12:56:45'),
(4, 1, 10, '2025-04-16 12:56:45'),
(4, 2, 33, '2025-04-16 12:56:45'),
(4, 3, 48, '2025-04-16 12:56:45'),
(4, 4, 44, '2025-04-16 12:56:45'),
(4, 5, 18, '2025-04-16 12:56:45'),
(4, 6, 36, '2025-04-16 12:56:45'),
(4, 7, 43, '2025-04-16 12:56:45'),
(4, 8, 6, '2025-04-16 12:56:45'),
(4, 9, 16, '2025-04-16 12:56:45'),
(4, 10, 40, '2025-04-16 12:56:45'),
(5, 1, 47, '2025-04-16 12:56:45'),
(5, 2, 27, '2025-04-16 12:56:45'),
(5, 3, 5, '2025-04-16 12:56:45'),
(5, 4, 3, '2025-04-16 12:56:45'),
(5, 5, 46, '2025-04-16 12:56:45'),
(5, 6, 23, '2025-04-16 12:56:45'),
(5, 7, 4, '2025-04-16 12:56:45'),
(5, 8, 2, '2025-04-16 12:56:45'),
(5, 9, 35, '2025-04-16 12:56:45'),
(5, 10, 1, '2025-04-16 12:56:45'),
(6, 1, 45, '2025-04-28 13:46:25'),
(6, 2, 24, '2025-04-28 13:22:33'),
(6, 3, 36, '2025-04-16 12:56:45'),
(6, 4, 19, '2025-04-16 12:56:45'),
(6, 5, 30, '2025-04-28 13:23:09'),
(6, 6, 28, '2025-04-16 12:56:45'),
(6, 7, 30, '2025-04-28 13:46:25'),
(6, 8, 21, '2025-04-16 12:56:45'),
(6, 9, 28, '2025-04-28 13:22:33'),
(6, 10, 22, '2025-04-16 12:56:45'),
(7, 1, 40, '2025-04-28 13:46:25'),
(7, 2, 21, '2025-04-28 13:22:33'),
(7, 3, 25, '2025-04-16 12:56:45'),
(7, 4, 12, '2025-04-16 12:56:45'),
(7, 5, 25, '2025-04-28 13:45:20'),
(7, 6, 15, '2025-04-16 12:56:45'),
(7, 7, 20, '2025-04-28 13:46:25'),
(7, 8, 44, '2025-04-16 12:56:45'),
(7, 9, 50, '2025-04-28 13:39:00'),
(7, 10, 100, '2025-04-28 13:45:20'),
(8, 1, 12, '2025-04-17 04:53:23'),
(8, 2, 38, '2025-04-17 04:53:23'),
(8, 3, 30, '2025-04-29 04:34:14'),
(8, 4, 45, '2025-04-17 04:53:23'),
(8, 5, 7, '2025-04-17 04:53:23'),
(8, 6, 30, '2025-04-17 04:53:23'),
(8, 7, 35, '2025-04-29 04:34:14'),
(8, 8, 49, '2025-04-17 04:53:23'),
(8, 9, 22, '2025-04-17 04:53:23'),
(8, 10, 41, '2025-04-17 04:53:23'),
(9, 1, 18, '2025-04-17 04:53:23'),
(9, 2, 25, '2025-04-17 04:53:23'),
(9, 3, 3, '2025-04-17 04:53:23'),
(9, 4, 39, '2025-04-17 04:53:23'),
(9, 5, 44, '2025-04-17 04:53:23'),
(9, 6, 6, '2025-04-17 04:53:23'),
(9, 7, 35, '2025-04-17 04:53:23'),
(9, 8, 15, '2025-04-17 04:53:23'),
(9, 9, 23, '2025-04-17 04:53:23'),
(9, 10, 11, '2025-04-17 04:53:23'),
(10, 1, 46, '2025-04-17 04:53:23'),
(10, 2, 10, '2025-04-17 04:53:23'),
(10, 3, 5, '2025-04-17 04:53:23'),
(10, 4, 28, '2025-04-17 04:53:23'),
(10, 5, 50, '2025-04-17 04:53:23'),
(10, 6, 9, '2025-04-17 04:53:23'),
(10, 7, 43, '2025-04-17 04:53:23'),
(10, 8, 20, '2025-04-17 04:53:23'),
(10, 9, 1, '2025-04-17 04:53:23'),
(10, 10, 36, '2025-04-17 04:53:23'),
(11, 1, 335, '2025-04-28 16:50:49'),
(11, 2, 375, '2025-04-29 04:33:45'),
(11, 3, 146, '2025-04-28 16:50:49'),
(11, 4, 3480, '2025-04-29 04:33:45'),
(11, 5, 6546, '2025-04-28 13:39:49'),
(11, 6, 800, '2025-04-29 04:31:53'),
(11, 7, 5006, '2025-04-28 16:33:32'),
(11, 8, 789, '2025-04-28 13:39:51'),
(11, 9, 789, '2025-04-28 13:39:56'),
(11, 10, 461, '2025-04-29 04:31:53'),
(12, 1, 45645, '2025-04-28 13:39:46'),
(12, 2, 387, '2025-04-28 13:39:59'),
(12, 3, 677, '2025-04-28 13:39:44'),
(12, 4, 654, '2025-04-28 13:39:42'),
(12, 5, 215, '2025-04-28 13:39:38'),
(12, 6, 554, '2025-04-28 13:39:40'),
(12, 7, 354, '2025-04-28 13:40:49'),
(12, 8, 305, '2025-04-28 13:39:35'),
(12, 9, 786, '2025-04-28 13:40:05'),
(12, 10, 7896, '2025-04-28 13:40:07'),
(13, 1, 786, '2025-04-28 13:40:09'),
(13, 2, 864, '2025-04-28 13:40:12'),
(13, 3, 500, '2025-04-28 13:39:32'),
(13, 4, 678, '2025-04-28 13:40:15'),
(13, 5, 82, '2025-04-28 13:41:20'),
(13, 6, 304, '2025-04-28 14:11:39'),
(13, 7, 453, '2025-04-28 13:40:44'),
(13, 8, 575, '2025-04-28 13:40:33'),
(13, 9, 645, '2025-04-28 13:40:35'),
(13, 10, 1052, '2025-04-28 13:39:23'),
(14, 1, 797, '2025-04-28 13:40:36'),
(14, 2, 19, '2025-04-17 04:53:23'),
(14, 3, 34, '2025-04-17 04:53:23'),
(14, 4, 384, '2025-04-28 13:40:38'),
(14, 5, 46, '2025-04-17 04:53:23'),
(14, 6, 15, '2025-04-17 04:53:23'),
(14, 7, 340, '2025-04-28 13:49:34'),
(14, 8, 73, '2025-04-24 07:28:39'),
(14, 9, 20, '2025-04-24 07:28:39'),
(14, 10, 18, '2025-04-17 04:53:23'),
(15, 1, 2, '2025-04-28 14:08:45'),
(15, 2, 0, '2025-04-28 16:32:54'),
(15, 3, 40, '2025-04-29 04:30:31'),
(15, 4, 15, '2025-04-29 04:30:31'),
(15, 5, 40, '2025-04-29 04:30:31'),
(15, 6, 0, '2025-04-16 14:11:57'),
(15, 7, 10, '2025-04-28 16:48:27'),
(15, 8, 0, '2025-04-16 14:11:57'),
(15, 9, 0, '2025-04-16 14:11:57'),
(15, 10, 0, '2025-04-16 14:11:57');

-- --------------------------------------------------------

--
-- 資料表結構 `user`
--

CREATE TABLE `user` (
  `userId` int(3) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `fullName` varchar(255) NOT NULL,
  `role` enum('Bakery','Warehouse','SeniorManagement') NOT NULL,
  `city` int(2) DEFAULT NULL,
  `shopId` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- 資料表的匯出資料 `user`
--

INSERT INTO `user` (`userId`, `username`, `password`, `fullName`, `role`, `city`, `shopId`) VALUES
(1, 'alice_tokyo', '123', 'Alice Tanaka', 'Bakery', 1, 1),
(3, 'claire_kyoto', '123', 'Claire Suzuki', 'Bakery', 2, 3),
(4, 'daniel_ny', '123', 'Daniel Johnson', 'Bakery', 2, 4),
(5, 'emily_ny', '123', 'Emily Davis', 'Bakery', 3, 5),
(6, 'frank_hk', '123', 'Frank Wong', 'Bakery', 4, 6),
(7, 'grace_hk', '123', 'Grace Lee', 'Bakery', 4, 7),
(8, 'warehouse_jp', '123', 'Hiroshi Yamamoto', 'Warehouse', 1, 8),
(9, 'warehouse_us', '123', 'John Smith', 'Warehouse', 3, 9),
(10, 'warehouse_hk', '123', 'Angela Chan', 'Warehouse', 4, 10),
(13, 'admin', '123', 'admin Name', 'SeniorManagement', NULL, NULL),
(16, 'test123', 'test', 'test', 'Bakery', 1, 1),
(17, 'soucrehousejp', '123', 'shjp', 'Warehouse', 1, 11),
(20, 'scwarehouse_us', '123', 'scwarehouse_us', 'Warehouse', 3, 13),
(21, 'scwarehouse_hk', '123', 'scwarehouse_hk', 'Warehouse', 4, 14),
(41, 'hello', '123456', 'Helli', 'Bakery', 1, 1);

--
-- 已匯出資料表的索引
--

--
-- 資料表索引 `city`
--
ALTER TABLE `city`
  ADD PRIMARY KEY (`cityId`);

--
-- 資料表索引 `delivery_log`
--
ALTER TABLE `delivery_log`
  ADD PRIMARY KEY (`number`,`fruitId`);

--
-- 資料表索引 `fruit`
--
ALTER TABLE `fruit`
  ADD PRIMARY KEY (`fruitId`,`fruitName`),
  ADD UNIQUE KEY `fruitId` (`fruitId`);

--
-- 資料表索引 `location`
--
ALTER TABLE `location`
  ADD PRIMARY KEY (`locationId`),
  ADD KEY `cityId` (`cityId`);

--
-- 資料表索引 `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`locationId`,`fruitId`,`date`),
  ADD KEY `fruitId` (`fruitId`);

--
-- 資料表索引 `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`locationId`,`fruitId`),
  ADD KEY `fruitId` (`fruitId`);

--
-- 資料表索引 `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`),
  ADD KEY `city` (`city`,`shopId`);

--
-- 在匯出的資料表使用 AUTO_INCREMENT
--

--
-- 使用資料表 AUTO_INCREMENT `city`
--
ALTER TABLE `city`
  MODIFY `cityId` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用資料表 AUTO_INCREMENT `fruit`
--
ALTER TABLE `fruit`
  MODIFY `fruitId` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- 使用資料表 AUTO_INCREMENT `location`
--
ALTER TABLE `location`
  MODIFY `locationId` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- 使用資料表 AUTO_INCREMENT `user`
--
ALTER TABLE `user`
  MODIFY `userId` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- 已匯出資料表的限制(Constraint)
--

--
-- 資料表的 Constraints `location`
--
ALTER TABLE `location`
  ADD CONSTRAINT `location_ibfk_1` FOREIGN KEY (`cityId`) REFERENCES `city` (`cityId`);

--
-- 資料表的 Constraints `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `fruitId` FOREIGN KEY (`fruitId`) REFERENCES `fruit` (`fruitId`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `locationId` FOREIGN KEY (`locationId`) REFERENCES `location` (`locationId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- 資料表的 Constraints `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`locationId`) REFERENCES `location` (`locationId`),
  ADD CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`fruitId`) REFERENCES `fruit` (`fruitId`);

--
-- 資料表的 Constraints `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `city` FOREIGN KEY (`city`,`shopId`) REFERENCES `location` (`cityId`, `locationId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
