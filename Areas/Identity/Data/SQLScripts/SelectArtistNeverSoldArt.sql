SELECT AR.ArtistID, AR.FirstName, AR.LastName
FROM Artist AR
WHERE NOT EXISTS (
    SELECT 1
    FROM Art A
    LEFT JOIN PurchaseOrder PO ON A.ArtID = PO.ArtID
    LEFT JOIN Rental R ON A.ArtID = R.ArtID
    WHERE A.ArtistID = AR.ArtistID AND (PO.PurchaseOrderID IS NOT NULL OR R.RentalID IS NOT NULL)
);
