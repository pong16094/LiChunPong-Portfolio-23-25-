-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- 主機: 127.0.0.1
-- 產生時間： 2024-12-01 17:19:00
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
-- 資料庫： `itp4506`
--
CREATE DATABASE IF NOT EXISTS `itp4506` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `itp4506`;

-- --------------------------------------------------------

--
-- 資料表結構 `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `order_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `status` enum('Pending','Processing','Completed','Cancelled') DEFAULT 'Pending',
  `total_amount` decimal(10,2) NOT NULL,
  `shipping_address` text NOT NULL,
  `payment_method` varchar(50) DEFAULT NULL,
  `transaction_id` varchar(100) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 資料表的匯出資料 `orders`
--

INSERT INTO `orders` (`order_id`, `user_id`, `order_date`, `status`, `total_amount`, `shipping_address`, `payment_method`, `transaction_id`, `created_at`, `updated_at`) VALUES
(1, 1, '2024-11-27 14:31:59', 'Completed', '185.00', 'Room C346, 20 Tsing Yi Road, Tsing Yi Island, N.T. Hong Kong', NULL, NULL, '2024-11-27 06:31:59', '2024-11-27 13:27:36'),
(2, 1, '2024-11-27 14:33:21', 'Processing', '1660.00', 'Hong Kong Institute of Vocational Education (Haking Wong)', NULL, NULL, '2024-11-27 06:33:21', '2024-11-27 13:27:42'),
(3, 2, '2024-11-27 21:27:22', 'Pending', '57844.00', 'Kowloon Tong, Festival Walk', NULL, NULL, '2024-11-27 13:27:22', '2024-11-27 13:27:22');

-- --------------------------------------------------------

--
-- 資料表結構 `order_items`
--

CREATE TABLE `order_items` (
  `order_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `product_price` decimal(10,2) NOT NULL,
  `quantity` int(11) NOT NULL,
  `subtotal` decimal(10,2) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 資料表的匯出資料 `order_items`
--

INSERT INTO `order_items` (`order_id`, `product_id`, `product_name`, `product_price`, `quantity`, `subtotal`, `created_at`, `updated_at`) VALUES
(1, 7, 'Sipping Glasses', '50.00', 1, '50.00', '2024-11-27 06:31:59', '2024-11-27 13:29:11'),
(1, 8, 'Wireless Portable Charger', '95.00', 1, '95.00', '2024-11-27 06:31:59', '2024-11-27 13:29:14'),
(1, 9, 'Dream Tomica hololive', '20.00', 2, '40.00', '2024-11-27 06:31:59', '2024-11-27 13:29:16'),
(2, 6, 'Mini Teslas-Cybertruck for Kids', '1500.00', 1, '1500.00', '2024-11-27 06:33:21', '2024-11-27 13:29:18'),
(2, 9, 'Dream Tomica hololive', '20.00', 3, '60.00', '2024-11-27 06:33:21', '2024-11-27 13:29:20'),
(2, 10, 'Dog Mode', '50.00', 2, '100.00', '2024-11-27 06:33:21', '2024-11-27 13:29:22'),
(3, 3, 'Model X', '57414.00', 1, '57414.00', '2024-11-27 13:27:22', '2024-11-27 13:27:22'),
(3, 7, 'Sipping Glasses', '50.00', 3, '150.00', '2024-11-27 13:27:22', '2024-11-27 13:27:22'),
(3, 8, 'Wireless Portable Charger', '95.00', 2, '190.00', '2024-11-27 13:27:22', '2024-11-27 13:27:22'),
(3, 9, 'Dream Tomica hololive', '20.00', 2, '40.00', '2024-11-27 13:27:22', '2024-11-27 13:27:22'),
(3, 10, 'Dog Mode', '50.00', 1, '50.00', '2024-11-27 13:27:22', '2024-11-27 13:27:22');

-- --------------------------------------------------------

--
-- 資料表結構 `products`
--

CREATE TABLE `products` (
  `product_id` int(11) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `product_price` decimal(10,2) NOT NULL,
  `product_image` varchar(255) DEFAULT NULL,
  `product_description` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 資料表的匯出資料 `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `product_price`, `product_image`, `product_description`) VALUES
