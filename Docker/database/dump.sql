CREATE DATABASE IF NOT EXISTS parking_db;

-- create the users for each database
CREATE USER 'projectoneuser'@'%' IDENTIFIED BY 'AHtCmBQ4S6zyZfUf';

GRANT ALL PRIVILEGES ON *.* TO 'projectoneuser'@'%' WITH GRANT OPTION;

FLUSH PRIVILEGES;

DROP PROCEDURE IF EXISTS POMELO_BEFORE_DROP_PRIMARY_KEY;
CREATE PROCEDURE POMELO_BEFORE_DROP_PRIMARY_KEY(IN `SCHEMA_NAME_ARGUMENT` VARCHAR(255), IN `TABLE_NAME_ARGUMENT` VARCHAR(255))
BEGIN
        DECLARE HAS_AUTO_INCREMENT_ID TINYINT(1);
        DECLARE PRIMARY_KEY_COLUMN_NAME VARCHAR(255);
        DECLARE PRIMARY_KEY_TYPE VARCHAR(255);
        DECLARE SQL_EXP VARCHAR(1000);
        SELECT COUNT(*)
                INTO HAS_AUTO_INCREMENT_ID
                FROM `information_schema`.`COLUMNS`
                WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
                        AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
                        AND `Extra` = 'auto_increment'
                        AND `COLUMN_KEY` = 'PRI'
                        LIMIT 1;
        IF HAS_AUTO_INCREMENT_ID THEN
                SELECT `COLUMN_TYPE`
                        INTO PRIMARY_KEY_TYPE
                        FROM `information_schema`.`COLUMNS`
                        WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
                                AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
                                AND `COLUMN_KEY` = 'PRI'
                        LIMIT 1;
                SELECT `COLUMN_NAME`
                        INTO PRIMARY_KEY_COLUMN_NAME
                        FROM `information_schema`.`COLUMNS`
                        WHERE `TABLE_SCHEMA` = (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA()))
                                AND `TABLE_NAME` = TABLE_NAME_ARGUMENT
                                AND `COLUMN_KEY` = 'PRI'
                        LIMIT 1;
                SET SQL_EXP = CONCAT('ALTER TABLE `', (SELECT IFNULL(SCHEMA_NAME_ARGUMENT, SCHEMA())), '`.`', TABLE_NAME_ARGUMENT, '` MODIFY COLUMN `', PRIMARY_KEY_COLUMN_NAME, '` ', PRIMARY_KEY_TYPE, ' NOT NULL;');
                SET @SQL_EXP = SQL_EXP;
                PREPARE SQL_EXP_EXECUTE FROM @SQL_EXP;
                EXECUTE SQL_EXP_EXECUTE;
                DEALLOCATE PREPARE SQL_EXP_EXECUTE;
        END IF;
END //
DELIMITER ;

CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `AspNetOrganizationRelations` (
    `Id` bigint NOT NULL AUTO_INCREMENT,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `NormalizedName` longtext CHARACTER SET utf8mb4 NOT NULL,
    `CreatedAt` datetime(6) NOT NULL,
    `UpdatedAt` datetime(6) NOT NULL,
    CONSTRAINT `PK_AspNetOrganizationRelations` PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20191107172223_Initial', '3.0.1-dev');

CALL POMELO_BEFORE_DROP_PRIMARY_KEY(NULL, 'AspNetOrganizationRelations');
ALTER TABLE `AspNetOrganizationRelations` DROP PRIMARY KEY;

ALTER TABLE `AspNetOrganizationRelations` MODIFY COLUMN `Id` bigint NOT NULL;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20191107172455_DropPrimaryKey', '3.0.1-dev');


DROP PROCEDURE POMELO_BEFORE_DROP_PRIMARY_KEY;