-- SQLite
CREATE TABLE books(
    id Integer PRIMARY KEY,
    title text,
    author text,
    price double
);
INSERT INTO books(title,author,price)
VALUES("ABC inf.03","Roman Boman",23.78);
INSERT INTO books(title,author,price)
VALUES("Inne ...","Monika Klika",233.78);
INSERT INTO books(title,author,price)
VALUES("Kuchnia polska","Eugeniusz Geniusz",66.78);
INSERT INTO books(title,author,price)
VALUES("Francja zawsze ...","Renata Łódka",45.78);
INSERT INTO books(title,author,price)
VALUES("Tylko tysiąć","Artur Mongoś",23.78);