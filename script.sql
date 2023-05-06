DROP DATABASE IF EXISTS LeagueManager;
CREATE DATABASE LeagueManager;

USE LeagueManager;

DROP TABLE IF EXISTS `periods`;
CREATE TABLE `periods`(
`ID_Period` int NOT NULL AUTO_INCREMENT,
`Start_Date` DATETIME,
`End_Date` DATETIME,
PRIMARY KEY (`ID_Period`)
);

DROP TABLE IF EXISTS `competitionstype`;
CREATE TABLE `competitionstype`(
	`ID_Type` int NOT NULL AUTO_INCREMENT,
    `TypeName` VARCHAR(50) NOT NULL,
    PRIMARY KEY (`ID_Type`)
);
INSERT INTO `competitionstype` (`TypeName`) VALUES ("League"),("Tournament");

DROP TABLE IF EXISTS `competitions`;
CREATE TABLE `competitions` (
  `ID_Competition` int NOT NULL AUTO_INCREMENT,
  `Competition_Name` varchar(50) NOT NULL,
  `ID_Period` int NOT NULL,
  `Competition_Type` int NOT NULL,
  PRIMARY KEY (`ID_Competition`),
  FOREIGN KEY (`ID_Period`) REFERENCES `periods`(`ID_Period`),
  FOREIGN KEY (`Competition_Type`) REFERENCES `competitionstype`(`ID_Type`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `userstype`;
CREATE TABLE `userstype` (
ID_UserType INT NOT NULL AUTO_INCREMENT,
NameType VARCHAR(50) NOT NULL,
PRIMARY KEY (ID_UserType)
);
LOCK TABLES `userstype` WRITE;
INSERT INTO `userstype` (NameType) VALUES ("Administrator"),("Trainer"),("Referee");
UNLOCK TABLES;


DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `ID_User` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(50) NOT NULL,
  `UserPassword` blob NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `UserType` INT NOT NULL,
  FOREIGN KEY (UserType) REFERENCES userstype(ID_UserType),
  PRIMARY KEY (`ID_User`),
  UNIQUE KEY `UserName` (`UserName`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
LOCK TABLES `users` WRITE;
INSERT INTO `users` VALUES (1,'Admin',_binary 'j9{¬E:H\Ý\Æ_`Á','admin@leaguemanager.com',1),(2,'Juan',_binary '.tøqúövù®','juan@leaguemanager.com',2),(4,'Titos',_binary 'whP|±È?ø¾Hú','titos@kleague.com',3),(5,'Pepe Mel',_binary '(Â²*J%®D)·','pepemel@leaguemanager.com',2),(6,'AdriÃ¡n',_binary '1s0\Ø.\\5LN{P\"','adri@leagueManager.com',2),(7,'Lolito',_binary 'ýÿ	x\È3+]\rB','lolit0@leagueManager.com',2),(8,'Pirezmano',_binary '\å²ÕB !\Ð\îb\ÙC','pmano@leaguemanager.com',2);
UNLOCK TABLES;

DROP TABLE IF EXISTS `teams`;
CREATE TABLE `teams` (
  `ID_Team` int NOT NULL AUTO_INCREMENT,
  `Team_Name` varchar(50) NOT NULL,
  `Origin` varchar(50) DEFAULT NULL,
  `Creation_Date` DATE DEFAULT NULL,
  PRIMARY KEY (`ID_Team`),
  UNIQUE KEY `Team_Name` (`Team_Name`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `teamsManager`;
CREATE TABLE `teamsManager`(
`ID_User` INT NOT NULL,
`ID_Team` INT NOT NULL,
`ID_Period` int NOT NULL,
FOREIGN KEY (`ID_Period`) REFERENCES `periods`(`ID_Period`),
FOREIGN KEY (`ID_Team`) REFERENCES `teams`(`ID_Team`),
FOREIGN KEY (`ID_User`) REFERENCES `users`(`ID_User`)
);

DROP TABLE IF EXISTS `participate`;
CREATE TABLE `participate` (
  `ID_Team` int NOT NULL,
  `ID_Competition` int NOT NULL,
  PRIMARY KEY (`ID_Team`,`ID_Competition`),
  FOREIGN KEY (`ID_Team`) REFERENCES `teams` (`ID_Team`),
  FOREIGN KEY (`ID_Competition`) REFERENCES `competitions` (`ID_Competition`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `games`;
CREATE TABLE `games` (
  `ID_Game` int NOT NULL AUTO_INCREMENT,
  `ID_Referee` int DEFAULT NULL,
  `Home_Team` int NOT NULL,
  `Away_Team` int NOT NULL,
  `ID_Competition` int NOT NULL,
  `Matchday` varchar(50) DEFAULT NULL,
  `Game_Date` DATETIME NOT NULL,
  `Played` bit(1) NOT NULL,
  PRIMARY KEY (`ID_Game`),
  FOREIGN KEY (`Home_Team`) REFERENCES `teams` (`ID_Team`),
  FOREIGN KEY (`Away_Team`) REFERENCES `teams` (`ID_Team`),
  FOREIGN KEY (`ID_Referee`) REFERENCES `users` (`ID_User`),
  FOREIGN KEY (`ID_Competition`) REFERENCES `competitions` (`ID_Competition`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `players`;
CREATE TABLE `players` (
  `ID_Player` int NOT NULL AUTO_INCREMENT,
  `Number` int NOT NULL,
  `Player_Name` varchar(100) NOT NULL,
  `Age` int DEFAULT NULL,
  `Position` varchar(10) NOT NULL,
  `Nacionality` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Player`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `teamplayers`;
CREATE TABLE `teamplayers` (
  `ID_Team` int NOT NULL,
  `ID_Player` int NOT NULL,
  `ID_Period` int NOT NULL,
  FOREIGN KEY (ID_Team) REFERENCES teams (ID_Team),
  FOREIGN KEY (ID_Player) REFERENCES players (ID_Player),
  FOREIGN KEY (ID_Period) REFERENCES periods (ID_Period)
);

DROP TABLE IF EXISTS `reports`;
CREATE TABLE `reports` (
  `ID_Player` int NOT NULL,
  `ID_Game` int NOT NULL,
  `Goals` int NOT NULL,
  `Sanctions` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Player`,`ID_Game`),
  FOREIGN KEY (`ID_Player`) REFERENCES `players` (`ID_Player`),
  FOREIGN KEY (`ID_Game`) REFERENCES `games` (`ID_Game`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

