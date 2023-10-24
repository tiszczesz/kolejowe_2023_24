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
        Console.WriteLine("\n\tk - Zakoncz program");

        Console.Write("\n\t\tWybierz opcje ---->  ");
        string? input = Console.ReadLine()?.Trim();
        option = (input!=null && input.Length>0) ? input.ToLower()[0]: ' ';
        switch(option){
            case '1': InsertText();break;
            case '2': ShowAll();break;
            case '3': RemoveFile();break;
        }
    } while (option != 'k');


}

void RemoveFile()
{
    File.Delete(FILENAME);
}

void ShowAll()
{
    if(!File.Exists(FILENAME)){
        Console.WriteLine("  BRAK PLIKU!!!!!");
        return;
    }
    var data = File.ReadAllLines(FILENAME);
    int count = 0;
    foreach(var line in data){
        count++;
        Console.WriteLine($"Linia tekstu nr {count}: {line}");
    }
}

void InsertText()
{
    Console.Write("Podaj tekst: ");
    string? line = Console.ReadLine();
    if(line!=null && line.Trim().Length>0){
        File.AppendAllText(FILENAME,line+Environment.NewLine);
    }
}