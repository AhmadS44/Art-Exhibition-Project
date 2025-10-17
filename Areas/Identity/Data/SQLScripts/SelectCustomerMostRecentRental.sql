WITH LatestRental AS (
    SELECT 
        CustomerID,
        RentalDate,
        ROW_NUMBER() OVER (PARTITION BY CustomerID ORDER BY RentalDate DESC) AS rn
    FROM Rental
)
SELECT 
    C.CustomerID,
    C.FirstName,
    C.LastName,
    LR.RentalDate AS MostRecentRental
FROM Customer C
JOIN LatestRental LR ON C.CustomerID = LR.CustomerID
WHERE LR.rn = 1;
