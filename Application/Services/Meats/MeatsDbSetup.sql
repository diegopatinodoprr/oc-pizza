CREATE DATABASE IF NOT EXISTS doprr_meats;
USE doprr_meats;

CREATE USER IF NOT EXISTS 'meats-api'@'%' IDENTIFIED BY 'eltiempo';
GRANT Usage ON *.* TO 'meats-api'@'%' ;
GRANT Delete ON doprr_meats.* TO 'meats-api'@'%' ;
GRANT Insert ON doprr_meats.* TO 'meats-api'@'%' ;
GRANT Select ON doprr_meats.* TO 'meats-api'@'%' ;
GRANT Update ON doprr_meats.* TO 'meats-api'@'%' ;

GRANT ALL PRIVILEGES ON doprr_meats.* TO 'doprr'@'%';
