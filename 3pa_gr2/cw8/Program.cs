const string FILENAME = "notes.txt";

Menu();

void Menu()
{
    char wybor = ' ';
    do
    {
        Console.WriteLine("\t ======= MOJE GRY ==========\n\n");
        Console.WriteLine("\t1 - Dodaj notatke");
        Console.WriteLine("\t2 - Wyswietl wszystkie notatki");
        Console.WriteLine("\t3 - Usun plik z notatkami");
        Console.WriteLine("\t4 - Usun notatke");
        Console.WriteLine("");
        Console.WriteLine("\tk - Koniec programu");
        Console.Write("\n\t\tWybierz opcje: --> ");
        string? input = Console.ReadLine().Trim();
        wybor = (input!=null && input.Length>0 ) ? input.ToLower()[0]:' ';
        switch(wybor){
            case '1': InsertNote();break;
            case '2': ShowAll();break;
            case '3': ClearAll();break;
            case '4': ClearNote();break;
        }
    } while (wybor != 'k');

}

void ClearNote()
{
    if(!File.Exists(FILENAME)){ 
        Console.WriteLine("  BRAK PLIKU !!!!!!!");   
        return;
    }
       
    List<string> notes = File.ReadAllLines(FILENAME).ToList();
    if(notes.Count>0){
        Console.Write($"Wybierz notatke do usuniecia: (1,{notes.Count}): ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number<1 || number>notes.Count){
            Console.WriteLine("Bedny numer notatki!!!!");
            return;
        }
        notes.RemoveAt(number-1);
        File.WriteAllLines(FILENAME,notes);
    }else{
        Console.WriteLine("Plik pusty");
    }

}

void ClearAll()
{
    File.Delete(FILENAME);
}

void ShowAll()
{
    if(File.Exists(FILENAME)){
        var data = File.ReadAllLines(FILENAME);
        Console.WriteLine("    ----- Zawartosc pliku ------");
        int count=0;
        foreach(var line in data){
            count++;
            Console.WriteLine($"Notatka nr {count}: {line}");
        }
    }else{
        Console.WriteLine("  BRAK PLIKU !!!!!!!");
    }
}

void InsertNote()
{
    Console.Write("PODAJ TRESC NOTATKI: ");
    string? note = Console.ReadLine();
    if(note!=null && note.Trim().Length>0){
        File.AppendAllText(FILENAME,note+Environment.NewLine);
    }
}
