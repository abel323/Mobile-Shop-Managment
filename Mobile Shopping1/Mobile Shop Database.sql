CREATE DATABASE MobileShop

USE MobileShop


CREATE TABLE tblAdmin(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	UserName VARCHAR(30) NOT NULL UNIQUE,
	UserPassword VARCHAR(30) NOT NULL
)

INSERT INTO tblAdmin
VALUES('user@admin.com','admin')

select * from tblAdmin

CREATE TABLE tblBrand(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	BrandName VARCHAR(50) NOT NULL UNIQUE
)

INSERT INTO tblBrand(BrandName)
VALUES('Samsung'),
('Xinomi'),
('Apple'),
('Lenovo'),
('Nokia'),
('LG')

SELECT * FROM tblBrand

CREATE TABLE tblCustomer(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FName VARCHAR(30) NOT NULL,
	LName VARCHAR(30) NOT NULL,
	MName VARCHAR(30),
	DOR DATE DEFAULT GETDATE(),
	Phone VARCHAR(15) NOT NULL UNIQUE,
	Email VARCHAR(50) NOT NULL UNIQUE,
	Customer_Address TEXT NOT NULL
)

CREATE TABLE tblMobile(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Mobile_Name VARCHAR(50) NOT NULL UNIQUE,
	Brand INT NOT NULL,
	Production_Year DATE NOT NULL,
	Quanitiy_In_Stock INT NOT NULL DEFAULT 0,
	Unit_Price MONEY NOT NULL,
	CONSTRAINT CK_QUANTITY CHECK(Quanitiy_In_Stock>=0),
	CONSTRAINT CK_PRICE CHECK(Unit_Price>0),
	CONSTRAINT FK_MOB_BRAND FOREIGN KEY(Brand) REFERENCES tblBrand(ID) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE tblSale(
	Mobile_ID INT NOT NULL,
	Customer_ID INT NOT NULL,
	Quantity INT NOT NULL,
	Unit_Price MONEY NOT NULL,
	Total AS Quantity * Unit_Price,
	FOREIGN KEY (Mobile_ID) REFERENCES tblMobile(ID) ON UPDATE CASCADE ON DELETE NO ACTION,
	FOREIGN KEY (Customer_ID) References tblCustomer(ID) ON UPDATE CASCADE ON DELETE NO ACTION,
	PRIMARY KEY(Mobile_ID,Customer_ID)
)

INSERT INTO tblCustomer(FName,MName,LName,Phone,Email,Customer_Address)
VALUES('Abel','Mesay','Gebremeskel','951078852','abelmesay@gmail.com','Addis Ababa Mauritius Street')

SELECT * FROM tblCustomer