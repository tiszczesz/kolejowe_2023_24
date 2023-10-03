void Ex1(){
    List<int> numbers = new List<int>(); //pusta lista liczb calkowitych
    Console.WriteLine($"Rozmiar listy: {numbers.Count}");
    numbers.Add(34);
    numbers.Add(0);
    numbers.Add(-12);
    numbers.Add(0);
    numbers.Add(77);
    Console.WriteLine($"Rozmiar listy: {numbers.Count}");
   // ShowList<int>(numbers);
    ShowList(numbers);
    numbers.Insert(2,-9999);
    ShowList(numbers);
    numbers.RemoveAt(1);
    ShowList(numbers);    
    numbers.RemoveAll((elem)=>elem==0);
    ShowList(numbers);
    List<string> words = new List<string>{"sfsdfsf","ggggg","ooooo","zzzzz"};
    ShowList(words);
    words[2] = "22222222222222222";
    ShowList(words);
    words.Reverse();
    ShowList(words);
}
void ShowList<T>(List<T> data){
    foreach(T e in data){
        Console.Write(e+" ");
    }
    Console.WriteLine();
}
Ex1();
