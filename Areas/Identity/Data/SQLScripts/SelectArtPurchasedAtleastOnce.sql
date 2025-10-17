SELECT 
    A.ArtID,
    A.Title,
    COUNT(PO.PurchaseOrderID) AS TimesPurchased
FROM Art A
JOIN PurchaseOrder PO ON A.ArtID = PO.ArtID
GROUP BY A.ArtID, A.Title;
