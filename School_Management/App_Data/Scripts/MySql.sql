-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 22, 2025 at 06:22 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `schoolmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `activities`
--

CREATE TABLE `activities` (
  `ActivityID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Date` date NOT NULL,
  `ClassID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `AttendanceID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `StudentID` int(11) NOT NULL,
  `Status` enum('Present','Absent') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`AttendanceID`, `Date`, `StudentID`, `Status`) VALUES
(2, '2025-01-01', 1, 'Present'),
(3, '2025-01-01', 2, 'Absent'),
(4, '2025-01-01', 3, 'Present'),
(5, '2025-01-01', 4, 'Present'),
(6, '2025-01-01', 5, 'Absent'),
(9, '2025-01-11', 1, 'Present'),
(11, '2025-01-11', 1, 'Present'),
(13, '2025-01-11', 1, 'Present'),
(15, '2025-01-15', 1, 'Absent'),
(16, '2025-01-13', 5, 'Present'),
(17, '2025-01-07', 5, 'Present'),
(18, '2025-01-07', 5, 'Present'),
(24, '2025-01-08', 1, 'Present'),
(25, '2025-01-18', 5, 'Present'),
(26, '2025-01-18', 14, 'Present');

-- --------------------------------------------------------

--
-- Table structure for table `classes`
--

CREATE TABLE `classes` (
  `ClassID` int(11) NOT NULL,
  `ClassName` varchar(50) NOT NULL,
  `Level` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `classes`
--

INSERT INTO `classes` (`ClassID`, `ClassName`, `Level`) VALUES
(1, 'Grade 1', 'Primary'),
(2, 'Grade 2', 'Primary'),
(3, 'Grade 3', 'Primary'),
(4, 'Grade 4', 'Primary'),
(5, 'Grade 5', 'Primary');

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `GradeID` int(11) NOT NULL,
  `StudentID` int(11) NOT NULL,
  `SubjectID` int(11) NOT NULL,
  `Marks` decimal(5,2) NOT NULL,
  `ExamDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `grades`
--

INSERT INTO `grades` (`GradeID`, `StudentID`, `SubjectID`, `Marks`, `ExamDate`) VALUES
(2, 1, 1, '95.50', '2025-01-05'),
(3, 2, 2, '88.00', '2025-01-05'),
(4, 3, 3, '76.50', '2025-01-05'),
(5, 4, 4, '89.00', '2025-01-05'),
(6, 5, 5, '92.50', '2025-01-05'),
(8, 3, 1, '56.00', '2025-01-16'),
(9, 3, 1, '1.00', '2025-01-16');

-- --------------------------------------------------------

--
-- Table structure for table `parents`
--

CREATE TABLE `parents` (
  `ParentID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `parents`
--

INSERT INTO `parents` (`ParentID`, `Name`, `Phone`, `Email`) VALUES
(1, '23', '23', '23'),
(2, 'Fatima Salem', '0923456789', 'fatima.salem@example.com'),
(3, 'Hassan Ahmed', '0934567890', 'hassan.ahmed@example.com'),
(4, 'Mona Youssef', '0945678901', 'mona.youssef@example.com'),
(5, '4', '4', '4'),
(6, '23', '23', '23'),
(7, 'Fatima Salem', '0923456789', 'fatima.salem@example.com'),
(8, 'Hassan Ahmed', '0934567890', 'hassan.ahmed@example.com'),
(9, 'Mona Youssef', '0945678901', 'mona.youssef@example.com'),
(10, '4', '4', '4');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `StudentID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `ClassID` int(11) NOT NULL,
  `ParentID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`StudentID`, `Name`, `DateOfBirth`, `ClassID`, `ParentID`) VALUES
(1, 'Ali Ahmed', '2012-05-10', 1, 1),
(2, 'Salma Hassan', '2011-08-15', 2, 2),
(3, 'Youssef Khaled', '2010-03-20', 3, 3),
(4, 'Mariam Ibrahim', '2011-12-25', 4, 4),
(5, 'Omar Youssef', '2012-07-30', 5, 5),
(14, 'Ahmed', '2025-01-13', 5, 3),
(15, '1', '2025-01-18', 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `SubjectID` int(11) NOT NULL,
  `SubjectName` varchar(100) NOT NULL,
  `TeacherID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `TeacherID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Specialization` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `timetable`
--

CREATE TABLE `timetable` (
  `TimetableID` int(11) NOT NULL,
  `ClassID` int(11) NOT NULL,
  `SubjectID` int(11) NOT NULL,
  `TeacherID` int(11) NOT NULL,
  `Day` varchar(20) NOT NULL,
  `Time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activities`
--
ALTER TABLE `activities`
  ADD PRIMARY KEY (`ActivityID`),
  ADD KEY `ClassID` (`ClassID`);

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`AttendanceID`),
  ADD KEY `StudentID` (`StudentID`);

--
-- Indexes for table `classes`
--
ALTER TABLE `classes`
  ADD PRIMARY KEY (`ClassID`);

--
-- Indexes for table `grades`
--
ALTER TABLE `grades`
  ADD PRIMARY KEY (`GradeID`),
  ADD KEY `StudentID` (`StudentID`),
  ADD KEY `SubjectID` (`SubjectID`);

--
-- Indexes for table `parents`
--
ALTER TABLE `parents`
  ADD PRIMARY KEY (`ParentID`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`StudentID`),
  ADD KEY `fk_ClassID` (`ClassID`),
  ADD KEY `fk_ParentID` (`ParentID`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`SubjectID`),
  ADD KEY `TeacherID` (`TeacherID`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`TeacherID`);

--
-- Indexes for table `timetable`
--
ALTER TABLE `timetable`
  ADD PRIMARY KEY (`TimetableID`),
  ADD KEY `ClassID` (`ClassID`),
  ADD KEY `SubjectID` (`SubjectID`),
  ADD KEY `TeacherID` (`TeacherID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activities`
--
ALTER TABLE `activities`
  MODIFY `ActivityID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `AttendanceID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `classes`
--
ALTER TABLE `classes`
  MODIFY `ClassID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `grades`
--
ALTER TABLE `grades`
  MODIFY `GradeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `parents`
--
ALTER TABLE `parents`
  MODIFY `ParentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `StudentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `SubjectID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `TeacherID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `timetable`
--
ALTER TABLE `timetable`
  MODIFY `TimetableID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `activities`
--
ALTER TABLE `activities`
  ADD CONSTRAINT `activities_ibfk_1` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ClassID`);

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`);

--
-- Constraints for table `grades`
--
ALTER TABLE `grades`
  ADD CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `students` (`StudentID`),
  ADD CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`SubjectID`) REFERENCES `subjects` (`SubjectID`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `fk_ClassID` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ClassID`),
  ADD CONSTRAINT `fk_ParentID` FOREIGN KEY (`ParentID`) REFERENCES `parents` (`ParentID`);

--
-- Constraints for table `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `subjects_ibfk_1` FOREIGN KEY (`TeacherID`) REFERENCES `teachers` (`TeacherID`);

--
-- Constraints for table `timetable`
--
ALTER TABLE `timetable`
  ADD CONSTRAINT `timetable_ibfk_1` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ClassID`),
  ADD CONSTRAINT `timetable_ibfk_2` FOREIGN KEY (`SubjectID`) REFERENCES `subjects` (`SubjectID`),
  ADD CONSTRAINT `timetable_ibfk_3` FOREIGN KEY (`TeacherID`) REFERENCES `teachers` (`TeacherID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
