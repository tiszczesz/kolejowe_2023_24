
void Ex1()
{
    List<int> numbers = new List<int>();
    numbers.Add(34);
    numbers.Add(12);
    numbers.Add(67);
    numbers.Insert(2, 9999);
    Show(numbers);
    numbers.RemoveAt(1);
    Show(numbers);
}
void Show<T>(List<T> dane){
    foreach (var elem in dane)    {
        Console.Write(elem + " ");
    }
    Console.WriteLine();
}
void Ex2(){
    //utworzenie listy stringow List<string> imiona
    List<string> imiona = new List<string>();
    //napisanie funkcji ktora dodaje do listy imion kolejne element 
    AddFirstname(imiona);
    // Podaj imie   az do momentu napisania null
    //co konczy wstawianie
    //wyswietlenie listy Show(imiona)
    Show(imiona);
    var h = imiona.Count;
}

void AddFirstname(List<string> imiona){
    string? tekst;
    do{
        Console.Write($"Podaj imie (null konczy): ");
        tekst = Console.ReadLine()?.Trim().ToLower();
        if(tekst!=null && tekst.Length!=0 && tekst!="null"){
            imiona.Add(tekst);
        }
    }while(tekst!="null");
}
void InsertPenultimate (List<string> imiona,string toInsert="Przedostatni"){
  //todo
}

//Ex1();
Ex2();
