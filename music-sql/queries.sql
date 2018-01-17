SELECT * FROM Genre;

SELECT * FROM Artist;

INSERT INTO Artist (ArtistId, ArtistName, YearEstablished)
VALUES (null, 'Ween', 1988);

INSERT INTO Album (AlbumId, Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId)
VALUES (null, 'Quebec', '8/05/2003', 2724, 'Electra', 28, 2);

INSERT INTO Song (SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES (null,'Its gonna be a long night', 202, '8/05/2003', 2, 28, 23);

INSERT INTO Song (SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES (null,'The Argus', 312, '8/05/2003', 2, 28, 23);

SELECT 
s.Title as songTitle, 
a.Title as albumTitle ,
ar.ArtistName as artistName
FROM 
Song s
LEFT JOIN Album a ON
s.AlbumId = a.AlbumId
LEFT JOIN Artist ar ON
s.ArtistId = ar.ArtistId
WHERE s.ArtistId = 28;

SELECT a.Title as albumTitle,
Count(*) as songCount
FROM Album a
LEFT JOIN Song s ON
s.AlbumId = a.AlbumID
Group by a.Title;

Select ar.ArtistName as artistName,
Count(*) as songCount
From Artist ar
LEFT JOIN Song s ON
s.ArtistId = ar.ArtistId
Group by ar.ArtistName;

Select g.Label as genreName,
Count(*) as songCount
From Genre g
LEFT JOIN Song s ON
s.GenreId = g.GenreId
Group by g.Label;

Select a.Title as albumTitle,
MAX(a.AlbumLength) as albumDuration
From Album a;

Select s.Title as songTitle,
MAX(s.SongLength) as songDuration,
a.Title as albumTitle
From Song s
LEFT JOIN Album a ON
s.AlbumId = a.AlbumId;

