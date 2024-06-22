-- Active: 1719013135641@@riwi.database.windows.net@1433@luegopago

--trigger para la taba coupons campo CreateBy(Id de la tabla MarketingUser)
CREATE TRIGGER CheckUses
ON Coupons
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON
    INSERT INTO Coupons (Code, Name, Description, StartDate, EndDate, DiscountType, DiscountValue, UsageLimit, MinPurchaseAmount, MaxPurchaseAmount, CustomerId, Status, CreatedBy)
    SELECT Code, Name, Description, StartDate, EndDate, DiscountType, DiscountValue, 
           CASE WHEN UsageLimit < 0 THEN 0 ELSE UsageLimit END, 
           MinPurchaseAmount, MaxPurchaseAmount, CustomerId, Status, CreatedBy
    FROM inserted
END

INSERT INTO Coupons (Code, Name, Description, StartDate, EndDate, DiscountType, DiscountValue, MinPurchaseAmount, MaxPurchaseAmount, CustomerId, Status, CreatedBy)
VALUES ('TEST2024', 'Test Coupon', 'This is a test coupon', '2024-01-01', '2024-12-31', 'PERCENTAGE', 10.00, 100.00, 500.00, 1, 'ACTIVE', 1);

-- Verificar los resultados
SELECT * FROM Coupons;