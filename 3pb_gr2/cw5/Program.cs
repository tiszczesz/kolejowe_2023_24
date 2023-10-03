void Ex1(){
    List<int> nums = new List<int>();
    Console.WriteLine($"Rozmiar listy: {nums.Count}");
    nums.Add(34);
    nums.Add(45);
    nums.Add(12);
    nums.Add(0);
    nums.Add(0);
    nums.Add(44);
    Console.WriteLine($"Rozmiar listy: {nums.Count}");
    ShowList(nums);
    nums.Insert(2,9999);
   // ShowList<int>(nums);
    ShowList(nums);
    nums.RemoveAt(3);
    ShowList(nums);
}
void Ex2(){
    //utworzy liste liczb losowych wstawianych kolejno 
    //0 konczy wstawianie i nalezy do listy
    //wyswietli liczby
    int aa = 23545;
    string aaString = aa.ToString();

    // int sum = aaString.Sum(e=>(Char.GetNumericValue(e)));
    // foreach(var e in aaString){
    //     Console.WriteLine((int)(e));
    // }
   // Console.WriteLine(sum);
}

void ShowList<T>(List<T> list){
    foreach(T e in list){
        Console.Write(e+" ");
    }
    Console.WriteLine();
}
//Ex1();
Ex2();