 CREATE DATABASE SMS 
  USE SMS 

 CREATE TABLE CategoryUi(
 SL int IDENTITY (1,1)PRIMARY KEY,
 Name VARCHAR(50)
 )

--DROP TABLE CategoryUi

INSERT INTO CategoryUi (Name) VALUES ('Stationary')

SELECT * FROM CategoryUi

 CREATE TABLE CompanyUi(
 SL int IDENTITY (1,1)PRIMARY KEY,
 Name VARCHAR(50)
 )

--DROP TABLE CompanyUi

INSERT INTO CompanyUi (Name) VALUES ('Unilever')

SELECT * FROM CompanyUi
