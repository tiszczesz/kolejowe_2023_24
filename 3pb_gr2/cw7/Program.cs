
Ex1();
Ex2();

void Ex2()
{
   // napisac aplikacje generujaca liczby losowe --> List<int>
   // ilosc linii jest ustalona przez uzytkownika
   // kazda linia zapisywana do List lub Array
   // potem zapis do pliku wszystkich linii 
   // kazda linia na koncu po znaku | ma sume liczb 
   // np
   // 2 4 2|8|2 ewentualnie ilosc liczb pierwszych
   // 2|2
   //ilosc liczb w linii jest losowa (np do wylosowania ZERO)
   //na koncu odczyt z pliku i wyswietlenie na ekranie
}
 
 void zadanie(){
    // aplikacja kursy programowania
    // menu
    // 1 utworz kurs  : temat termin cena iloscMiejsc i dopisanie do pliku
    // 2 zobacz kursy : z pliku wyswietli kursy
    // 3 zamknij aplikacje
    // w pliku nazwa; termin;cena;ilosc
    // w pliku nazwa; termin;cena;ilosc
 }
 
 void Ex1()
{
    var data = new List<string>{
    "linia pierwsza",
    "to nie jest nowosc",
    "prawie ostania linia",
    "fdg dfgdfg dfgdg dg "
};
    File.WriteAllLines("data.txt", data);//zapis do pliku
    var wiadro = File.ReadAllLines("data.txt");//odczyt z pliku
    foreach (var line in wiadro)
    {
        Console.WriteLine(line);
    }
}
