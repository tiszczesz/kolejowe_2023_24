-- SQLite
CREATE TABLE Films(
    Id Integer PRIMARY KEY,
    Title Text,
    Director Text,
    Language Text,
    Date Text,
    Price Real
);

-- Tabela "Filmy"
INSERT INTO Filmy (Id, Title, Director, Language, Date, Price)
VALUES
  (1, 'Inception', 'Christopher Nolan', 'English', '2010-07-16', 12.99),
  (2, 'Pulp Fiction', 'Quentin Tarantino', 'English', '1994-10-14', 9.99),
  (3, 'The Shawshank Redemption', 'Frank Darabont', 'English', '1994-09-23', 11.49),
  (4, 'The Dark Knight', 'Christopher Nolan', 'English', '2008-07-18', 14.99),
  (5, 'Forrest Gump', 'Robert Zemeckis', 'English', '1994-07-06', 10.79),
  (6, 'The Matrix', 'Lana Wachowski, Lilly Wachowski', 'English', '1999-03-31', 8.99),
  (7, 'Gladiator', 'Ridley Scott', 'English', '2000-05-05', 9.49),
  (8, 'Titanic', 'James Cameron', 'English', '1997-12-19', 13.29),
  (9, 'Avatar', 'James Cameron', 'English', '2009-12-18', 12.99),
  (10, 'Jurassic Park', 'Steven Spielberg', 'English', '1993-06-11', 7.99);
