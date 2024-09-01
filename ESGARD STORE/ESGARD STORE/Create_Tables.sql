USE Esgard;
GO
Create Table Payment_Type
(
	Payment_Type_ID int IDENTITY(1,1) Primary key,
	Payment_Option varchar(30)
);

Create Table Employee
(
	Employee_ID INT IDENTITY(1,1) Primary key,
	First_Name varchar(50),
	Last_Name varchar(50),
	Employee_Number char(10),
	Cell_No char(10),
	Email_Address varchar(30),
	ID_Number char(13),
	Pssword char(8)
);

Create Table Inventory 
(
	Inventory_ID INT IDENTITY(1,1) Primary key,
	Descr varchar(50),
	Quantity_On_Hand int,
	Unit_Price smallmoney,
	Color varchar(15),
	Size varchar(2),
	Category varchar(15),
	Serial_No char (12)
);

Create Table Client 
(
	Client_ID INT IDENTITY(1,1) Primary key,
	First_Name varchar(50),
	Last_Name varchar(50),
	Cell_No Char (10),
	Email_Address varchar(30),
	Client_Number char(5)
);

Create Table Purchases
(
	Purchases_ID INT IDENTITY(1,1) Primary key,
	Client_ID INT FOREIGN KEY REFERENCES Client(Client_ID),
	Employee_ID INT FOREIGN KEY REFERENCES Employee(Employee_ID),
	Payment_Type_ID INT FOREIGN KEY REFERENCES Payment_Type(Payment_Type_ID),
	Purchase_Date_Time datetime,
	total_cost money,
	Is_paid bit,
	Is_returned bit,
	Purchase_number char(10)
);

Create Table Purchase_Details
(
	Purchases_ID INT,
	Inventory_ID INT,
	Qty_Sold int ,
	CONSTRAINT PK_Purchase_Details PRIMARY KEY (Purchases_ID, Inventory_ID),
	CONSTRAINT PD_FK_P  FOREIGN KEY (Purchases_ID) REFERENCES Purchases(Purchases_ID),
	CONSTRAINT PD_FK_IN FOREIGN KEY (Inventory_ID) REFERENCES Inventory(Inventory_ID)
);