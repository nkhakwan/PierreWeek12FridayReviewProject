# _Pierre Sweet Shop_

#### _Epicodus Week12 Friday Review Project_

#### By _**Khan Sahab**_

## Description

_A website that allows visitors to see all the treats that are available in a sweet shop and they can see the flavors each sweet is available. However only the logged in users can add, update, delete both Treats and flavors. It has the ability to register and log in users _

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run.
5. Run "dotnet ef migrations add <yourtag>
6. Run "dotnet ef database update"
Or Please see the detailed tables dump at the end of this README file for all the tables and database.

## Database is named Sweet. Firstname_lastname not avaialbe in mysql WB

7. Against the norms appsettings.json is available for teachers viewing. Didn't include it in .gitignore.



## Known Bugs
 
None.
 
## Support and contact details

_Have a bug or an issue with this application? Email post_khan@yahoo.com_

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MSBuild
* Razor
* Git and GitHub
* mysql database
* Entity
* Identity

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Any visitor can see all the treats** | User Input:"see all treats” | Output: " all the treats are displayed on the next page" |
| **Any visitor can see all the flavors** | User Input:"see all flavors"| Output: "All the flavors are displayed" |
| **Any visitor can see all the flavors that any particular treat is in** | User Input:"click on any treat” | Output: "All the flavors associated with that treat are displayed" |
| **Any visitor can see all the treats that carry any particular flavor** | User Input:"click on any flavor” | Output: "All the treats carrying that flavor would be displayed" |
| **Any visitor can register** | User Input:"click on register” | Output: "form requiring email and password is displayed and on clicking visitor is registerd" |
| **Only logged in users can delete, edit, add either Treats or Flavors** | User Input:"click 'delete' 'edit' 'add' either on trets or on flavors page” | Output: " 'delet' 'edit' 'add' allowed to the user" |
| **Not logged in users cannot delete, edit or add neither Treats nor Flavors** | User Input:"click 'delete' 'edit' 'add' either on treats or on flavors page” | Output: "visitor is shown a page to log in" |




# Please see below the dump of database plus all the tables



CREATE DATABASE `sweet` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetroleclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext,
  `ClaimValue` longtext,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext,
  `UserId` varchar(255) NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `flavors` (
  `FlavorId` int NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  PRIMARY KEY (`FlavorId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `flavortreat` (
  `FlavorTreatId` int NOT NULL AUTO_INCREMENT,
  `TreatId` int NOT NULL,
  `FlavorId` int NOT NULL,
  PRIMARY KEY (`FlavorTreatId`),
  KEY `IX_flavorTreat_FlavorId` (`FlavorId`),
  KEY `IX_flavorTreat_TreatId` (`TreatId`),
  CONSTRAINT `FK_flavorTreat_flavors_FlavorId` FOREIGN KEY (`FlavorId`) REFERENCES `flavors` (`FlavorId`) ON DELETE CASCADE,
  CONSTRAINT `FK_flavorTreat_treats_TreatId` FOREIGN KEY (`TreatId`) REFERENCES `treats` (`TreatId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `treats` (
  `TreatId` int NOT NULL AUTO_INCREMENT,
  `Products` longtext,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TreatId`),
  KEY `IX_treats_UserId` (`UserId`),
  CONSTRAINT `FK_treats_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Khan Sahab_**
