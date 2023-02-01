/* Table: 'person' */
CREATE TABLE `zeta`.`person`(
    `Id` int NOT NULL,
    `Tag` char(36) CHARACTER SET ascii COLLATE ascii_bin NULL,
    `IsChecked` tinyint NULL,
    `Birthday` datetime NULL,
    `FirstName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
    `LastName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
    `Initials` char(2) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL,
    `Gender` tinyint unsigned NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY(`Id`))

/* Index: 'UX_person_tag' on table 'person' */
CREATE UNIQUE INDEX `UX_person_tag` ON `zeta`.`person`(`Tag` ASC)

/* Table: 'persondata' */
CREATE TABLE `zeta`.`persondata`(
    `Id` smallint NOT NULL,
    `PersonId` int NOT NULL,
    `BestAge` tinyint NULL,
    `Hash` bigint NULL,
    `Height` decimal(10, 2) NULL,
    `Weight` decimal(10, 2) NULL,
    `UpdatedAt` datetime NULL,
    `Signature` binary(4) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY(`Id`),
    CONSTRAINT `FK_personData_person` FOREIGN KEY(`PersonId`) REFERENCES `zeta`.`person`(`Id`))

/* Table: 'photo' */
CREATE TABLE `zeta`.`photo`(
    `Id` char(4) CHARACTER SET ascii COLLATE ascii_bin NOT NULL,
    `PersonDataId` smallint NOT NULL,
    `Content` blob NOT NULL,
    `ContentThumbnail` varbinary(4000) NULL,
    `TakenAt` datetime NULL,
    `ValidUntil` date NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY(`Id`),
    CONSTRAINT `FK_photo_personData` FOREIGN KEY(`PersonDataId`) REFERENCES `zeta`.`persondata`(`Id`))

