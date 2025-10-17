SELECT 
    AR.ArtistID, 
    AR.FirstName + ' ' + AR.LastName AS ArtistName, 
    COUNT(A.ArtID) AS ArtCount
FROM Artist AR
LEFT JOIN Art A ON AR.ArtistID = A.ArtistID
GROUP BY AR.ArtistID, AR.FirstName, AR.LastName;
