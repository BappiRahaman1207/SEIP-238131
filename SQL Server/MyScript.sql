CREATE DATABASE StudentBD
USE StudentBD
CREATE TABLE Students(
ID int IDENTITY(1,1),
Name VARCHAR(100),
Age int

)

--DROP TABLE Students

INSERT INTO Students(Name,Age) VALUES('Ali',21)
INSERT INTO Students(Name,Age) VALUES('Assad',22)
INSERT INTO Students(Name,Age) VALUES('KOMOL',23)


UPDATE Students
SET Name='Monir'
WHERE ID=3

SELECT*FROM Students
