-- Insertar primera marca
INSERT INTO Brand (Name, Nit, Country, City, WebSite, Status)
VALUES ('BrandA', '123456789', 'USA', 'New York', 'http://www.branda.com', 'ACTIVE');

-- Insertar segunda marca
INSERT INTO Brand (Name, Nit, Country, City, WebSite, Status)
VALUES ('BrandB', '987654321', 'Canada', 'Toronto', 'http://www.brandb.com', 'ACTIVE');

-- Insertar tercera marca
INSERT INTO Brand (Name, Nit, Country, City, WebSite, Status)
VALUES ('BrandC', '456789123', 'UK', 'London', 'http://www.brandc.co.uk', 'INACTIVE');

-- Insertar cuarta marca
INSERT INTO Brand (Name, Nit, Country, City, WebSite, Status)
VALUES ('BrandD', '654321987', 'Germany', 'Berlin', 'http://www.brandd.de', 'ACTIVE');

-- Insertar quinta marca
INSERT INTO Brand (Name, Nit, Country, City, WebSite, Status)
VALUES ('BrandE', '321654987', 'France', 'Paris', 'http://www.brande.fr', 'INACTIVE');


-- Insertar usuarios en la tabla MarketplaceUser
INSERT INTO MarketplaceUser (UserName, Password, Email, BrandId, Status)
VALUES 
('user1', 'password1', 'user1@example.com', 1, 'ACTIVE'),
('user2', 'password2', 'user2@example.com', 2, 'ACTIVE'),
('user3', 'password3', 'user3@example.com', 3, 'INACTIVE'),
('user4', 'password4', 'user4@example.com', 4, 'ACTIVE'),
('user5', 'password5', 'user5@example.com', 5, 'INACTIVE');


-- Insertar compras en la tabla Purchase
INSERT INTO Purchase (UserId, Date, Amount)
VALUES 
(1, '2023-01-15', 150.00),
(2, '2023-02-20', 200.50),
(3, '2023-03-25', 300.75),
(4, '2023-04-10', 50.25),
(5, '2023-05-05', 100.00),
(1, '2023-06-12', 75.80),
(2, '2023-07-22', 120.99),
(3, '2023-08-30', 250.45),
(4, '2023-09-15', 350.60),
(5, '2023-10-05', 400.00);


-- Insertar usuarios en la tabla MarketingUser
INSERT INTO MarketingUser (UserName, Password, Email)
VALUES 
('muser1', 'mPassword1', 'muser1@example.com'),
('muser2', 'mPassword2', 'muser2@example.com'),
('muser3', 'mPassword3', 'muser3@example.com'),
('muser4', 'mPassword4', 'muser4@example.com'),
('muser5', 'mPassword5', 'muser5@example.com'),
('muser6', 'mPassword6', 'muser6@example.com'),
('muser7', 'mPassword7', 'muser7@example.com'),
('muser8', 'mPassword8', 'muser8@example.com'),
('muser9', 'mPassword9', 'muser9@example.com'),
('muser10', 'mPassword10', 'muser10@example.com');


-- Insertar roles en la tabla Role
INSERT INTO Role (Name)
VALUES 
('Admin'),
('Manager'),
('Employee'),
('Supervisor'),
('Analyst');

-- Insertar relaciones en la tabla UserRole
INSERT INTO UserRole (UserId, RoleId)
VALUES 
(1, 1),   -- Asignar el primer rol al primer usuario
(2, 2),   -- Asignar el segundo rol al segundo usuario
(3, 3),   -- Asignar el tercer rol al tercer usuario
(4, 2),   -- Asignar el segundo rol al cuarto usuario
(5, 1),   -- Asignar el primer rol al quinto usuario
(6, 4),   -- Asignar el cuarto rol al sexto usuario
(7, 5),   -- Asignar el quinto rol al séptimo usuario
(8, 3),   -- Asignar el tercer rol al octavo usuario
(9, 1),   -- Asignar el primer rol al noveno usuario
(10, 2);  -- Asignar el segundo rol al décimo usuario


