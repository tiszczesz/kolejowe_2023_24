-- SQLite
CREATE TABLE Games(
    Id Integer PRIMARY KEY,
    Title VARCHAR(50),
    Genre VARCHAR(50),
    Year INTEGER,
    Price DECIMAL(10,2)
);
INSERT INTO 
 Games(Title,Genre,Year,Price)
VALUES("Wiedźmin 2","RPG",2009,34.99);
INSERT INTO 
 Games(Title,Genre,Year,Price)
VALUES("Wiedźmin","RPG",2006,12.99);
INSERT INTO 
 Games(Title,Genre,Year,Price)
VALUES("FIFA 2020","Sportowa",2020,67.99);
INSERT INTO 
 Games(Title,Genre,Year,Price)
VALUES("Diablo 4","RPG",2023,230);