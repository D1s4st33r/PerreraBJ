-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-08-2017 a las 03:28:44
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `perrera`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `adopcion`
--

CREATE TABLE `adopcion` (
  `ID` int(11) NOT NULL,
  `IDDUENIO` int(11) NOT NULL,
  `DUENIO` varchar(30) NOT NULL,
  `IDMASCOTA` int(11) NOT NULL,
  `MASCOTA` varchar(30) NOT NULL,
  `FREGISTRO` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `adopcion`
--

INSERT INTO `adopcion` (`ID`, `IDDUENIO`, `DUENIO`, `IDMASCOTA`, `MASCOTA`, `FREGISTRO`) VALUES
(1, 10002, 'Luis', 8, 'Jhon wick', '31/07/2017'),
(2, 10001, 'Salvador', 4, 'Felix', '31/07/2017');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ciudades`
--

CREATE TABLE `ciudades` (
  `ID` int(11) NOT NULL,
  `NOMBRE` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ciudades`
--

INSERT INTO `ciudades` (`ID`, `NOMBRE`) VALUES
(1, 'Cancun'),
(2, 'Alfredo V. Bonfil'),
(3, 'Puerto Morelos'),
(4, 'Leona Vicario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_relacion`
--

CREATE TABLE `detalle_relacion` (
  `ID` int(11) NOT NULL,
  `IDDUENIO` int(11) NOT NULL,
  `IDMASCOTA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_relacion`
--

INSERT INTO `detalle_relacion` (`ID`, `IDDUENIO`, `IDMASCOTA`) VALUES
(1, 10004, 3),
(2, 10006, 7),
(3, 10002, 8),
(4, 10001, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_vacuna_gatos`
--

CREATE TABLE `detalle_vacuna_gatos` (
  `IDGATO` int(11) NOT NULL,
  `NOMBRE` varchar(30) NOT NULL,
  `LEUCEMIA` varchar(15) NOT NULL,
  `TRIPLE` varchar(15) NOT NULL,
  `LEUCEMIA2` varchar(15) NOT NULL,
  `TRIPLE2` varchar(15) NOT NULL,
  `PIF` varchar(15) NOT NULL,
  `RABIA` varchar(15) NOT NULL,
  `PIF2` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_vacuna_perros`
--

CREATE TABLE `detalle_vacuna_perros` (
  `IDPERRO` int(11) NOT NULL,
  `NOMBRE` varchar(30) NOT NULL,
  `PARVO` varchar(15) NOT NULL,
  `PARVOCORONA` varchar(15) NOT NULL,
  `TRIPLE` varchar(15) NOT NULL,
  `QUINTUPLE` varchar(15) NOT NULL,
  `SEXTUPLE` varchar(15) NOT NULL,
  `RABIA` varchar(15) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `detalle_vacuna_perros`
--

INSERT INTO `detalle_vacuna_perros` (`IDPERRO`, `NOMBRE`, `PARVO`, `PARVOCORONA`, `TRIPLE`, `QUINTUPLE`, `SEXTUPLE`, `RABIA`, `ID`) VALUES
(3, 'Ponky', '07/06/2011', '', '', '', '', '', 1),
(1, 'Sam', '15/06/2011', '', '', '', '', '', 2),
(2, 'Kimba', '', '', '', '', '', '', 3),
(7, 'Pirata', '11/02/2015', '25/08/2015', '15/10/2015', '16/06/2015', '17/06/2015', '19/11/2015', 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `duenio`
--

CREATE TABLE `duenio` (
  `IDDUENIO` bigint(20) NOT NULL,
  `NOMBRE` varchar(20) NOT NULL,
  `APATERNO` varchar(20) NOT NULL,
  `AMATERNO` varchar(20) NOT NULL,
  `GENERO` varchar(15) NOT NULL,
  `FNACIMIENTO` varchar(15) NOT NULL,
  `DIRECCION` longtext NOT NULL,
  `TELEFONO` bigint(10) NOT NULL,
  `FREGISTRO` varchar(20) NOT NULL,
  `ESTATUS` varchar(15) NOT NULL,
  `ADOPTO` tinyint(1) NOT NULL,
  `COMPLETO` longtext NOT NULL,
  `ID` int(11) NOT NULL,
  `CIUDAD` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `duenio`
--

INSERT INTO `duenio` (`IDDUENIO`, `NOMBRE`, `APATERNO`, `AMATERNO`, `GENERO`, `FNACIMIENTO`, `DIRECCION`, `TELEFONO`, `FREGISTRO`, `ESTATUS`, `ADOPTO`, `COMPLETO`, `ID`, `CIUDAD`) VALUES
(10001, 'Salvador', 'Miron ', 'Ramos', 'Masculino', '19/04/1998', 'SM.222 M.4 L.2 N.2', 9983293376, '21/07/2017', 'Activo', 0, 'Salvador Miron  Ramos :10001', 1, ''),
(10002, 'Luis', 'Gamas', 'Ortiz', 'Masculino', '24/12/1997', 'Quien sabe', 4826464266, '21/07/2017', 'Activo', 0, 'Luis Gamas Ortiz :10002', 2, ''),
(10003, 'Isaac', 'Sanchez', 'Montiel', 'Masculino', '13/07/1995', 'Yo que se', 6546464651, '21/07/2017', 'Activo', 0, 'Isaac Sanchez Montiel :10003', 3, ''),
(10004, 'Bart', 'Miron', 'Carrera', 'Masculino', '29/07/1970', 'la misma que yo', 9982280544, '21/07/2017', 'Activo', 0, 'Bart Miron Carrera :10004', 4, ''),
(10005, 'Viry', 'tygtygyt', 'tghygyg', 'Femenino', '07/06/2004', 'kgnhbhbhbh', 8424524894, '21/07/2017', 'Activo', 0, 'Viry tygtygyt tghygyg :10005', 5, ''),
(10006, 'Alexander', 'Herrera', 'Mendez', 'Femenino', '29/12/1993', 'Reg. 103 m.59 l.23', 9983959248, '31/07/2017', 'Activo', 0, 'Alexander Herrera Mendez :10006', 6, 'Cancun');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mascotas`
--

CREATE TABLE `mascotas` (
  `ID` int(11) NOT NULL,
  `TIPO` varchar(15) NOT NULL,
  `NOMBRE` varchar(30) NOT NULL,
  `SEXO` varchar(15) NOT NULL,
  `EDAD` text NOT NULL,
  `RAZA` varchar(30) NOT NULL,
  `RAZGOS` text NOT NULL,
  `IDVACUNA` int(11) NOT NULL,
  `DUENIO` varchar(40) NOT NULL,
  `FREGISTRO` varchar(11) NOT NULL,
  `COMPLETO` varchar(70) NOT NULL,
  `ESTATUS` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mascotas`
--

INSERT INTO `mascotas` (`ID`, `TIPO`, `NOMBRE`, `SEXO`, `EDAD`, `RAZA`, `RAZGOS`, `IDVACUNA`, `DUENIO`, `FREGISTRO`, `COMPLETO`, `ESTATUS`) VALUES
(1, 'Perro', 'Sam', 'Hembra', '2 Años', 'Labrador retriever', 'Esta gorda', 0, 'Salvador Miron  Ramos :10001', '29/07/2017', '1 : Sam | Salvador Miron  Ramos :10001', 'Mascota'),
(2, 'Perro', 'Kimba', 'Hembra', '7 año(s)', '', 'Gorda', 0, 'Isaac Sanchez Montiel :10003', '29/07/2017', '2 : Kimba | Isaac Sanchez Montiel :10003', 'Mascota'),
(3, 'Perro', 'Ponky', 'Macho', '7 año(s)', 'Pug', 'esta muy gordo', 0, 'Bart Miron Carrera :10004', '30/07/2017', '3 : Ponky | Bart Miron Carrera :10004', 'Mascota'),
(4, 'Gato', 'Felix', 'Hembra', '7 meses', 'Siames', 'pelaje gris con manchas blancas', 0, 'Salvador Miron  Ramos :10001', '31/07/2017', '4 : Felix | Salvador Miron  Ramos :10001', 'Adoptado'),
(5, 'Perro', '', 'Hembra', '7 meses', 'Husky siberiano', 'pelaje muy gris', 0, '', '31/07/2017', '', 'Rescatado'),
(6, 'Gato', '', 'Macho', 'System.Windows.Forms.TextBox, Te', 'Siames', 'Un ojo verde y uno negro', 0, '', '31/07/2017', '', 'Rescatado'),
(7, 'Perro', 'Pirata', 'Macho', '3 Años', 'Pit bull', 'Orejas cortadas y un ojo parchado', 0, 'Alexander Herrera Mendez :10006', '31/07/2017', '7 : Pirata | Alexander Herrera Mendez :10006', 'Mascota'),
(8, 'Perro', 'Jhon wick', 'Macho', '6 Semanas', 'Pit bull', 'Mamado', 0, 'Luis Gamas Ortiz :10002', '31/07/2017', '8 : Jhon wick | Luis Gamas Ortiz :10002', 'Adoptado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `razas`
--

CREATE TABLE `razas` (
  `ID` int(11) NOT NULL,
  `NOMBRE` varchar(30) NOT NULL,
  `NACIONALIDAD` varchar(30) NOT NULL,
  `ANIMAL` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `razas`
--

INSERT INTO `razas` (`ID`, `NOMBRE`, `NACIONALIDAD`, `ANIMAL`) VALUES
(1, 'Desconocido', 'Desconocido', 'Perro'),
(2, 'Desconocido', 'Desconocido', 'Gato'),
(3, 'Siames', 'Tailandia', 'Gato'),
(4, 'Husky siberiano', 'Siberia', 'Perro'),
(5, 'Labrador retriever', 'Isla de Terranova', 'Perro'),
(6, 'Pit bull', 'Yucateco', 'Perro');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rescate`
--

CREATE TABLE `rescate` (
  `ID` int(11) NOT NULL,
  `ANIMAL` varchar(15) NOT NULL,
  `EDAD` text NOT NULL,
  `RAZA` varchar(20) NOT NULL,
  `SEXO` varchar(11) NOT NULL,
  `CARACTE` text NOT NULL,
  `CONDICIONES` text NOT NULL,
  `LHALLAZGO` text NOT NULL,
  `FREGISTRO` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `rescate`
--

INSERT INTO `rescate` (`ID`, `ANIMAL`, `EDAD`, `RAZA`, `SEXO`, `CARACTE`, `CONDICIONES`, `LHALLAZGO`, `FREGISTRO`) VALUES
(1, 'Perro', '', 'Desconocido', 'Macho', 'Un ojo cafe, el otro blanco', 'Pata delantera izquierda esta rota', 'Parque del hippie, Palapas', '31/07/2017'),
(2, 'Perro', 'System.Windows.', 'Husky siberiano', 'Hembra', 'pelaje muy gris', 'deshidratado', 'Paseos kabah, cancun', '31/07/2017'),
(3, 'Gato', 'System.Windows.Forms.TextBox, ', 'Siames', 'Macho', 'Un ojo verde y uno negro', 'una pata rota', 'universidad politecnica', '31/07/2017'),
(4, 'Perro', '6  Semanas', 'Pit bull', 'Macho', 'Mamado', 'Deshidratado', 'Plaza mall', '31/07/2017');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vacunas`
--

CREATE TABLE `vacunas` (
  `IDVACUNA` int(11) NOT NULL,
  `NOMBRE` varchar(20) NOT NULL,
  `INMUNIDAD` varchar(50) NOT NULL,
  `EDADA` varchar(20) NOT NULL,
  `MASCOTA` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vacunas`
--

INSERT INTO `vacunas` (`IDVACUNA`, `NOMBRE`, `INMUNIDAD`, `EDADA`, `MASCOTA`) VALUES
(1, 'Parvo', 'Parvovirus Canino', '6 Semanas', 'PERRO'),
(2, 'Parvo/Corona', 'Parvovirus,Moquillo Canino y Coronavirus', '8 Semanas', 'PERRO'),
(3, 'Triple', 'Hepatitis, pervo refuerzo, corona refuerzo', '10 Semanas', 'PERRO'),
(4, 'Quintuple', 'Parvovirus Canino, Distemper,Hepatitis', '12 Semanas', 'PERRO'),
(5, 'Sextuple', 'Parvovirus,Moquillo Canino y Coronavirus,Hepatitis', '14 Semanas', 'PERRO'),
(6, 'Rabia', 'Rabia', '16 Semanas', 'PERRO'),
(9, 'Leucemia', 'Virus leucemia', '8 Semanas', 'Gato'),
(10, 'Triple virica 1', 'Calicivirus, Rinotraqueoisis', '12 Semanas', 'Gato'),
(11, 'Leucemia 2', 'Virus leucemia', '14 Semanas', 'Gato'),
(12, 'Triple virica 2', 'Calicivirus, Ranotraqueosis', '16 Semanas', 'Gato'),
(13, 'PIF', 'Peritonitis infecciosa felina', '18 Semanas', 'Gato'),
(14, 'Antirrabica', 'Rabia', '20 Semanas', 'Gato'),
(15, 'PIF 2', 'Peritonitis infecciosa felina', '22 Semanas', 'Gato');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `adopcion`
--
ALTER TABLE `adopcion`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `detalle_relacion`
--
ALTER TABLE `detalle_relacion`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `detalle_vacuna_perros`
--
ALTER TABLE `detalle_vacuna_perros`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `duenio`
--
ALTER TABLE `duenio`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `mascotas`
--
ALTER TABLE `mascotas`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `razas`
--
ALTER TABLE `razas`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `rescate`
--
ALTER TABLE `rescate`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `vacunas`
--
ALTER TABLE `vacunas`
  ADD PRIMARY KEY (`IDVACUNA`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `adopcion`
--
ALTER TABLE `adopcion`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `ciudades`
--
ALTER TABLE `ciudades`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `detalle_relacion`
--
ALTER TABLE `detalle_relacion`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `detalle_vacuna_perros`
--
ALTER TABLE `detalle_vacuna_perros`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `duenio`
--
ALTER TABLE `duenio`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `mascotas`
--
ALTER TABLE `mascotas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `razas`
--
ALTER TABLE `razas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `rescate`
--
ALTER TABLE `rescate`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `vacunas`
--
ALTER TABLE `vacunas`
  MODIFY `IDVACUNA` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
