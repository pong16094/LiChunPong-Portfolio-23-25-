-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 25, 2024 at 07:34 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
SET GLOBAL general_log = 1;
SET GLOBAL log_output = 'table';

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lmc`
--
CREATE DATABASE IF NOT EXISTS `lmc` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `lmc`;

-- --------------------------------------------------------

--
-- Table structure for table `copy1,4`
--

CREATE TABLE `copy1,4` (
  `OrderNo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `copy1,4`
--

INSERT INTO `copy1,4` (`OrderNo`) VALUES
(40422146),
(70422149),
(90422151);

-- --------------------------------------------------------

--
-- Table structure for table `copy2,3`
--

CREATE TABLE `copy2,3` (
  `OrderNo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `copy2,3`
--

INSERT INTO `copy2,3` (`OrderNo`) VALUES
(40422146),
(70422149),
(90422151);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `Password` varchar(50) NOT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `DeliveryAddress` varchar(255) NOT NULL,
  `ContactName` varchar(100) NOT NULL,
  `ContactNumber` int(15) NOT NULL,
  `InvoiceSetOrderNo` int(20) NOT NULL,
  `CustID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Password`, `Email`, `DeliveryAddress`, `ContactName`, `ContactNumber`, `InvoiceSetOrderNo`, `CustID`) VALUES
('Password1', 'abc1234@gmail.com', '789 Oak Avenue, Los Angeles, CA 90001', 'Wong Yan Yan', 67825567, 103120301, 100),
('Password2', 'abc12345@gmail.com', '215 Elm Road, New York, NY 12345', 'Chan Tai Ｍan', 67896543, 103120302, 200),
('Password123', 'john.doe@example.com', '789 Oak Avenue, Los Angeles, CA 90001', 'John Doe', 62465253, 204050601, 201),
('Qwerty123!', 'david.brown@example.net', '654 Elm Road, Seattle, WA 98101', 'David Brown', 90001111, 901040205, 205),
('MySecret456', 'sarah.davis@example.com', '1178 Maple Lane, Denver, CO 80202', 'Sarah Davis', 23246789, 401090306, 206),
('Abc12345!', 'michael.lee@example.net', '542 Cedar Drive, Atlanta, GA 30301', 'Michael Lee', 34565432, 601080407, 207),
('Passw0rd789', 'olivia.thompson@example.org', '987 Main Street, Portland, OR 97201', 'Olivia Thompson', 62323242, 801070508, 208),
('Xyz456!@#', 'daniel.wilson@example.com', '321 Main Street, Chicago, IL 09876', 'Daniel Wilson', 90887789, 901060609, 209),
('MyPassword12', 'emma.johnson@example.net', '1 Maple Ave, New York, NY 10001', 'Emma Johnson', 96753215, 201050710, 210);

-- --------------------------------------------------------

--
-- Table structure for table `despatch_instruction_cover(dic)`
--

CREATE TABLE `despatch_instruction_cover(dic)` (
  `OrderNo` int(20) NOT NULL,
  `Date` date NOT NULL,
  `DeliveryAddress` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `despatch_instruction_cover(dic)`
--

INSERT INTO `despatch_instruction_cover(dic)` (`OrderNo`, `Date`, `DeliveryAddress`) VALUES
(104221464, '2024-05-20', '\'902 Oak Avenue, Miami, FL 33133'),
(204221465, '2024-05-21', '1178 Maple Lane, Denver, CO 80202'),
(304221466, '2024-05-22', '542 Cedar Drive, Atlanta, GA 30301'),
(404221467, '2024-05-23', '987 Main Street, Portland, OR 97201'),
(504221468, '2024-05-24', '321 Main Street, Chicago, IL 09876'),
(604221469, '2024-05-25', '1 Maple Ave, New York, NY 10001');

-- --------------------------------------------------------

--
-- Table structure for table `despatch_instruction_detail(did)`
--

CREATE TABLE `despatch_instruction_detail(did)` (
  `OrderNo` int(20) NOT NULL,
  `Date` date NOT NULL,
  `DeliveryAddress` varchar(255) NOT NULL,
  `TotalToDespatach` varchar(255) DEFAULT NULL,
  `SalesOfficeDepNO` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `despatch_instruction_detail(did)`
--

INSERT INTO `despatch_instruction_detail(did)` (`OrderNo`, `Date`, `DeliveryAddress`, `TotalToDespatach`, `SalesOfficeDepNO`) VALUES
(104221464, '2024-05-20', '987 Main Street, Portland', NULL, 122111),
(204221465, '2024-05-21', '1178 Maple Lane, Denver, CO 80202', '25', 122112),
(304221466, '2024-05-22', '542 Cedar Drive, Atlanta, GA 30301', '18', 122113),
(404221467, '2024-05-23', '902 Oak Avenue, Miami, FL 33133', '32', 122114),
(504221468, '2024-05-24', '321 Main Street, Chicago, IL 09876', '14', 122115),
(604221469, '2024-05-25', '1 Maple Ave, New York, NY 10001', '28', 122116);

-- --------------------------------------------------------

--
-- Table structure for table `diset`
--

CREATE TABLE `diset` (
  `OrderNo` int(20) NOT NULL,
  `SparesDespatchDepartmentDepNo` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `diset`
--

INSERT INTO `diset` (`OrderNo`, `SparesDespatchDepartmentDepNo`) VALUES
(40422146, 1234567890),
(60422148, 1357902468),
(70422149, 2147483647),
(80422150, 2147483647),
(90422151, 1234098765);

-- --------------------------------------------------------

--
-- Table structure for table `invoiceset`
--

CREATE TABLE `invoiceset` (
  `OrderNo` int(20) NOT NULL,
  `ProductNo` char(10) NOT NULL,
  `InvoiceAddress` varchar(255) NOT NULL,
  `DeliveryAddress` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `QuantityDelivered` int(10) NOT NULL,
  `ProductName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoiceset`
--

INSERT INTO `invoiceset` (`OrderNo`, `ProductNo`, `InvoiceAddress`, `DeliveryAddress`, `Date`, `QuantityDelivered`, `ProductName`) VALUES
(40422146, 'AD24657', '321 Main Street, Chicago, IL 09876', '321 Main Street, Chicago, IL 09876', '2024-05-20', 5, 'Duralast Disc Brake Rotor 54048'),
(50422147, 'BT65432', '876 Oak Avenue, Miami, FL 33133', '876 Oak Avenue, Miami, FL 33133', '2024-05-21', 3, 'Bosch Platinum Spark Plug Set 9666'),
(60422148, 'CX98765', '159 Maple Lane, Denver, CO 80202', '159 Maple Lane, Denver, CO 80202', '2024-05-22', 7, 'Continental ContiTech Serpentine Belt 49372'),
(70422149, 'DY54321', '642 Cedar Drive, Atlanta, GA 30301', '642 Cedar Drive, Atlanta, GA 30301', '2024-05-23', 2, 'Dayco Timing Belt Kit 95784'),
(80422150, 'EW13579', '789 Elm Street, New York, NY 10001', '789 Elm Street, New York, NY 10001', '2024-05-24', 4, 'Wagner QuickStop Brake Pads SX1234'),
(90422151, 'FZ24680', '555 Pine Road, Seattle, WA 98101', '555 Pine Road, Seattle, WA 98101', '2024-05-25', 6, 'Fram Ultra Synthetic Oil Filter PH3614');

-- --------------------------------------------------------

--
-- Table structure for table `invoicing_section`
--

CREATE TABLE `invoicing_section` (
  `OrderNo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoicing_section`
--

INSERT INTO `invoicing_section` (`OrderNo`) VALUES
(40422146),
(50422147),
(60422148),
(70422149),
(90422151);

-- --------------------------------------------------------

--
-- Table structure for table `orderitems1`
--

CREATE TABLE `orderitems1` (
  `OrderItemID` char(7) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `TotalPrice` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `orderitems1`
--

INSERT INTO `orderitems1` (`OrderItemID`, `OrderID`, `ProductName`, `Quantity`, `TotalPrice`) VALUES
('AD24657', 1, 'Duralast Disc Brake Rotor 54048\r\n', 2, '200000.00');

-- --------------------------------------------------------

--
-- Table structure for table `orderitems2`
--

CREATE TABLE `orderitems2` (
  `OrderItemID` char(7) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `TotalPrice` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `orderitems2`
--

INSERT INTO `orderitems2` (`OrderItemID`, `OrderID`, `ProductName`, `Quantity`, `TotalPrice`) VALUES
('BT65432', 2, 'Bosch Platinum Spark Plug Set 9666\r\n', 1, '155555.00'),
('EW13579', 2, 'Wagner QuickStop Brake Pads SX1234', 1, '4222.00');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(10) NOT NULL,
  `CustomerName` varchar(255) NOT NULL,
  `OrderDate` date NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Comment` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderID`, `CustomerName`, `OrderDate`, `Address`, `Comment`) VALUES
(1, 'Pong Chan', '2024-06-03', 'Hong Kong Disneyland', NULL),
(2, 'Ray Tam', '2024-06-03', 'Hong Kong Institute of Vocational Education (Tsing Yi)\r\n', 'Good app');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `ProductNo` char(10) NOT NULL,
  `SparePartsStoreProductNo` varchar(10) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `QtyInStock` decimal(10,0) NOT NULL,
  `StockRecordingPartNo` char(10) NOT NULL,
  `Price` decimal(9,3) NOT NULL,
  `DangerLevel` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ProductNo`, `SparePartsStoreProductNo`, `ProductName`, `QtyInStock`, `StockRecordingPartNo`, `Price`, `DangerLevel`) VALUES
