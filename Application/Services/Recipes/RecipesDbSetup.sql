CREATE DATABASE IF NOT EXISTS doprr_recipes;
USE doprr_recipes;

CREATE USER IF NOT EXISTS 'recipes-api-api'@'%' IDENTIFIED BY 'eltiempo';
GRANT Usage ON *.* TO 'recipes-api-api'@'%' ;
GRANT Delete ON doprr_recipes.* TO 'recipes-api-api'@'%' ;
GRANT Insert ON doprr_recipes.* TO 'recipes-api-api'@'%' ;
GRANT Select ON doprr_recipes.* TO 'recipes-api-api'@'%' ;
GRANT Update ON doprr_recipes.* TO 'recipes-api-api'@'%' ;

GRANT ALL PRIVILEGES ON doprr_recipes* TO 'doprr'@'%';
