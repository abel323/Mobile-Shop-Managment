SELECT * FROM tblBrand

CREATE VIEW MobileView AS
SELECT Mob.ID, Mob.Mobile_Name,Brand.BrandName, Mob.Production_Year,
Mob.Quanitiy_In_Stock, Mob.Unit_Price FROM tblMobile Mob INNER JOIN tblBrand Brand 
ON Mob.Brand = Brand.ID

SELECT * FROM MobileView

CREATE VIEW SaleView AS 
SELECT tblCustomer.FName,tblCustomer.LName,tblCustomer.Phone, tblMobile.Mobile_Name,
tblSale.Quantity,tblSale.Unit_Price,tblSale.Total
FROM tblCustomer INNER JOIN tblSale ON tblCustomer.ID = tblsale.Customer_ID INNER JOIN tblMobile ON tblSale.Mobile_ID = tblMobile.ID

SELECT * FROM tblMobile

SELECT * FROM tblSale
