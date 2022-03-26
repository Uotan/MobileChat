-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Мар 26 2022 г., 16:09
-- Версия сервера: 5.7.27-30
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `u1621366_cryptorin`
--
CREATE DATABASE IF NOT EXISTS `u1621366_cryptorin` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `u1621366_cryptorin`;

-- --------------------------------------------------------

--
-- Структура таблицы `messages`
--

CREATE TABLE `messages` (
  `id` int(10) NOT NULL,
  `from_whom` int(10) NOT NULL,
  `for_whom` int(10) NOT NULL,
  `content` varchar(255) NOT NULL,
  `datetime` datetime DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `messages`
--

INSERT INTO `messages` (`id`, `from_whom`, `for_whom`, `content`, `datetime`) VALUES
(7, 1, 2, 'пишу привет из приложения', '2022-03-16 00:59:24'),
(9, 1, 2, 'лвлала', '2022-03-16 01:00:38'),
(10, 1, 2, 'iwwisk', '2022-03-16 01:00:59'),
(11, 1, 2, 'ivivifif', '2022-03-16 01:01:03'),
(12, 1, 2, 'qioqow', '2022-03-16 01:01:06'),
(13, 2, 1, 'раз два три', '2022-03-16 01:04:08'),
(14, 2, 1, 'лвовоа', '2022-03-16 01:04:30'),
(15, 1, 2, 'hxhdhd', '2022-03-16 01:17:09'),
(16, 1, 2, 'nxnxxnxb', '2022-03-16 01:17:11'),
(17, 1, 2, 'nsnnsnsnsns', '2022-03-16 01:17:15'),
(18, 1, 2, 'jajsjsjsjsdnc', '2022-03-16 01:17:19'),
(19, 1, 2, 'uuwuqiqiq', '2022-03-16 01:17:25'),
(20, 2, 1, 'uaushshshdjf', '2022-03-16 01:17:46'),
(21, 2, 1, 'kzkxkxkx', '2022-03-16 01:17:49'),
(22, 2, 1, 'jsjdjdjdj', '2022-03-16 01:17:52'),
(23, 2, 1, 'iwiwiweifm', '2022-03-16 01:17:58'),
(24, 1, 2, 'привеет', '2022-03-16 03:42:41'),
(25, 1, 2, 'Marat', '2022-03-16 04:31:47'),
(26, 1, 2, 'яя тут ', '2022-03-16 11:01:51'),
(27, 1, 2, 'я тутуттутиу', '2022-03-16 11:02:00'),
(28, 1, 2, 'jdhdh', '2022-03-16 11:05:29'),
(29, 1, 2, 'хпхахахаха, работает', '2022-03-16 11:05:42'),
(30, 1, 2, 'ппп', '2022-03-16 12:08:49'),
(31, 1, 2, 'вот такие дела', '2022-03-16 18:33:39'),
(32, 1, 2, 'жопа', '2022-03-16 18:41:38'),
(33, 1, 2, 'хаха', '2022-03-16 22:17:31'),
(34, 1, 2, 'классный час для дэбилов', '2022-03-17 08:30:45'),
(35, 2, 1, 'согласен', '2022-03-18 07:17:43'),
(36, 1, 2, 'отчет не хочу делать', '2022-03-18 10:39:59'),
(37, 1, 2, 'очин', '2022-03-19 06:12:08'),
(38, 1, 2, 'ggggg', '2022-03-19 06:21:17'),
(39, 1, 2, 'пишу привет из приложения', '2022-03-21 18:51:55'),
(40, 1, 2, 'отчет не хочу делать', '2022-03-21 18:54:04'),
(41, 1, 2, 'согласен хаха', '2022-03-21 21:26:08'),
(42, 1, 2, 'пишу привет из приложения снова', '2022-03-22 10:19:08'),
(43, 1, 2, 'проверка count fetch', '2022-03-26 11:17:30'),
(44, 1, 2, 'qqq', '2022-03-26 11:20:12'),
(45, 1, 2, 'dhhd', '2022-03-26 11:20:19'),
(46, 1, 2, 'хаахах', '2022-03-26 11:20:24'),
(47, 1, 2, 'aaa', '2022-03-26 11:24:06'),
(48, 1, 2, 'uquq', '2022-03-26 11:38:46'),
(49, 1, 2, 'yyy', '2022-03-26 11:41:56');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(10) NOT NULL,
  `nickname` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `nickname`, `password`) VALUES
(1, 'user1', '123'),
(2, 'user2', '123'),
(3, 'user3', '123'),
(4, 'ник на русском', 'пароль');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`),
  ADD KEY `from_whom` (`from_whom`),
  ADD KEY `for_whom` (`for_whom`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `messages`
--
ALTER TABLE `messages`
  ADD CONSTRAINT `messages_ibfk_1` FOREIGN KEY (`from_whom`) REFERENCES `users` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `messages_ibfk_2` FOREIGN KEY (`for_whom`) REFERENCES `users` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
