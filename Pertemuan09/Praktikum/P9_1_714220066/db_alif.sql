-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 06, 2023 at 09:07 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_alif`
--

-- --------------------------------------------------------

--
-- Table structure for table `p10`
--

CREATE TABLE `p10` (
  `npm` int(11) NOT NULL,
  `nama` varchar(120) NOT NULL,
  `angkatan` int(11) NOT NULL,
  `alamat` varchar(250) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nohp` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `p10`
--

INSERT INTO `p10` (`npm`, `nama`, `angkatan`, `alamat`, `email`, `nohp`) VALUES
(122131, 'ABJVD', 2022, 'BANDUNg', 'me@herobuxx,me', '081264623453'),
(1121, 'JHGHVXVGDHJ', 2022, 'PADANG', 'me@herobuxx,me', '081264623453'),
(1213, 'saxsda', 2022, 'xdxsd', 'me@herobuxx,me', '23344');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
