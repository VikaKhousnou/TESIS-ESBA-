-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 15-09-2024 a las 00:38:31
-- Versión del servidor: 8.3.0
-- Versión de PHP: 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `login`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `ID` int NOT NULL,
  `DNI` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_spanish_ci DEFAULT NULL,
  `NOMBREUSUARIO` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_spanish_ci DEFAULT NULL,
  `fk_rol` int DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_USUARIO_fk_rol` (`fk_rol`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_spanish_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`ID`, `DNI`, `NOMBREUSUARIO`, `fk_rol`) VALUES
(1, '25896341', 'Juan Pablo', 1),
(2, '123', 'Aldana', 2),
(10, '34625736', 'Domínguez Clara', 2),
(3, '123', 'Yamila', 4),
(5, '123', 'Mariano', 3),
(6, '123', 'Rodrigo', 5),
(4, '67584920', 'Gómez Armando', 5),
(9, '34625776', 'Garcia Ernaldo', 4),
(11, '34626736', 'Domínguez Clara', 2),
(12, '37652554', 'Romero Hugo', 3),
(7, '78534561', 'Romano Zulma', 2),
(8, '32198765', 'Gordillo Javier', 5),
(13, '77712345', 'Beltrán Débora', 2),
(14, '87998761', 'Benítez Maximiliano', 4),
(15, '12349876', 'Heredia Pedro', 4),//
(16, '54321234\r\n', 'Bravo Roberto', 5),
(17, '43213456', 'Delgado Silvia', 3),
(18, '65476543\r\n', 'Ortega Anibal', 1),
(19, '90872134', 'Perez Adriana', 2),
(20, '21134567\r\n', 'Ortiz Liliana', 3),
(21, '76564321', 'Muñiz Soledad', 2),
(22, '78923456\r\n', 'Gutierrez Edith', 5),
(23, '98712876', 'Rios Lucía', 3),
(24, '76541234', 'Ferrari Daniela \r\n', 5),//
(25, '23456787', 'Ibañez Sergio', 4),
(26, '8563457', 'Herrero Juan', 4),
(27, '88812345', 'Escalante Maria', 2),
(28, '12121111', 'Reynoso Hilda', 3),
(29, '98765421\r\n', 'Campos Jaime', 3),
(30, '34567889', 'Muñoz Estela', 2),
(31, '67678676\r\n', 'Garcia Carina', 5),
(32, '78934675', 'Rodríguez Diana', 5),
(33, '12348909', 'Garrido Margarita', 3),
(34, '23456786\r\n', 'Cardoso Lorena', 4),//
(35, '98723456', 'Gandolfo Isabel', 4),
(36, '90782345\r\n', 'Arevalo Andrea', 3),
(37, '34566789\r\n', 'Bonelli Carolina', 2),
(38, '65476219', 'Sequeira Zulema', 2),
(39, '89712345\r\n', 'Estevez Rodolfo', 4),
(40, '56783451', 'Navarro Melisa', 3),
(41, '89012312', 'Galvan Blanca', 4),
(42, '12345432\r\n', 'Suarez Fabio', 4),
(43, '76543423', 'Iriarte Mariela', 2),
(44, '23123456\r\n', 'Alonso Anabel', 5),//
(45, '76543234', 'Martinez Raquel', 2),
(46, '43217890\r\n', 'Peña Gisela', 3),
(47, '87654321', 'Lobos Daniel', 4),
(48, '12345678\r\n', 'Torres Alfredo', 5),
(49, '78654321\r\n', 'Aguirre Horacio', 4),
(50, '43212345', 'Montes Alicia', 2),
(51, '65432234\r\n', 'Guevara Enrique', 3),
(52, '98761123', 'Rivarola Celia', 4),
(53, '12342178\r\n', 'Costas Valentin', 4),//
(54, '98761234', 'Arias Marcelo', 5),
(55, '56783457\r\n', 'Vega Ernesto', 3),
(56, '12345678', 'Soria Martin', 2),
(57, '98761234\r\n', 'Barrios Valentin', 4),
(58, '12342321', 'Funes Anibal', 2),
(59, '65432234\r\n', 'Zamudio Hector', 3),
(60, '34567891', 'Cabrera Cintia', 3),
(61, '56783457\r\n', 'Montes Ricardo', 3),
(62, '45678901', 'Galindez Graciela', 3),
(63, '65432123\r\n', 'Ortega Andres', 3),//
(64, '87654321 ', ' Quiroga Rosa', 3),
(65, '43212345\r\n', 'Campos Luciano', 3),
(66, '65432123', 'Castillo Monica', 3),
(67, '78761234\r\n', 'Rey Bernardo', 3),
(68, '76543234', 'Escalante Lidia', 3),
(69, '56783491\r\n', 'Nuñez Roque', 3),
(70, '78761978', 'Herrero Elida;', 3),
(71, '12345678', 'Lobos Analía ', 3),
(72, '87612343\r\n', 'Beltran Rafael', 3),
(73, '78761234\r\n', 'Funes Damian', 3),
(74, '43212345', 'Garcia Alejandra', 3),//
(75, '65432123\r\n', 'Correa Mario ', 3),
(76, '23456786', 'Romero Susana ', 4),
(77, '78934678\r\n', 'Zarate Gerardo', 5),
(78, '34567890', 'Reynoso Ester', 5),
(79, '23456786', 'Rios Mariano', 1),
(80, '78761234', 'Sequeira Leonardo ', 2);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
