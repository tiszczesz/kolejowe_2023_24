/*
        Napisac aplikacje konsolowa operujaca na zbiorze gier
        Game tittle, genre, price, timeInGame, year
        w pliku title;genre;price;.... (CSV)
        funkcjonalnosc jak nizej
        Uzyc klasy Game !!!! tworzyc obiekty
        seralizowac do string
        po pobraniu z pliku deserializacja do obiektu typu Game
*/


Menu();
const string FILENAME = "dane.txt";
void Menu()
{
    char choice = ' ';
    do
    {
        Console.WriteLine(" ========== M E N U ==================\n\n");
        Console.WriteLine("1 - Dodaj nowa linie tekstu");
        Console.WriteLine("2 - Wczytaj caly plik");
        Console.WriteLine("3 - Usun linie tekstu");
        Console.WriteLine("c - usun plik");
        Console.WriteLine("k - zakoncz program");
        Console.Write("\n\tWybierz opcje: --> ");
        string? input = Console.ReadLine()?.Trim();
        choice = (input != null && input.Length > 0) ? input.ToLower()[0] : ' ';
        switch (choice)
        {
            case '1': AddLine(); break;
            case '2': ShowAll(); break;
            case '3': DeleteLine(); break;
            case 'c': ClearFile(); break;
        }
    } while (choice != 'k');


}

void DeleteLine()
{
    if (!File.Exists(FILENAME)) return;
    List<string> dane = File.ReadAllLines(FILENAME).ToList();
    if (dane.Count == 0) return;
    Console.Write($"Numer lini do usuniecia (1,{dane.Count}): ");
    int? number = Convert.ToInt32(Console.ReadLine());
    if (number!=null && (number >= 1 || number <= dane.Count))
    {
         dane.RemoveAt((int)(number - 1));   
         File.WriteAllLines(FILENAME,dane);    
         return;
    }
    Console.WriteLine("ERROR!!!!!");   
}
void AddLine()
{
    Console.WriteLine("Ddoawanie lini");
    Console.Write("dodaj tekst do zapisu: ");
    string? text = Console.ReadLine();
    if (text != null && text.Trim().Length > 0)
    {
        File.AppendAllText(FILENAME, text + Environment.NewLine);
    }
}
void ClearFile()
{
    File.Delete(FILENAME);
}
void ShowAll()
{
    Console.WriteLine("\n\n ----------------------Wszystko wyswietlamy .....");
    if (File.Exists(FILENAME))
    {
        var dane = File.ReadAllLines(FILENAME);
        foreach (var line in dane)
        {
            Console.WriteLine($"\t\t zawartosc pliku: {line}");
        }
    }
    else
    {
        Console.WriteLine("BRAK PLIKU");
    }

}