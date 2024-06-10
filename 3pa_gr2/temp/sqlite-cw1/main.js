// const  express =  require('express');
// const sqlite3 = require('sqlite3').verbose();
import express from 'express';
import sqlite3 from 'sqlite3';
const app = express();
const port = 3000;
// Połączenie z bazą danych SQLite
const db = new sqlite3.Database('mydb.db');
// Pobieranie danych z tabeli persons
app.get('/persons', (req, res) => {
    db.all('SELECT id, firstname, lastname, age FROM persons', (err, rows) => {
        if (err) {
            res.status(500).json({ error: 'Błąd serwera' });
        }
        else {
            res.json(rows);
        }
    });
});
app.get('/', (req, res) => {
    res.json({ "info": "użyj http://localhost:3000/persons" });
});
app.listen(port, () => {
    console.log(`Serwer działa na porcie ${port}`);
});
