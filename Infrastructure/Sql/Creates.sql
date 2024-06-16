-- Active: 1718495108140@@bwlr7jnitlvizuosnvq6-mysql.services.clever-cloud.com@3306
CREATE TABLE Brand(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(45) UNIQUE NOT NULL,
    Nit VARCHAR(45) UNIQUE NOT NULL,
    Country VARCHAR(45) NOT NULL,
    City VARCHAR(45) NOT NULL,
    WebSite VARCHAR(255) UNIQUE NOT NULL,
    Status ENUM('ACTIVE', 'INACTIVE') DEFAULT 'ACTIVE',
    CreatedAt TIMESTAMP
);

CREATE TABLE MarketplaceUser(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserName VARCHAR(45) UNIQUE NOT NULL,
    Password VARCHAR(45) NOT NULL,
    Email VARCHAR(150) UNIQUE NOT NULL,
    BrandId INT NOT NULL,
    Status ENUM('ACTIVE', 'INACTIVE') DEFAULT 'ACTIVE',
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY(BrandId) REFERENCES Brand(Id)
);

CREATE TABLE Purchase(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserId INT NOT NULL,
    Date DATE NOT NULL,
    Amount DOUBLE,
    FOREIGN KEY(UserId) REFERENCES MarketplaceUser(Id)
);

CREATE TABLE MarketingUser (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserName VARCHAR(45) UNIQUE NOT NULL,
    Password VARCHAR(45) NOT NULL,
    Email VARCHAR(200) UNIQUE NOT NULL
);

CREATE TABLE Role (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(200) NOT NULL
);

CREATE TABLE UserRole (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    UserId INT,
    RoleId INT,
    FOREIGN KEY(UserId) REFERENCES MarketingUser(Id),
    FOREIGN KEY(RoleId) REFERENCES Role(Id)
);

 CREATE TABLE Customers (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    TypeDocument VARCHAR(45),
    NumDocument VARCHAR(20),
    Name VARCHAR (45) NOT NULL,
    LastName VARCHAR(45) NOT NULL,
    Phone VARCHAR (11) NOT NULL,
    Email VARCHAR (200) NOT NULL,
    UNIQUE(TypeDocument, NumDocument)
 );

CREATE TABLE Coupon (
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
);

CREATE TABLE PurchaseCoupon(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    PurchaseId INT NOT NULL,
    CouponId INT NOT NULL,
    FOREIGN KEY(PurchaseId) REFERENCES Purchase(Id),
    FOREIGN KEY(CouponId) REFERENCES Coupon(Id)
);

CREATE TABLE BrandCoupon(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    BrandId INT NOT NULL,
    CouponId INT NOT NULL,
    FOREIGN KEY (BrandId) REFERENCES Brand(Id),
    FOREIGN KEY (CouponId) REFERENCES Coupon(Id)
);

CREATE TABLE CouponUsage (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    CouponId INT NOT NULL,
    UserId INT NOT NULL,
    UsageDate DATE,
    TransactionAmount DOUBLE
);

CREATE TABLE CouponHistory(
    Id INT PRIMARY KEY AUTO_INCREMENT,
    CouponId INT NOT NULL,
    ChangeDate DATE,
    FieldChanged VARCHAR(200),
    OldValue VARCHAR (200),
    NewValue VARCHAR  (200)
);

