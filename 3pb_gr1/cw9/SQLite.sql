-- SQLite
CREATE TABLE Students(
    id INTEGER PRIMARY KEY,
    firstname VARCHAR(50),
    lastname VARCHAR(50),
    birthDay DATE,
    avgRange double
);
INSERT INTO Students(
firstname,lastname,birthDay,
avgRange)
VALUES("Tomasz","Małecki",
"1996-03-23",3.5);