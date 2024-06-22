-- Active: 1719013135641@@riwi.database.windows.net@1433@luegopago

--codigo mysql
/*
CREATE TABLE Brands(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(45) UNIQUE NOT NULL,
    Nit VARCHAR(45) UNIQUE NOT NULL,
    Country VARCHAR(45) NOT NULL,
    City VARCHAR(45) NOT NULL,
    WebSite VARCHAR(255) UNIQUE NOT NULL,
    Status ENUM('ACTIVE', 'INACTIVE') DEFAULT 'ACTIVE',
    CreatedAt TIMESTAMP
);
*/
--codigo sql server
CREATE TABLE Brands (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(45) UNIQUE NOT NULL,
    Nit NVARCHAR(45) UNIQUE NOT NULL,
    Country NVARCHAR(45) NOT NULL,
    City NVARCHAR(45) NOT NULL,
    WebSite NVARCHAR(255) UNIQUE NOT NULL,
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE',
    CreatedAt DATETIME DEFAULT GETDATE()
);

ALTER TABLE Brands
ADD CONSTRAINT chk_status CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--codigo mysql
/* CREATE TABLE MarketplaceUsers(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserName VARCHAR(45) UNIQUE NOT NULL,
    Password VARCHAR(45) NOT NULL,
    Email VARCHAR(150) UNIQUE NOT NULL,
    BrandId INT NOT NULL,
    Status ENUM('ACTIVE', 'INACTIVE') DEFAULT 'ACTIVE',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY(BrandId) REFERENCES Brand(Id)
); */

--codigo sql
CREATE TABLE MarketplaceUsers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(45) UNIQUE NOT NULL,
    Password NVARCHAR(45) NOT NULL,
    Email NVARCHAR(200) UNIQUE NOT NULL,
    BrandId INT NOT NULL,
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE',
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY(BrandId) REFERENCES Brand(Id)
);

ALTER TABLE MarketplaceUsers
ADD CONSTRAINT statusMarketplaceUser CHECK (Status IN ('ACTIVE', 'INACTIVE'));


--Codigo mysql
/* CREATE TABLE Purchases(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserId INT NOT NULL,
    Date DATE NOT NULL,
    Amount DOUBLE,
    FOREIGN KEY(UserId) REFERENCES MarketplaceUser(Id)
); */

--codigo sql
CREATE TABLE Purchases (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    Date DATE NOT NULL,
    Amount FLOAT,
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE',
    FOREIGN KEY(UserId) REFERENCES MarketplaceUser(Id)
);

ALTER TABLE Purchases
ADD CONSTRAINT statusPurchase CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo mysql

/* CREATE TABLE MarketingUsers (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserName VARCHAR(45) UNIQUE NOT NULL,
    Password VARCHAR(45) NOT NULL,
    Email VARCHAR(200) UNIQUE NOT NULL
); */

--codigo sql
CREATE TABLE MarketingUsers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(45) UNIQUE NOT NULL,
    Password NVARCHAR(45) NOT NULL,
    Email NVARCHAR(200) UNIQUE NOT NULL,
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE',
    CreatedAt DATETIME DEFAULT GETDATE()
);

ALTER TABLE MarketingUsers
ADD CONSTRAINT statusMarketingUser CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo Mysql
/* CREATE TABLE Roles (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(200) NOT NULL
); */

--codigo sql
CREATE TABLE Roles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(200) NOT NULL,
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE'
);

ALTER TABLE Roles
ADD CONSTRAINT statusRole CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo mysql

/* CREATE TABLE UserRoles (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserId INT,
    RoleId INT,
    FOREIGN KEY(UserId) REFERENCES MarketingUser(Id),
    FOREIGN KEY(RoleId) REFERENCES Role(Id)
); */

--codigo sql
CREATE TABLE UserRoles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT,
    RoleId INT,
    FOREIGN KEY(UserId) REFERENCES MarketingUser(Id),
    FOREIGN KEY(RoleId) REFERENCES Role(Id),
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE',
);


ALTER TABLE UserRoles
ADD CONSTRAINT statusUserRole CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo mysql
/*  CREATE TABLE Customers (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TypeDocument VARCHAR(45),
    NumDocument VARCHAR(20),
    Name VARCHAR (45) NOT NULL,
    LastName VARCHAR(45) NOT NULL,
    Phone VARCHAR (11) NOT NULL,
    Email VARCHAR (200) NOT NULL,
    UNIQUE(TypeDocument, NumDocument)
 ); */

 --codigo sql
 CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TypeDocument NVARCHAR(45),
    NumDocument NVARCHAR(20),
    Name NVARCHAR(45) NOT NULL,
    LastName NVARCHAR(45) NOT NULL,
    Phone NVARCHAR(11) NOT NULL,
    Email NVARCHAR(200) NOT NULL,
    UNIQUE(TypeDocument, NumDocument),
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE'
);

