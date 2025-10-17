SELECT 
    ArtID, 
    Title, 
    Price
FROM Art
WHERE Price > (
    SELECT AVG(Price) FROM Art
);
