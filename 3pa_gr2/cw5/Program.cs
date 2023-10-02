void Ex1(){
    List<int> numbers = new List<int>();
    numbers.Add(23);
    numbers.Add(56);
    numbers.Add(12);
    //Show<int>(numbers);
    Show(numbers);
    Console.WriteLine(numbers.Count);
    List<string> words = new List<string>(){"ddddd","fdgdgdgdgdg","fffff"};
    words.Insert(2,"nowo_wstawione");
    Show(words);
    words.RemoveAt(3);
    Show(words);
}
void Show<T>(List<T> data){
    foreach(var e in data){
        Console.Write(e+" ");
    }
    Console.WriteLine();
}
void Ex2(){
    //lista kolorow najpierw pusta
    List<string> colors = new();

    //uzytkownik dodaje kolejne kolory i czarny konczy w liscie tylko kolory malymi literami
    AddToColors(colors,"zielony");
    //wyswietlenie listy kolorow
    Show(colors);
}
void AddToColors(List<string> data, string finisher = "czarny"){
    string? color = "";
    do{
        Console.Write($"podaj kolor ({finisher} to koniec): ");
        color = Console.ReadLine()?.Trim().ToLower();
        if(color!=null && color.Length!=0){
            data.Add(color);
        }        
    }while(color!=null && color.Length!=0 && color!=finisher);
}
//Ex1();
Ex2(); 
