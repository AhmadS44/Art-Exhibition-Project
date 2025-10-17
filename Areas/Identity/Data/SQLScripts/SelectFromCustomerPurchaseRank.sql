SELECT 
    C.CustomerID,
    C.FirstName + ' ' + C.LastName AS CustomerName,
    COUNT(PO.PurchaseOrderID) AS TotalOrders,
    RANK() OVER (ORDER BY COUNT(PO.PurchaseOrderID) DESC) AS OrderRank
FROM Customer C
JOIN PurchaseOrder PO ON C.CustomerID = PO.CustomerID
GROUP BY C.CustomerID, C.FirstName, C.LastName;
