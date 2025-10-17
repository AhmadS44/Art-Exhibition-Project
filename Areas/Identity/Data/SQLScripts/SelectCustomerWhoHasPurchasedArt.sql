SELECT DISTINCT
    C.CustomerID,
    C.FirstName,
    C.LastName
FROM Customer C
JOIN PurchaseOrder PO ON C.CustomerID = PO.CustomerID;
