### Utworzyć aplikację React
1. Zainstalować bootstrap
2. Zaimportować bootstrap w App.tsx
3. Utworzyć plik books.ts
   1. wyeksportować liste książek około 6
      1. tytul
      2. autor
      3. cena
      4. rok wydania
      5. ewentualnie obrazek (jakiś placeholder)
   2. wyeksportować interface Book
4. Utworzyć katalog components
5. W tym katalogu stworzyć komponent Book
   1. komponent generuje informacje o książce na podstawie dostarczonych danych props
6. W App.tsx wyrenderować liste komponentów Book w oparciu o liste książek z pliku books.ts