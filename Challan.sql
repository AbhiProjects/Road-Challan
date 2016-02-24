DROP DATABASE IF EXISTS dbChallan ;
CREATE DATABASE dbChallan;

use dbChallan;

-- CREATING TABLE STRUCTURE

DROP TABLE IF EXISTS tblCompany;
CREATE TABLE tblCompany
(
Id int PRIMARY KEY,
CName varchar(255),
cst varchar(255),
vat varchar(255)
);

DROP TABLE IF EXISTS tblDistributor;
CREATE TABLE tblDistributor
(
Id int PRIMARY KEY,
DistributorName varchar(255),
CO varchar(255),
Adress1 varchar(255),
Adress2 varchar(255),
Adress3 varchar(255),
DispatcherName varchar(255),
DAdress1 varchar(255),
DAdress2 varchar(255),
DAdress3 varchar(255)
);

DROP TABLE IF EXISTS tblChallan;
CREATE TABLE tblChallan
(
Invoice int,
IDate varchar(255),
Qty int,
Amount numeric(18,2),
Cartoons int,
DDate varchar(255),
DId int,
CId int,
Primary Key(Invoice,CId),
FOREIGN KEY(DId) REFERENCES tblDistributor(Id),
FOREIGN KEY(CId) REFERENCES tblCompany(Id)
);

DROP TABLE IF EXISTS tblLocalChallan;
CREATE TABLE tblLocalChallan
(
Invoice int,
IDate varchar(255),
DDate varchar(255),
Amount numeric(18,2),
DId int,
CId int,
Nonslip int,
Souminie int,
Komli int,
Tweens int,
KomliPanty int,
Leggings int,
Primary Key(Invoice,CId),
FOREIGN KEY(DId) REFERENCES tblDistributor(Id),
FOREIGN KEY(CId) REFERENCES tblCompany(Id)
);

