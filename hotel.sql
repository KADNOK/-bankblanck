SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


CREATE DATABASE IF NOT EXISTS `hotel` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `hotel`;

CREATE TABLE `Account` (
  `Account codeId` int NOT NULL,
  `habitation` int NOT NULL,
  `the amount` double NOT NULL,
  `of the detail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Client` (
  `ClientsId` int NOT NULL,
  `name` varchar(50) NOT NULL,
  `passport details` varchar(50) NOT NULL,
  `contact information` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Habitation` (
  `AccommodationId` int NOT NULL,
  `client` int NOT NULL,
  `check-in date` date NOT NULL,
  `check-out date` date NOT NULL,
  `room tupe` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Number` (
  `The code numberId` int NOT NULL,
  `type` int NOT NULL,
  `of cost` double NOT NULL,
  `available` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Registration card` (
  `CardId` int NOT NULL,
  `Accommodation` int NOT NULL,
  `registration date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


ALTER TABLE `Account`
  ADD PRIMARY KEY (`Account codeId`),
  ADD KEY `habitation` (`habitation`);

ALTER TABLE `Client`
  ADD PRIMARY KEY (`ClientsId`);

ALTER TABLE `Habitation`
  ADD PRIMARY KEY (`AccommodationId`),
  ADD KEY `habitation_ibfk_1` (`client`);

ALTER TABLE `Number`
  ADD PRIMARY KEY (`The code numberId`),
  ADD KEY `type` (`type`);

ALTER TABLE `Registration card`
  ADD PRIMARY KEY (`CardId`),
  ADD KEY `Accommodation` (`Accommodation`);


ALTER TABLE `Account`
  MODIFY `Account codeId` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `Client`
  MODIFY `ClientsId` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `Habitation`
  MODIFY `AccommodationId` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `Number`
  MODIFY `The code numberId` int NOT NULL AUTO_INCREMENT;

ALTER TABLE `Registration card`
  MODIFY `CardId` int NOT NULL AUTO_INCREMENT;


ALTER TABLE `Account`
  ADD CONSTRAINT `account_ibfk_1` FOREIGN KEY (`habitation`) REFERENCES `Habitation` (`AccommodationId`) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE `Habitation`
  ADD CONSTRAINT `habitation_ibfk_1` FOREIGN KEY (`client`) REFERENCES `Client` (`ClientsId`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `Number`
  ADD CONSTRAINT `number_ibfk_1` FOREIGN KEY (`type`) REFERENCES `Registration card` (`CardId`) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE `Registration card`
  ADD CONSTRAINT `registration card_ibfk_1` FOREIGN KEY (`Accommodation`) REFERENCES `Habitation` (`AccommodationId`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;
