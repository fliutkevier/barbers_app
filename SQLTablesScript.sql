
CREATE DATABASE PeluKingPrueba
GO

USE PelukingPrueba
GO

CREATE TABLE Clients
(
	id_cli INT IDENTITY(1,1) NOT NULL,
	name_cli varchar(25) NOT NULL,
	lastname_cli varchar(25) NOT NULL,
	dni_cli varchar(10) NOT NULL,
	phone_cli varchar(15),
	isActive_cli bit default 1,
	CONSTRAINT PK_Clients PRIMARY KEY (id_cli)
)
GO

CREATE TABLE Workers
(
	id_wor INT IDENTITY(1,1) NOT NULL,
	name_wor varchar(25) NOT NULL,
	lastname_wor varchar(25) NOT NULL,
	dni_wor varchar(10) NOT NULL,
	phone_wor varchar(15),
	address_wor varchar(50),
	isActive_wor bit default 1,
	CONSTRAINT PK_Workers PRIMARY KEY (id_wor)
)
GO

CREATE TABLE Services
(
	id_ser INT IDENTITY(1,1) NOT NULL,
	name_ser varchar(30) NOT NULL,
	price_ser decimal(10, 2) NOT NULL,
	isActive_ser bit default 1,
	CONSTRAINT PK_Services PRIMARY KEY (id_ser)
)
GO

CREATE TABLE PaymentMethods
(
	id_pay INT IDENTITY(1,1) NOT NULL,
	name_pay varchar(30) NOT NULL,
	isActive_pay bit default 1 NOT NULL,
	percentageAdjustment_pay decimal(5, 2),
	CONSTRAINT PK_PaymentMethods PRIMARY KEY (id_pay)
)
GO

CREATE TABLE Sales
(
	id_sal INT IDENTITY(1,1) NOT NULL,
	clientId_sal INT NOT NULL,
	workerId_sal INT NOT NULL,
	paymentMethodId_sal INT NOT NULL,
	date_sal datetime NOT NULL,
	total_sal decimal(10, 2) NOT NULL,
	isActive_sal bit default 1 NOT NULL,
	CONSTRAINT PK_Sales PRIMARY KEY (id_sal),
	CONSTRAINT FK_Sales_Clients FOREIGN KEY (clientId_sal) REFERENCES Clients (id_cli),
	CONSTRAINT FK_Sales_Workers FOREIGN KEY (workerId_sal) REFERENCES Workers (id_wor),
	CONSTRAINT FK_Sales_PaymentMethods FOREIGN KEY (paymentMethodId_sal) REFERENCES PaymentMethods (id_pay)
)
GO

CREATE TABLE DetailSales
(
	id_det INT IDENTITY(1,1) NOT NULL,
	saleId_det INT NOT NULL,
	serviceId_det INT NOT NULL,
	quantity_det INT NOT NULL,
	amount_det decimal(10, 2),
	isActive_det bit default 1 NOT NULL,
	CONSTRAINT PK_DetailSales PRIMARY KEY (id_det),
	CONSTRAINT FK_DetailSales_Sales FOREIGN KEY (saleId_det) REFERENCES Sales (id_sal),
	CONSTRAINT FK_DetailSales_Services FOREIGN KEY (serviceId_det) REFERENCES Services (id_ser)
)
GO