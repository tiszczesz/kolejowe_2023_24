# Informacje wstępne Node

```console 
mkdir katalog
cd katalog
npm init -y  // generowanie package.json
npm i bootstrap
npm i typescript --save-dev
npx tsc -init //generowanie tsconfig.json

npx tsc ewentualna_nazwa_pliku.ts
```
### instalacja react
```console
//jesli jest potrzeba
npm i create-react-app
//ewentualnie
npm -g uninstall create-react-app



npx create-react-app nazwa-aplikacji

//z typescript
npx create-react-app nazwa-aplikacji --template typescript


// potem
cd nazwa-aplikacji
code .
npm i bootstrap
//dodac sciezke do bootstrapa np. App.tsx  
import 'import 'bootstrap/dist/css/bootstrap.min.css';
```