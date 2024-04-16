-- SQLite
CREATE TABLE MyCars(
    id INTEGER PRIMARY KEY ,    
    model TEXT,
    year INTEGER,
    price INTEGER
);


INSERT INTO MyCars (model, year, price)
VALUES
    ('Toyota Corolla', 2023, 26850),
    ('Skoda Octavia', 2023, 15800),
    ('Toyota Yaris', 2023, 13459),
    ('Toyota Yaris Cross', 2023, 13402),
    ('Kia Sportage', 2023, 12453),
    ('Hyundai Tucson', 2023, 10699),
    ('Toyota C-HR', 2023, 10628),
    ('Dacia Duster', 2023, 9100),
    ('Toyota RAV4', 2023, 8366),
    ('Volkswagen T-Roc', 2023, 7502);