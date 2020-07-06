-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 06. Jul 2020 um 15:26
-- Server-Version: 10.3.16-MariaDB
-- PHP-Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `chatmail`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `messages`
--

CREATE TABLE `messages` (
  `id` int(11) NOT NULL,
  `message` mediumtext COLLATE utf8_german2_ci NOT NULL,
  `sender_id` int(11) NOT NULL,
  `time` mediumtext COLLATE utf8_german2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_german2_ci;

--
-- Daten für Tabelle `messages`
--

INSERT INTO `messages` (`id`, `message`, `sender_id`, `time`) VALUES
(1, 'Test Message 1', 1, '11:02'),
(2, 'Test Message 2', 3, '13:04'),
(3, 'Test Message 3', 4, '09:04'),
(4, 'Test Message 4', 2, '09:52'),
(21, 'Elisa', 3, '15:23'),
(22, 'Hallo Maria, das ist eine Testnachricht', 1, '15:25');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `receivers`
--

CREATE TABLE `receivers` (
  `receiver_id` int(11) NOT NULL,
  `message_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_german2_ci;

--
-- Daten für Tabelle `receivers`
--

INSERT INTO `receivers` (`receiver_id`, `message_id`, `user_id`) VALUES
(1, 1, 1),
(2, 1, 6),
(3, 1, 3),
(4, 2, 4),
(5, 2, 2),
(6, 3, 1),
(7, 4, 4),
(8, 4, 3),
(9, 4, 1),
(10, 21, 6),
(11, 22, 5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `user`
--

CREATE TABLE `user` (
  `name` mediumtext COLLATE utf8_german2_ci NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_german2_ci;

--
-- Daten für Tabelle `user`
--

INSERT INTO `user` (`name`, `id`) VALUES
('Hans', 1),
('Georg', 2),
('Peter', 3),
('Gustav', 4),
('Maria', 5),
('Elisa', 6);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`);

--
-- Indizes für die Tabelle `receivers`
--
ALTER TABLE `receivers`
  ADD PRIMARY KEY (`receiver_id`);

--
-- Indizes für die Tabelle `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT für Tabelle `receivers`
--
ALTER TABLE `receivers`
  MODIFY `receiver_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT für Tabelle `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
