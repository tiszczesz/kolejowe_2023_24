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
        Console.WriteLine("c - usun plik");
        Console.WriteLine("k - zakoncz program");
        Console.Write("\n\tWybierz opcje: --> ");
        string? input = Console.ReadLine()?.Trim();
        choice = (input != null && input.Length > 0) ? input.ToLower()[0] : ' ';
        switch (choice)
        {
            case '1': AddLine(); break;
            case '2': ShowAll(); break;
            case 'c': ClearFile(); break;
        }
    } while (choice != 'k');


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
void ClearFile(){
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
    else{
        Console.WriteLine("BRAK PLIKU");
    }

}