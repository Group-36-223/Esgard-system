USE Esgard;
GO

Create Table Payment_Type
(
	Payment_Type_ID int IDENTITY(1,1) Primary key,
	Payment_Option varchar(20)
);

Create Table Employee
(
	Employee_ID INT IDENTITY(1,1) Primary key,
	F_Name varchar(20),
	L_Name varchar(20),
	User_ID_No char(10),
	cell_No char(10),
	Email_Address varchar(30),
	ID_Number char(13)
);
Create Table Inventory 
(
	Inventory_ID INT IDENTITY(1,1) Primary key,
	Descri varchar(30),
	Color varchar(15),
	Category varchar(15),
	Serial_No char (12),
	Unit_Price smallmoney
);

Create Table Client 
(
	Client_ID INT IDENTITY(1,1) Primary key,
	F_Name varchar(20),
	L_Name varchar(20),
	Cell_No Char (10),
	Email_Address varchar(30)
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
	Purchase_number char(10)
);

Create Table Purchase_Details
(
	Purchases_ID INT,
	Inventory_ID INT,
	Qty_Sold int ,
	Is_returned bit,
	CONSTRAINT PK_Purchase_Details PRIMARY KEY (Purchases_ID, Inventory_ID),
	CONSTRAINT PD_FK_P  FOREIGN KEY (Purchases_ID) REFERENCES Purchases(Purchases_ID),
	CONSTRAINT PD_FK_IN FOREIGN KEY (Inventory_ID) REFERENCES Inventory(Inventory_ID)
);
