-- create new database on the server
CREATE DATABASE HSDB;

-- turn off Auto_Close immediatiately after creating database 
ALTER DATABASE HSDB
SET AUTO_CLOSE OFF;

-- changing database to use HSDB as default instead of master
USE HSDB;