ALTER TABLE Customers
ADD CONSTRAINT statusCustomers CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo mysql
/* CREATE TABLE Coupons (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Code VARCHAR(125) NOT NULL,
    Name VARCHAR(45) NOT NULL,
    Description TEXT,
    StartDate DATE,
    EndDate DATE,
    DiscountType ENUM("PERCENTAGE", "FIXED") NOT NULL,
    DiscountValue DOUBLE NOT NULL,
    UsageLimit INT,
    MinPurchaseAmount DOUBLE,
    MaxPurchaseAmount DOUBLE,
    CustomerId INT NOT NULL,
    Status ENUM('ACTIVE', 'INACTIVE') DEFAULT 'ACTIVE',
    CreatedBy INT,
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CreatedBy) REFERENCES MarketingUser(Id),
    FOREIGN KEY(CustomerId) REFERENCES Customers(Id)
); */

--codigo sql
CREATE TABLE Coupons (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Code NVARCHAR(125) NOT NULL,
    Name NVARCHAR(45) NOT NULL,
    Description NVARCHAR(MAX),
    StartDate DATE,
    EndDate DATE,
    DiscountType NVARCHAR(10) NOT NULL,
    DiscountValue FLOAT NOT NULL,
    UsageLimit INT,
    MinPurchaseAmount FLOAT,
    MaxPurchaseAmount FLOAT,
    CustomerId INT NOT NULL,
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE',
    CreatedBy INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CreatedBy) REFERENCES MarketingUser(Id),
    FOREIGN KEY(CustomerId) REFERENCES Customers(Id)
);

ALTER TABLE Coupons
ADD CONSTRAINT statusCoupons CHECK (Status IN ('ACTIVE', 'INACTIVE'));

ALTER TABLE Coupons
ADD CONSTRAINT discountType CHECK (DiscountType IN ('PERCENTAGE', 'FIXED'));

--Codigo mysql
/* CREATE TABLE PurchaseCoupons(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    PurchaseId INT NOT NULL,
    CouponId INT NOT NULL,
    FOREIGN KEY(PurchaseId) REFERENCES Purchase(Id),
    FOREIGN KEY(CouponId) REFERENCES Coupons(Id)
); */

--codigo sql


CREATE TABLE PurchaseCoupons(
    Id INT PRIMARY KEY IDENTITY(1,1),
    PurchaseId INT NOT NULL,
    CouponId INT NOT NULL,
    FOREIGN KEY(PurchaseId) REFERENCES Purchase(Id),
    FOREIGN KEY(CouponId) REFERENCES Coupons(Id),
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE'
);

ALTER TABLE PurchaseCoupons
ADD CONSTRAINT statusPurchaseCoupons CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo mysql
/* CREATE TABLE BrandCoupons(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    BrandId INT NOT NULL,
    CouponId INT NOT NULL,
    FOREIGN KEY (BrandId) REFERENCES Brand(Id),
    FOREIGN KEY (CouponId) REFERENCES Coupon(Id)
); */

--codigo sql
CREATE TABLE BrandCoupons (
    Id INT PRIMARY KEY IDENTITY(1,1),
    BrandId INT NOT NULL,
    CouponId INT NOT NULL,
    FOREIGN KEY (BrandId) REFERENCES Brand(Id),
    FOREIGN KEY (CouponId) REFERENCES Coupons(Id),
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE'
);
ALTER TABLE BrandCoupons
ADD CONSTRAINT statusBrandCoupon CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--Codigo mysql
/* CREATE TABLE CouponUsages (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    CouponId INT NOT NULL,
    UserId INT NOT NULL,
    UsageDate DATE,
    TransactionAmount DOUBLE,
    FOREIGN KEY(CouponId) REFERENCES Coupons(Id),
    FOREIGN KEY(UserId) REFERENCES MarketingUser(Id)
); */

--codigo sql
CREATE TABLE CouponUsages (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CouponId INT NOT NULL,
    UserId INT NOT NULL,
    UsageDate DATE,
    TransactionAmount FLOAT,
    FOREIGN KEY(CouponId) REFERENCES Coupons(Id),
    FOREIGN KEY(UserId) REFERENCES MarketingUser(Id),
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE'
);

ALTER TABLE CouponUsages
ADD CONSTRAINT statusCouponUsages CHECK (Status IN ('ACTIVE', 'INACTIVE'));

--codigo mysql
/* CREATE TABLE CouponHistories(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    CouponId INT NOT NULL,
    ChangeDate DATE,
    FieldChanged VARCHAR(200),
    OldValue VARCHAR (200),
    NewValue VARCHAR  (200),
    FOREIGN KEY(CouponId) REFERENCES Coupons(Id)
);
 */

 --codigo sql
 CREATE TABLE CouponHistories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CouponId INT NOT NULL,
    ChangeDate DATE,
    FieldChanged NVARCHAR(200),
    OldValue NVARCHAR(200),
    NewValue NVARCHAR(200),
    FOREIGN KEY(CouponId) REFERENCES Coupons(Id),
    Status NVARCHAR(10) NOT NULL DEFAULT 'ACTIVE'
);

ALTER TABLE CouponHistories
ADD CONSTRAINT statusCouponHistories CHECK (Status IN ('ACTIVE', 'INACTIVE'));