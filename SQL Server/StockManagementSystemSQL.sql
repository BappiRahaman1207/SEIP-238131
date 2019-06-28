 CREATE DATABASE SMS 
  USE SMS 

 CREATE TABLE CategorySetup(
 SL int IDENTITY (1,1)PRIMARY KEY,
 Name VARCHAR(50)
 )

--DROP TABLE MobileInformation

INSERT INTO CategorySetup (Name) VALUES ('Stationary')

SELECT * FROM CategorySetup