(' ds', '23423500', 'cdscs', '0', '591', '32.000', 21321),
('AD24657', '23423432', 'Duralast Disc Brake Rotor 54048', '200', '523', '100000.000', 50),
('BT65432', '23423431', 'Bosch Platinum Spark Plug Set 9666', '200', '522', '155555.000', 20),
('CX98765', '23423233', 'Continental ContiTech Serpentine Belt 49372', '245', '511', '5222.000', 10),
('DY54321', '23423499', 'Dayco Timing Belt Kit 95784', '200', '524', '153535.000', 5),
('EW13579', '23422525', 'Wagner QuickStop Brake Pads SX1234', '211', '590', '4222.000', 25);

-- --------------------------------------------------------

--
-- Table structure for table `purchase_order`
--

CREATE TABLE `purchase_order` (
  `LMSerialNumber` char(20) NOT NULL,
  `StockID` char(20) NOT NULL,
  `CustomerUserID` int(8) NOT NULL,
  `OrderDate` date NOT NULL,
  `OrderSerial` int(10) NOT NULL,
  `DeliveryAddress` varchar(255) NOT NULL,
  `ProductNo` varchar(100) NOT NULL,
  `OrderQty` int(10) NOT NULL,
  `Price` decimal(9,3) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `OrderNo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `purchase_order`
--

INSERT INTO `purchase_order` (`LMSerialNumber`, `StockID`, `CustomerUserID`, `OrderDate`, `OrderSerial`, `DeliveryAddress`, `ProductNo`, `OrderQty`, `Price`, `Status`, `OrderNo`) VALUES
('Z0000001', '24566', 100, '2024-05-20', 423, '321 Main Street, Chicago, IL 09876', 'AD24657', 2, '200000.000', 'incomplete', 40422146),
('Z0000004', '24569', 200, '2024-05-23', 426, '159 Cedar Drive, Atlanta, GA 30301', 'DY54321', 2, '175000.000', 'complete', 70422149),
('Z0000006', '24571', 105, '2024-05-25', 428, '987 Pine Road, Seattle, WA 98101', 'FZ24680', 6, '180000.000', 'complete', 90422151);

-- --------------------------------------------------------

--
-- Table structure for table `goodreceivednote`
--

CREATE TABLE `goodreceivednote` (
  `grn_No` int(10) NOT NULL,
  `ReceivedBy` varchar(30) NOT NULL,
  `supplierName` varchar(50) NOT NULL,
  `receivedDate` date NOT NULL,
  `itemName` varchar(50) NOT NULL,
  `quantity` int(10) NOT NULL,
  `unit` varchar(10) NOT NULL,
  `state` varchar(10) NOT NULL,
  `remark` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `goodreceivednote`
--

INSERT INTO `goodreceivednote` (`grn_No`, `ReceivedBy`, `supplierName`, `receivedDate`, `itemName`, `quantity`, `unit`, `state`, `remark`) VALUES
(1, 'Ben9999', 'ABC Suppliers', '2023-06-15', 'Duralast Disc Brake Rotor 54048', 10, 'Pieces', 'Good', 'Received items as per specifications.');


-- --------------------------------------------------------

--
-- Table structure for table `reorder`
--

CREATE TABLE `reorder` (
  `orderID` int(10) NOT NULL,
  `StockID` varchar(10) NOT NULL,
  `StockName` varchar(20) NOT NULL,
  `Qty` int(10) NOT NULL,
  `totalPrice` int(10) NOT NULL,
  `address` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `reorder`
--

INSERT INTO `reorder` (`orderID`, `StockID`, `StockName`, `Qty`, `totalPrice`, `address`, `Date`, `status`) VALUES
(1, 'A0001', 'Motor', 2, 4680, 'Hong Kong Institute of Vocational Education (Tsing Yi)', '2024-05-31', 'Delivering'),
(2, 'B0001', 'Assemlies1', 1, 160, 'Kwun Tong District Nanyang Plaza', '2024-06-02', 'Complete'),
(3, 'B0001', 'Assemlies1', 9, 1440, 'Hong Kong Institute of Vocational Education (Tsing Yi)', '2024-06-22', 'Processing');

-- --------------------------------------------------------

--
-- Table structure for table `sales_office`
--

CREATE TABLE `sales_office` (
  `DepNo` int(10) NOT NULL,
  `Address` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sales_office`
--

INSERT INTO `sales_office` (`DepNo`, `Address`) VALUES
(47536342, '159 Cedar Drive, Atlanta, GA 30301'),
(47536343, '321 Main Street, Chicago, IL 09876'),
(47536344, '456 Oak Avenue, Miami, FL 33133'),
(47536345, '789 Maple Lane, Denver, CO 80202'),
(47536346, '987 Pine Road, Seattle, WA 98101'),
(47536347, '321 Elm Street, New York, NY 10001');

-- --------------------------------------------------------

--
-- Table structure for table `shipman`
--

CREATE TABLE `shipman` (
  `OrderNo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shipman`
--

INSERT INTO `shipman` (`OrderNo`) VALUES
(40422146),
(70422149),
(90422151);

-- --------------------------------------------------------

--
-- Table structure for table `spares_despatch_department`
--

CREATE TABLE `spares_despatch_department` (
  `DeptNo` int(10) NOT NULL,
  `DespathchQty` int(10) NOT NULL,
  `ProductNo` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `spares_despatch_department`
--

INSERT INTO `spares_despatch_department` (`DeptNo`, `DespathchQty`, `ProductNo`) VALUES
(47536344, 200, 'AD24657'),
(47536345, 211, 'CX98765'),
(47536346, 155, 'DY54321'),
(47536347, 213, 'EW13579');

-- --------------------------------------------------------

--
-- Table structure for table `spare_parts_store`
--

CREATE TABLE `spare_parts_store` (
  `ProductNo` char(10) NOT NULL,
  `PdQtyInStack` int(10) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `Price` decimal(9,3) NOT NULL,
  `DISetOrderNo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `spare_parts_store`
--

INSERT INTO `spare_parts_store` (`ProductNo`, `PdQtyInStack`, `ProductName`, `Price`, `DISetOrderNo`) VALUES
('AD24657', 1000, 'Duralast Disc Brake Rotor 54048', '100000.000', 523232),
('BT65432', 1000, 'Bosch Platinum Spark Plug Set 9666', '155555.000', 523231),
('CX98765', 1000, 'Continental ContiTech Serpentine Belt 49372', '5222.000', 523230),
('DY54321', 1000, 'Dayco Timing Belt Kit 95784', '153535.000', 523229),
('EW13579', 1000, 'Wagner QuickStop Brake Pads SX1234', '4222.000', 523228);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `StaffID` char(8) NOT NULL,
  `StaffName` varchar(100) NOT NULL,
  `DepName` varchar(255) NOT NULL,
  `DptNo` int(10) NOT NULL,
  `JobTitle` char(50) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `SalesOffDepNo` int(10) DEFAULT NULL,
  `SparesDespatchDepartmentDepNo` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`StaffID`, `StaffName`, `DepName`, `DptNo`, `JobTitle`, `Email`, `SalesOffDepNo`, `SparesDespatchDepartmentDepNo`) VALUES
('20243024', 'Chau Wai Man', 'Purchase Department', 42312344, 'Purchase', 'ChauWaiMan1234@gmail.com', 232425, 1234567890),
('20243025', 'Olivia Lam', 'Sales Department', 32456789, 'Sales Manager', 'OliviaLam5678@gmail.com', 456788, 2147483647),
('20243026', 'Michael Wong', 'IT Department', 98765432, 'IT Support', 'MichaelWong9012@gmail.com', 987654, 987654321),
('20243027', 'Emily Chen', 'Accounting Department', 54321098, 'Accountant', 'EmilyChen3456@gmail.com', 543210, 1234567890),
('20243028', 'Kevin Li', 'Marketing Department', 67890123, 'Marketing Coordinator', 'KevinLi7890@gmail.com', 678901, 123456789),
('20243029', 'Jessica Tan', 'HR Department', 12345678, 'HR Specialist', 'JessicaTan2345@gmail.com', 123456, 2147483647);

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `StockID` varchar(10) NOT NULL,
  `StockName` varchar(20) NOT NULL,
  `StockDangerLevel` int(10) NOT NULL,
  `StockCurrentQty` int(10) NOT NULL,
  `StockSupplier` varchar(20) NOT NULL,
  `StockPrice` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`StockID`, `StockName`, `StockDangerLevel`, `StockCurrentQty`, `StockSupplier`, `StockPrice`) VALUES
('A0001', 'Motor 1', 120, 230, 'supplier A', 2340),
('A0002', 'Motor B', 100, 240, 'Supplier A', 1200),
('A0003', 'Motor 3', 100, 123, 'Supplier A', 500),
('A0004', 'Motor 4', 100, 100, 'Supplier A', 600),
('C0001', 'Light Component', 50, 200, 'Supplier C', 788),
('C0002', 'Light Component', 200, 400, 'Supplier C', 599),
('B0001', 'Assemlies1', 110, 90, 'SupplyB', 160),
('B0002', 'Assemlies1', 160, 130, 'SupplyB', 460);

-- --------------------------------------------------------

--
-- Table structure for table `stockrecord`
--

CREATE TABLE `stockrecord` (
  `ProductNo` char(10) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `ProductName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stockrecord`
--

INSERT INTO `stockrecord` (`ProductNo`, `Quantity`, `ProductName`) VALUES
('AD24657', 1000, 'Duralast Disc Brake Rotor 54048'),
('BT65432', 1000, 'Bosch Platinum Spark Plug Set 9666'),
('CX98765', 1000, 'Continental ContiTech Serpentine Belt 49372\r\n'),
('DY54321', 1000, 'Dayco Timing Belt Kit 95784'),
('EW13579', 1000, 'Wagner QuickStop Brake Pads SX1234');

-- --------------------------------------------------------

--
-- Table structure for table `supply`
--

CREATE TABLE `supply` (
  `Price` decimal(9,3) NOT NULL,
  `ProductName` varchar(255) NOT NULL,
  `ProductNo` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supply`
--

INSERT INTO `supply` (`Price`, `ProductName`, `ProductNo`) VALUES
('5222.000', 'Continental ContiTech Serpentine Belt 49372\r\n', 'CX98765'),
('153535.000', 'Dayco Timing Belt Kit 95784', 'DY54321'),
('4222.000', 'Wagner QuickStop Brake Pads SX1234', 'EW13579');

-- --------------------------------------------------------

--
-- Table structure for table `type a stock`
--

CREATE TABLE `type a stock` (
  `StockID` varchar(10) NOT NULL,
  `StockName` varchar(20) NOT NULL,
  `StockDangerLevel` int(10) NOT NULL,
  `StockCurrentQty` int(20) NOT NULL,
  `StockSupplier` varchar(20) NOT NULL,
  `StockPrice` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `type a stock`
--

INSERT INTO `type a stock` (`StockID`, `StockName`, `StockDangerLevel`, `StockCurrentQty`, `StockSupplier`, `StockPrice`) VALUES
('A0001', 'Motor 1', 120, 230, 'supplier A', 2340),
('A0002', 'Motor B', 100, 240, 'Supplier A', 1200),
('A0003', 'Motor 3', 100, 123, 'Supplier A', 500),
('A0004', 'Motor 4', 100, 100, 'Supplier A', 600);

-- --------------------------------------------------------

--
-- Table structure for table `type b stock`
--

CREATE TABLE `type b stock` (
  `StockID` varchar(10) NOT NULL,
  `StockName` varchar(30) NOT NULL,
  `StockDangerLevel` int(10) NOT NULL,
  `StockCurrentQty` int(10) NOT NULL,
  `StockSupplier` varchar(20) NOT NULL,
  `StockPrice` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `type b stock`
--

INSERT INTO `type b stock` (`StockID`, `StockName`, `StockDangerLevel`, `StockCurrentQty`, `StockSupplier`, `StockPrice`) VALUES
('B0001', 'Assemlies1', 110, 90, 'SupplyB', 160),
('B0002', 'Assemlies1', 160, 130, 'SupplyB', 460),
('B0003', 'Engine Assembly', 255, 500, 'Supplier B2', 899),
('B0004', 'Transmission Assembl', 255, 123, 'Supplier B3', 799),
('B0005', 'Differential Assembly', 240, 213, 'Supplier B3', 699),
('B0006', 'Suspension Assembly', 230, 400, 'Supplier B4', 699),
('B0007', 'Steering Assembly', 300, 341, 'Supplier B3', 599),
('B0008', 'Fuel System Assembly', 300, 211, 'Supplier B4', 599),
('B0009', 'Electrical System Assembly', 255, 250, 'Supplier B3', 699),
('B0010', 'Body Assembly', 255, 125, 'Supplier B4', 1099);

-- --------------------------------------------------------

--
-- Table structure for table `type c stock`
--

CREATE TABLE `type c stock` (
  `StockID` varchar(10) NOT NULL,
  `StockName` varchar(30) NOT NULL,
  `StockDangerLevel` int(10) NOT NULL,
  `StockCurrentQty` int(10) NOT NULL,
  `StockSupplier` varchar(20) NOT NULL,
  `StockPrice` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `type c stock`
--

INSERT INTO `type c stock` (`StockID`, `StockName`, `StockDangerLevel`, `StockCurrentQty`, `StockSupplier`, `StockPrice`) VALUES
('C0001', 'Light Component', 50, 200, 'Supplier C', 788),
('C0002', 'Light Component', 200, 400, 'Supplier C', 599),
('C0003', 'Headlights', 300, 213, 'Supplier C2', 399),
('C0004', 'Taillights', 200, 232, 'Supplier C2', 389),
('C0005', 'Turn Signal Lights', 220, 240, 'Supplier C3', 499),
('C0006', 'Brake Lights', 200, 202, 'Supplier C4', 329),
('C0007', 'Fog Lights', 180, 234, 'Supplier C3', 599),
('C0008', 'Daytime Running', 200, 236, 'Supplier C4', 631);

-- --------------------------------------------------------

--
-- Table structure for table `type d stock`
--

CREATE TABLE `type d stock` (
  `StockID` varchar(10) NOT NULL,
  `StockName` varchar(30) NOT NULL,
  `StockDangerLevel` int(10) NOT NULL,
  `StockCurrentQty` int(10) NOT NULL,
  `StockSupplier` text NOT NULL,
  `StockPrice` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `type d stock`
--

INSERT INTO `type d stock` (`StockID`, `StockName`, `StockDangerLevel`, `StockCurrentQty`, `StockSupplier`, `StockPrice`) VALUES
('D0001', 'Floor Mats', 245, 190, 'Supplier D1', 499),
('D0002', 'Seat Covers', 350, 401, 'Supplier D1', 599),
('D0003', 'Car Covers', 210, 123, 'Supplier D2', 1299),
('D0004', 'Windshield Sunshade', 240, 345, 'Supplier D2', 1099),
('D0005', 'Dashboard Covers', 250, 391, 'Supplier D2', 1299),
('D0006', 'Phone Mounts', 150, 193, 'Supplier D4', 199),
('D0007', 'Cup Holders', 100, 123, 'Supplier D4', 199),
('D0008', 'Car Organizers', 220, 215, 'Supplier D4', 599);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `UserName` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Job` varchar(20) NOT NULL,
  `Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`UserName`, `Password`, `Job`, `Email`) VALUES
('a20240604', 'Abc12345678', 'Admin', 'a10203040@vtc.edu.hk'),
('aaa0625999', 'Ggez111111', 'Admin', 'aaa0625999@vtc.edu.hk'),
('Ben9999', 'Ab10203040', 'SalesManager', 'Ben@vtc.edu.hk'),
('cba246810', 'Abc2323425', 'SalesManager', 'cba246810@vtc.edu.hk'),
('Ken12345', 'Glol112233', 'SalesManager', 'Ken12345@vtc.edu.hk'),
('Ray01203393', 'Gg13142222', 'SalesManager', 'Ray01203393@vtc.edu.hk'),
('Tam2123456', 'ABC123456', 'StockRecordStaff', 'Tam2123456@lmc.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `copy1,4`
--
ALTER TABLE `copy1,4`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `copy2,3`
--
ALTER TABLE `copy2,3`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustID`);

--
-- Indexes for table `despatch_instruction_cover(dic)`
--
ALTER TABLE `despatch_instruction_cover(dic)`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `despatch_instruction_detail(did)`
--
ALTER TABLE `despatch_instruction_detail(did)`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `diset`
--
ALTER TABLE `diset`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `invoiceset`
--
ALTER TABLE `invoiceset`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `invoicing_section`
--
ALTER TABLE `invoicing_section`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `orderitems1`
--
ALTER TABLE `orderitems1`
  ADD PRIMARY KEY (`OrderItemID`);

--
-- Indexes for table `orderitems2`
--
ALTER TABLE `orderitems2`
  ADD PRIMARY KEY (`OrderItemID`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductNo`);

--
-- Indexes for table `purchase_order`
--
ALTER TABLE `purchase_order`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `reorder`
--
ALTER TABLE `reorder`
  ADD PRIMARY KEY (`orderID`);

--
-- Indexes for table `sales_office`
--
ALTER TABLE `sales_office`
  ADD PRIMARY KEY (`DepNo`);

--
-- Indexes for table `shipman`
--
ALTER TABLE `shipman`
  ADD PRIMARY KEY (`OrderNo`);

--
-- Indexes for table `spares_despatch_department`
--
ALTER TABLE `spares_despatch_department`
  ADD PRIMARY KEY (`DeptNo`);

--
-- Indexes for table `spare_parts_store`
--
ALTER TABLE `spare_parts_store`
  ADD PRIMARY KEY (`ProductNo`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

--
-- Indexes for table `stockrecord`
--
ALTER TABLE `stockrecord`
  ADD PRIMARY KEY (`ProductNo`);

--
-- Indexes for table `supply`
--
ALTER TABLE `supply`
  ADD PRIMARY KEY (`ProductNo`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`UserName`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
