WITH CustomerSpending AS (
    SELECT 
        C.CustomerID,
        C.FirstName,
        C.LastName,
        SUM(PO.OrderCost) AS TotalSpent
    FROM Customer C
    JOIN PurchaseOrder PO ON C.CustomerID = PO.CustomerID
    GROUP BY C.CustomerID, C.FirstName, C.LastName
)
SELECT *
FROM CustomerSpending
WHERE TotalSpent = (
    SELECT MAX(TotalSpent) FROM CustomerSpending
);
