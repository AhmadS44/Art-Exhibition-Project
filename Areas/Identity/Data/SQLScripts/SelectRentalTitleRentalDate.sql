SELECT 
    R.RentalID,
    A.Title AS ArtTitle,
    R.RentalDate,
    R.RentalFinishDate
FROM Rental R
JOIN Art A ON R.ArtID = A.ArtID
ORDER BY R.RentalDate;
