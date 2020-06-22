# Create DataBase 
CREATE DATABASE quizapp;

# Create Table admin
CREATE TABLE `quizapp`.`admin` (
  `username` VARCHAR(50) NOT NULL,
  `password` VARCHAR(50) NOT NULL,
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`username`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE);
    
# Create Table questions
CREATE TABLE `quizapp`.`questions` (
  `idquestions` INT NOT NULL,
  `questionscol` VARCHAR(145) NOT NULL,
  `opa` VARCHAR(145) NULL,
  `opb` VARCHAR(145) NULL,
  `opc` VARCHAR(145) NULL,
  `opd` VARCHAR(145) NULL,
  `catagory` VARCHAR(145) NULL,
  `correctoption` VARCHAR(145) NULL,
  PRIMARY KEY (`idquestions`, `questionscol`),
  UNIQUE INDEX `idquestions_UNIQUE` (`idquestions` ASC) VISIBLE,
  UNIQUE INDEX `questionscol_UNIQUE` (`questionscol` ASC) VISIBLE);
  
# Create Table user
CREATE TABLE `quizapp`.`user` (
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`username`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE);

# Create Table result
CREATE TABLE `quizapp`.`result` (
  `correctanswers` INT NULL,
  `datetime` DATETIME NULL,
  `totalscore` INT NULL,
  `username` VARCHAR(45),
   FOREIGN KEY (`username`) REFERENCES `user`(`username`));

# Insert Into admin Table
INSERT INTO `quizapp`.`admin` (`username`, `password`, `name`) VALUES ('admin', 'admin', 'admin');
SELECT * FROM `quizapp`.`admin`;

# Insert Into questions Table
INSERT INTO `quizapp`.`questions` (`idquestions`, `questionscol`, `opa`, `opb`, `opc`, `opd`, `catagory`, `correctoption`) VALUES ('1', 'What is your naem?', 'A', 'B', 'C', 'D', 'Cricket', 'B');
SELECT * FROM `quizapp`.`questions`;

# Insert Into user Table
INSERT INTO `quizapp`.`user` (`username`, `password`, `name`) VALUES ('user', 'user', 'player');
SELECT * FROM `quizapp`.`user`;

# Insert Into result Table
INSERT INTO `quizapp`.`result` ( `correctanswers`, `datetime`, `totalscore`,`username`) VALUES ('8', '2020-01-01 10:10:10+05:30', '40','user');
SELECT * FROM `quizapp`.`result`;

