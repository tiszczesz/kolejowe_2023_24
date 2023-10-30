

Node.js to platforma oprogramowania, która umożliwia tworzenie aplikacji internetowych przy użyciu języka JavaScript. Aby połączyć się z bazą danych MySQL z Node.js, musisz zainstalować odpowiedni moduł lub bibliotekę, która zapewnia interfejs do komunikacji z serwerem bazy danych. Istnieje kilka opcji do wyboru, takich jak:

- [mysql](^1^) - to oficjalny sterownik MySQL dla Node.js, który jest prosty i szybki w użyciu. Możesz go zainstalować za pomocą polecenia `npm install mysql`¹.
- [mysql2](^2^) - to alternatywny sterownik MySQL dla Node.js, który jest kompatybilny z modułem mysql, ale oferuje dodatkowe funkcje, takie jak obsługa Promise, obsługa połączeń puli i obsługa typów danych JSON². Możesz go zainstalować za pomocą polecenia `npm install mysql2`².
- [sequelize](^3^) - to popularny ORM (Object-Relational Mapping) dla Node.js, który umożliwia definiowanie modeli danych i wykonywanie zapytań SQL za pomocą metod JavaScript. Obsługuje wiele baz danych, w tym MySQL³. Możesz go zainstalować za pomocą polecenia `npm install sequelize`³.

Oto prosty przykład kodu Node.js, który pokazuje, jak połączyć się z bazą danych MySQL przy użyciu modułu mysql i wykonać prosty zapytanie:

```javascript
// Zaimportuj moduł mysql
const mysql = require('mysql');

// Utwórz obiekt połączenia
const connection = mysql.createConnection({
  host: 'localhost', // adres serwera bazy danych
  user: 'root', // nazwa użytkownika bazy danych
  password: '1234', // hasło użytkownika bazy danych
  database: 'test' // nazwa bazy danych
});

// Otwórz połączenie
connection.connect((err) => {
  if (err) {
    console.error('Błąd: ' + err.message);
    return;
  }
  console.log('Połączono z serwerem MySQL.');
});

// Wykonaj zapytanie SQL
connection.query('SELECT * FROM users', (err, results, fields) => {
  if (err) {
    console.error('Błąd: ' + err.message);
    return;
  }
  // Wyświetl wyniki
  console.log(results);
});

// Zamknij połączenie
connection.end((err) => {
  if (err) {
    console.error('Błąd: ' + err.message);
    return;
  }
  console.log('Zamknięto połączenie z serwerem MySQL.');
});
```

Mam nadzieję, że to Ci pomoże. Jeśli masz jakieś pytania lub chcesz, żebym wygenerował inny rodzaj treści, daj mi znać. 😊

Źródło: Konwersacja za pomocą usługi Bing, 30.10.2023
(1) Jak zainstalować i połączyć się z bazą danych MySQL w Node JS w .... https://jaktosie.pl/jak-zainstalowac-i-polaczyc-sie-z-baza-danych-mysql-w-node-js-w-systemie-linux/.
(2) Jak zainstalować i połączyć się z bazą danych MySQL w Node JS w .... https://jaktosie.pl/jak-zainstalowac-i-polaczyc-sie-z-baza-danych-mysql-w-node-js-w-systemie-linux/.
(3) Połączenie do Bazy Danych MySQL z NodeJS | HyperOne. https://www.hyperone.com/services/storage/database/tutorials/node-mysql2.html.
(4) Połączenie do Bazy Danych MySQL z NodeJS | HyperOne. https://www.hyperone.com/services/storage/database/tutorials/node-mysql2.html.
(5) Jak zainstalować i połączyć się z bazą danych MySQL w Node JS w .... https://bing.com/search?q=nodejs+mysql+po%c5%82%c4%85czenie.
(6) Jak zainstalować i połączyć się z bazą danych MySQL w Node JS w .... https://bing.com/search?q=nodejs+mysql+po%c5%82%c4%85czenie.
(7) Node.js MySQL - W3Schools. https://www.w3schools.com/nodejs/nodejs_mysql.asp.