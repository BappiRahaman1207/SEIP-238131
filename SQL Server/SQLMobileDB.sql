CREATE DATABASE MobileDB
 USE MobileDB
 
CREATE TABLE MobileInformation(
ID int IDENTITY (1,1)PRIMARY KEY,
ModelName VARCHAR(50),
IMEI VARCHAR(100),
Price int
)

--DROP TABLE MobileInformation

INSERT INTO MobileInformation ( ModelName,IMEI,Price) VALUES ('Nokia 1100','E2R45RTU7',1200)

SELECT * FROM MobileInformation