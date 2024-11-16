-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 17, 2024 at 02:07 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proyecto`
--

CREATE DATABASE IF NOT EXISTS proyecto;
USE proyecto;

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usuario` VARCHAR(20), IN `Clave` VARCHAR(15))   BEGIN
    SELECT nombre_usuario
    FROM usuarios
    WHERE nombre_usuario = Usuario
    AND clave_usuario = Clave;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

CREATE TABLE `clientes` (
  `Id` int(11) NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Apellido` varchar(50) DEFAULT NULL,
  `DNI` varchar(20) DEFAULT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Mail` varchar(50) DEFAULT NULL,
  `Telefono` varchar(15) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `Tipo` enum('socio','no-socio') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clientes`
--

INSERT INTO `clientes` (`Id`, `Nombre`, `Apellido`, `DNI`, `Direccion`, `Mail`, `Telefono`, `FechaNacimiento`, `Tipo`) VALUES
(1, 'Elon', 'Musk', '314856985', 'Calle Tesla 123', 'mail@x.com', '0800-666-123', '1971-10-28', 'socio');
(2, 'Donald', 'Trump', '123456', 'White House', 'maga@usa.com', '555-842-896', '1946-11-14', 'socio');
(3, 'Nayib', 'Bukele', '654321', 'Pasaje Salvatrucha 6', 'bitcoin@prision.com', '1239-87555', '1981-12-24', 'no-socio');
-- --------------------------------------------------------

--
-- Table structure for table `pagos`
--

CREATE TABLE `pagos` (
  `ID` int(11) NOT NULL,
  `DNICliente` varchar(20) DEFAULT NULL,
  `Valor` decimal(10,2) DEFAULT NULL,
  `Referencia` varchar(20) DEFAULT NULL,
  `FechaPago` date DEFAULT NULL,
  `VencimientoPago` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pagos`
--

INSERT INTO `pagos` (`ID`, `DNICliente`, `Valor`, `Referencia`, `FechaPago`, `VencimientoPago`) VALUES
(1, '314856985', 1000.00, 'Cuota Socio', '2024-11-13', '2024-12-13'),
(2, '123456', 1000.00, 'Cuota Socio', '2024-10-18', '2024-11-18'),
(3, '654321', 400.00, 'Futbol', '2024-11-14', '2024-12-14'),
(4, '654321', 600.00, 'Natacion', '2024-11-14', '2024-12-14'),
-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nombre_usuario` varchar(20) DEFAULT NULL,
  `clave_usuario` varchar(15) DEFAULT NULL,
  `activo` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nombre_usuario`, `clave_usuario`, `activo`) VALUES
(1, 'Admin', 'admin', 1),
(3, 'Lean', '11', 1),
(6, 'Martin', 'grupo14', 1),
(7, 'Silvia', '1234', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `DNI` (`DNI`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`id_rol`) REFERENCES `roles` (`id_rol`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
