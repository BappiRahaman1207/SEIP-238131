INSERT INTO Category (CategoryName) VALUES ('Stationery') 
INSERT INTO Category (CategoryName) VALUES ('Computer')
SELECT *FROM Category


INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Pen',10,15,'Good pen for exam') 
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Pencil',100,5,'Good pencil for drawing')
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Notebook',50,25,'Notebook for primary students') 
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Fullscape',200,15,'Fullscape for higer secondary students') 
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (1,'Eraser',1000,1.50,'Eraser for KG Students') 
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (2,'Mouse',20,200,'USB 2.0 Mouse') 
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (2,'Keyboard',20,250,'USB 3.0 Keyboard') 
INSERT INTO Product (CategoryId,ProductName,Qty,Price,Description) VALUES (2,'USB Stick',1000,450,'4 GB Pendrives')
SELECT *FROM Product 

SELECT ProductName, Qty, Price FROM Product 

SELECT * FROM Product WHERE ProductId=2

SELECT * FROM Product WHERE ProductId Between 4 and 8 

SELECT * FROM Product WHERE ProductName in ('Mouse','Keyboard','USB Stick') 

SELECT * FROM Product WHERE ProductName Like 'k%'   

SELECT * FROM Product WHERE ProductName Like '%k'  

--It fetches records from the product table where ProductName start with either ‘E’ or ‘F’. 

SELECT * FROM Product WHERE ProductName Like '[EF]%' 


--It fetches records from the product table where ProductName doesn’t  start with either ‘E’ or ‘F’. 

SELECT * FROM Product WHERE ProductName Like '[^EF]%'  


--In this query, Additonal data i.e SPACE(1) is added to add space between ProductName and ProductQty. 
--So additional data can be added within the select query using ‘+’ operator. 

SELECT (ProductName + SPACE(1) + CONVERT(VARCHAR,Qty)) AS ProductWithQty FROM Product   

--It fetches records from the Product database where Description is not null. 
--In some cases data could remain NULL, so in order to find out only those records which are not null ‘IS NOT NULL’ 
--clause is used in conjunction with WHERE clause/condition. 

SELECT * FROM Product WHERE Description IS  NOT NULL  

--It fetches records from Product table in Descending order. 
--Note: Ascending order is by default. 

SELECT * FROM Product ORDER BY ProductId DESC   


--It fetches records from Product table in ascending order. 

SELECT * FROM Product ORDER BY ProductId

--It fetches unique records from Product table based on CategoryId. 

SELECT DISTINCT CategoryId FROM Product  


--It fetches top 5 rows from the Product table. 
--Hence, TOP n statement is used to fetch top n rows from the table

SELECT Top 5 * FROM Product 

