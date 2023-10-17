Ex1();

void ShowData(IEnumerable<string>  wiadro)
{
    foreach (string line in wiadro)
    {
        Console.WriteLine(line);
    }
}

Ex2();
void Ex2(){
    //uzytkownik wpisuje z klawiatury teksty liniami
    //tak dlugo az napisze koniec
    //wtedy jest zapis do pliku z listy
    //ewentulnie wyswietlenie odczytanego pliku
}
void Zadanie(){
    //napisac aplikacje z menu
    // film: tytul, rezyser, czas trwania, rok wydania
    //1 - dodaj film  ->tworzenie nowego obiektu film 
    //      i zapisanie do pliku
    //2 - odczyt wszystkich filmow z pliku i wyswietlenie
    //3 -  zakoncz programu
}
void Ex1()
{
    List<string> texts = new List<string>{
    "Dzisiaj zdjecia",
    "jeszcze tylko 2h ze sz...",
    "a z osiem",
    "cos nowego do wiadra"
};
    File.WriteAllLines("dane.txt", texts);//zapis
    var wiadro = File.ReadAllLines("dane.txt");//odczyt
    ShowData(wiadro);
}
