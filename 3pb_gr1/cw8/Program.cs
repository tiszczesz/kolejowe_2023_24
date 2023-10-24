const string FILENAME = "dane.txt";

Menu();

void Menu()
{
    char option = ' ';
    do
    {
        Console.WriteLine("   ========= MEMU ==============\n\n");
        Console.WriteLine("\t1 - Dopisz do pliku");
        Console.WriteLine("\t2 - Wyswietl zawartosc pliku");
        Console.WriteLine("\t3 - Usun plik");
        Console.WriteLine("\t4 - Usun linie tekstu");
        Console.WriteLine("\n\tk - Zakoncz program");

        Console.Write("\n\t\tWybierz opcje ---->  ");
        string? input = Console.ReadLine()?.Trim();
        option = (input != null && input.Length > 0) ? input.ToLower()[0] : ' ';
        switch (option)
        {
            case '1': InsertText(); break;
            case '2': ShowAll(); break;
            case '3': RemoveFile(); break;
            case '4': RemoveLine(); break;
        }
    } while (option != 'k');


}

void RemoveLine()
{
    if (!File.Exists(FILENAME))
    {
        Console.WriteLine("  BRAK PLIKU!!!!!");
        return;
    }
    List<string> data = File.ReadAllLines(FILENAME).ToList();
    if (data.Count == 0)
    {
        Console.WriteLine("  PLIK PUSTU!!!!!");
        return;
    }
    Console.Write($"Podaj numer lini do usuniecia (1,{data.Count})");
    //todo try catch
    try
    {
        int numer = Convert.ToInt32(Console.ReadLine());
        if (numer < 1 || numer > data.Count)
        {
            Console.WriteLine("  Bledny numer lini!!!!!");
            return;
        }
        data.RemoveAt(numer - 1);
        if (data.Count > 0)
        {
            File.WriteAllLines(FILENAME, data);
        }
        else
        {
            File.Delete(FILENAME);
        }
    }catch(FormatException ex){
        Console.WriteLine("ERROR: "+ex.Message);
    }
}

void RemoveFile()
{
    File.Delete(FILENAME);
}

void ShowAll()
{
    if (!File.Exists(FILENAME))
    {
        Console.WriteLine("  BRAK PLIKU!!!!!");
        return;
    }
    var data = File.ReadAllLines(FILENAME);
    int count = 0;
    foreach (var line in data)
    {
        count++;
        Console.WriteLine($"Linia tekstu nr {count}: {line}");
    }
}

void InsertText()
{
    Console.Write("Podaj tekst: ");
    string? line = Console.ReadLine();
    if (line != null && line.Trim().Length > 0)
    {
        File.AppendAllText(FILENAME, line + Environment.NewLine);
    }
}