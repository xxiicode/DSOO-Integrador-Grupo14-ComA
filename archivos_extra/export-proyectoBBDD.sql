-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2024 at 12:31 PM
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

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ExisteDNI` (IN `dni` VARCHAR(20), OUT `existe` INT)   BEGIN
    SELECT COUNT(*) INTO existe FROM Clientes WHERE DNI = dni;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usuario` VARCHAR(20), IN `Clave` VARCHAR(15))   BEGIN
    SELECT nombre_usuario
    FROM usuarios
    WHERE nombre_usuario = Usuario
    AND clave_usuario = Clave;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarCliente` (IN `nombre` VARCHAR(50), IN `apellido` VARCHAR(50), IN `dni` VARCHAR(20), IN `direccion` VARCHAR(100), IN `mail` VARCHAR(100), IN `telefono` VARCHAR(20), IN `fechaNacimiento` DATE, IN `tipo` VARCHAR(20))   BEGIN
    INSERT INTO Clientes (Nombre, Apellido, DNI, Direccion, Mail, Telefono, FechaNacimiento, Tipo)
    VALUES (nombre, apellido, dni, direccion, mail, telefono, fechaNacimiento, tipo);
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
(1, 'Jose', 'Perez', '123456', 'Calle Falsa 123', 'mail@google.com', '44523456', '1994-10-19', 'socio'),
(2, 'Jose Arcadio', 'Buendia', '31558475', 'Calle otra 222', 'mail2@google.com', '5544485', '2004-09-15', 'no-socio');

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
(5, 'Lean', '11', 1),
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
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
