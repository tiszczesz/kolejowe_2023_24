-- SQLite
CREATE table Clients(
    id Integer PRIMARY KEY,
    firstname text,
    lastname text,
    price real
)

INSERT INTO Clients(firstname,lastname,price)
VALUES("Jan","Nowak",3400);
INSERT INTO Clients(firstname,lastname,price)
VALUES("Monika","Małecka",2300);
INSERT INTO Clients(firstname,lastname,price)
VALUES("Roman","Boman",1200);
INSERT INTO Clients(firstname,lastname,price)
VALUES("Tomasz","Bomasz",23.90);
INSERT INTO Clients(firstname,lastname,price)
VALUES("Martyna","Sprężyna",7800);
INSERT INTO Clients(firstname,lastname,price)
VALUES("Grażyna","Klima",19.00);
INSERT INTO Clients(firstname,lastname,price)
VALUES("Jerzy","Świeży",23.99);