(1, 'Model S', '68490.00', 'Mega-Menu-Vehicles-Model-S.avif', NULL),
(2, 'Model 3', '89164.00', 'Mega-Menu-Vehicles-Model-3-Performance-LHD.avif', NULL),
(3, 'Model X', '57414.00', 'Mega-Menu-Vehicles-Model-X.avif', NULL),
(4, 'Model Y', '43252.00', 'Mega-Menu-Vehicles-Model-Y.avif', NULL),
(5, 'Cybertruck', '100000.00', 'Mega-Menu-Vehicles-Cybertruck-1x.avif', NULL),
(6, 'Mini Teslas-Cybertruck for Kids', '1500.00', '1985666-00-A-2-03.avif', 'Now available (for kids) on Earth. Our all-electric, Cybertruck for Kids four-wheel ride-on toy is inspired by our iconic Cybertruck design and features an adjustable seat, rear-wheel drive and electric braking and LED head lights and tail lights.'),
(7, 'Sipping Glasses', '50.00', '1581744-00-A_0_2000.avif', 'Savor your favorite liquor with a limited edition set of Tesla Sipping Glasses. Inspired by Tesla Tequila’s unique silhouette, each glass is designed with angular contours and an engraved Tesla logo.'),
(8, 'Wireless Portable Charger', '95.00', '2048596-00-A-1-01.avif', 'Keep your devices charged everywhere you go. Our redesigned Wireless Portable Charger allows you to simultaneously charge up to two QI-enabled devices including phones and earbuds.'),
(9, 'Dream Tomica hololive', '20.00', 'sg-11134201-7rdw3-m0wo6wr51hzb00.jpg', 'Tokoyami Towa, Japanese Virtual YouTuber'),
(10, 'Dog Mode', '50.00', '1975943-00-A-01.avif', 'Dog Mode, IRL. Our Dog Mode figure is inspired by the Dog Mode cartoon used in our vehicles’ climate control features.');

-- --------------------------------------------------------

--
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `staff_id` int(6) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phone` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 資料表的匯出資料 `staff`
--

INSERT INTO `staff` (`staff_id`, `name`, `email`, `phone`) VALUES
(100001, 'John Doe', 'johndoe@example.com', '12345678'),
(100002, 'Jane Smith', 'janesmith@example.com', '09876543'),
(100003, 'Michael Johnson', 'michaeljohnson@example.com', '23456789'),
(100004, 'Emily Davis', 'emilydavis@example.com', '34567890'),
(100005, 'Alice Johnson', 'alicejohnson@example.com', '12312312'),
(100006, 'David Wilson', 'davidwilson@example.com', '23423423'),
(100007, 'Laura Taylor', 'laurataylor@example.com', '34534534');

-- --------------------------------------------------------

--
-- 資料表結構 `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `role` enum('customer','vehicle_sales_personnel','insurance_sales_personnel') NOT NULL,
  `staff_id` int(6) DEFAULT NULL,
  `status` enum('processing','approved') DEFAULT NULL,
  `reset_password_token` varchar(255) DEFAULT NULL,
  `reset_password_expires` datetime DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 資料表的匯出資料 `users`
--

INSERT INTO `users` (`user_id`, `name`, `email`, `password`, `phone`, `role`, `staff_id`, `status`, `reset_password_token`, `reset_password_expires`, `created_at`, `updated_at`) VALUES
(1, 'Alice Brown', 'alicebrown@example.com', 'hashedpassword1', '45678901', 'customer', NULL, NULL, '3e490fbee82af79ef1010d2fc8363413a399172a', '0000-00-00 00:00:00', '2024-10-31 15:21:52', '2024-10-31 15:24:19'),
(2, 'Robert White', 'robertwhite@example.com', 'hashedpassword2', '56789012', 'customer', NULL, NULL, NULL, NULL, '2024-10-31 15:21:52', '2024-10-31 15:21:52'),
(3, 'John Doe', 'johndoe@example.com', 'hashedpassword3', '12345678', 'vehicle_sales_personnel', 100001, NULL, NULL, NULL, '2024-10-31 15:21:52', '2024-10-31 15:21:52'),
(4, 'Jane Smith', '230010905@stu.vtc.edu.hk', '12345678', '09876543', 'insurance_sales_personnel', 100002, 'processing', 'a35413a6f91afcb5410f14a8b19c8c19bbc4ef51', '2024-11-01 16:45:36', '2024-10-31 15:21:52', '2024-11-27 13:28:19'),
(5, 'Jane Wilson', 'gordon16094@gmail.com', 'hashedpassword4', '09809809', 'insurance_sales_personnel', 100006, 'approved', 'e8299e7e9e061864133b1f38868f1ebbc4ba6837', '2024-11-01 06:27:47', '2024-10-31 15:21:52', '2024-11-01 05:27:47'),
(6, 'Laura Taylor', 'legendmotorlimited4506@gmail.com', 'hashedpassword5', '67867867', 'insurance_sales_personnel', 100007, 'processing', '7c6ffb778a65273f22b11329e5b6d4b8003d37e2', '2024-11-01 06:25:14', '2024-10-31 15:21:52', '2024-11-01 05:25:14');

--
-- 已匯出資料表的索引
--

--
-- 資料表索引 `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- 資料表索引 `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`order_id`,`product_id`);

--
-- 資料表索引 `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- 資料表索引 `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- 在匯出的資料表使用 AUTO_INCREMENT
--

--
-- 使用資料表 AUTO_INCREMENT `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- 使用資料表 AUTO_INCREMENT `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- 使用資料表 AUTO_INCREMENT `staff`
--
ALTER TABLE `staff`
  MODIFY `staff_id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100008;

--
-- 使用資料表 AUTO_INCREMENT `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- 已匯出資料表的限制(Constraint)
--

--
-- 資料表的 Constraints `order_items`
--
ALTER TABLE `order_items`
  ADD CONSTRAINT `fk_order` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