-- Insertar clientes en la tabla Customers
INSERT INTO Customers (TypeDocument, NumDocument, Name, LastName, Phone, Email)
VALUES 
('CC', '123456789', 'John', 'Doe', '1234567890', 'john.doe@example.com'),
('TI', '987654321', 'Jane', 'Smith', '9876543210', 'jane.smith@example.com'),
('CC', '456789123', 'Michael', 'Johnson', '4567890123', 'michael.johnson@example.com'),
('CE', '654321987', 'Emma', 'Brown', '6543210987', 'emma.brown@example.com'),
('CC', '321654987', 'David', 'Williams', '3216540987', 'david.williams@example.com');


-- Insertar cupones en la tabla Coupon
INSERT INTO Coupon (Code, Name, Description, StartDate, EndDate, DiscountType, DiscountValue, UsageLimit, MinPurchaseAmount, MaxPurchaseAmount, CustomerId, Status, CreatedBy)
VALUES 
('SUMMER2024', 'Summer Sale', 'Discounts for summer season', '2024-06-15', '2024-08-31', 'PERCENTAGE', 20.00, 100, 0.00, 1000.00, 1, 'ACTIVE', 1),
('FALL2024', 'Fall Promotion', 'Special offers for fall', '2024-09-01', '2024-11-30', 'FIXED', 50.00, 50, 200.00, NULL, 2, 'ACTIVE', 2),
('HOLIDAY2024', 'Holiday Deal', 'Deals for holiday season', '2024-12-01', '2025-01-01', 'PERCENTAGE', 15.00, NULL, 0.00, NULL, 3, 'ACTIVE', 3);


-- Insertar relaciones en la tabla PurchaseCoupon
INSERT INTO PurchaseCoupon (PurchaseId, CouponId)
VALUES 
(1, 1),   -- Asociar la primera compra con el primer cupón
(2, 2),   -- Asociar la segunda compra con el segundo cupón
(3, 3),   -- Asociar la tercera compra con el tercer cupón
(4, 1),   -- Asociar la cuarta compra con el primer cupón
(5, 2);   -- Asociar la quinta compra con el segundo cupón


-- Insertar relaciones en la tabla BrandCoupon
INSERT INTO BrandCoupon (BrandId, CouponId)
VALUES 
(1, 1),   -- Asociar la primera marca con el primer cupón
(2, 2),   -- Asociar la segunda marca con el segundo cupón
(3, 3),   -- Asociar la tercera marca con el tercer cupón
(4, 1),   -- Asociar la cuarta marca con el primer cupón
(5, 2);   -- Asociar la quinta marca con el segundo cupón


-- Insertar registros en la tabla CouponUsage
INSERT INTO CouponUsage (CouponId, UserId, UsageDate, TransactionAmount)
VALUES 
(1, 1, '2024-06-15', 100.00),   -- Uso del cupón 1 por el usuario 1
(2, 2, '2024-06-16', 150.00),   -- Uso del cupón 2 por el usuario 2
(1, 3, '2024-06-17', 200.00),   -- Uso del cupón 1 por el usuario 3
(3, 4, '2024-06-18', 300.00),   -- Uso del cupón 3 por el usuario 4
(2, 5, '2024-06-19', 120.00);   -- Uso del cupón 2 por el usuario 5


-- Insertar registros en la tabla CouponHistory
INSERT INTO CouponHistory (CouponId, ChangeDate, FieldChanged, OldValue, NewValue)
VALUES 
(1, '2024-06-15', 'DiscountType', 'FIXED', 'PERCENTAGE'),   -- Cambio en el tipo de descuento del cupón 1
(2, '2024-06-16', 'DiscountValue', '20.00', '30.00'),       -- Cambio en el valor de descuento del cupón 2
(1, '2024-06-17', 'UsageLimit', '100', '50'),               -- Cambio en el límite de uso del cupón 1
(3, '2024-06-18', 'Status', 'ACTIVE', 'INACTIVE'),          -- Cambio en el estado del cupón 3
(2, '2024-06-19', 'Name', 'Fall Promotion', 'Winter Sale'); -- Cambio en el nombre del cupón 2
