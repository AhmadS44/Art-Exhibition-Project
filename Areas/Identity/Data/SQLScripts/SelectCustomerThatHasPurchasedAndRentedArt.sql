SELECT 
    C.CustomerID,
    C.FirstName,
    C.LastName
FROM Customer C
WHERE EXISTS (
    SELECT 1 FROM PurchaseOrder PO WHERE PO.CustomerID = C.CustomerID
)
AND EXISTS (
    SELECT 1 FROM Rental R WHERE R.CustomerID = C.CustomerID
);
