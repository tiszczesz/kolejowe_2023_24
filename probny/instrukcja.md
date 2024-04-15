# Próbny egzamin inf.04 część aplikacja webowa React z Typescript
1. Zainstaluj aplikacje react z typescriptem:
```console
npx create-react-app egzamin1 --template typescript
//dodaj bootstrap po przejściu do folderu aplikacji
cd egzamin1
npm install bootstrap
```
W razie problemów z instalacją (brak aplikacji create-react-app) doinstalować ją:
```console
    npm i create-react-app
```
1. Wykonaj stronę z listą kursów zawartą w pliku <span style="color:red">kursy.ts</span> w tablece html bootstarp table table-striped
2. Dodaj przycisk zapisz na kurs w wyniku którego stan pola count zwiększy się o jeden gdy nie osiągnięto limitu
3. Gdy limit zostanie osiągnięty kurs zmieni kolor na czerwony z dopiskiem brak miejsc w kolumnie limit
4. Dla ambitnych dodać przycisk rejestracji na dany kurs otwierający formularz z danymi zglaszającego się imię, nazwisko i wybrany kurs (może być pod tabelką lub w okienku modalnym). Po zatwierdzeniu pojawi się komunikat dopisano na kurs (jego nazwa oraz imię i nazwisko zgłaszającego)
5. W miarę możliwości podzielić całą aplikację na kilka komponentów