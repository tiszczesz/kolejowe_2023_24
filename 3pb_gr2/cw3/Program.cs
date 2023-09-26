void Ex1()
{
    string[] imiona = { "Anna", "Joanna", "Tomasz" };
    foreach (var item in imiona)
    {
        Console.WriteLine(item);
    }
    imiona[imiona.Length - 1] = "Roman";
    Console.WriteLine($"Rozmiar: {imiona.Length}");
    foreach (var item in imiona)
    {
        Console.WriteLine(item);
    }
}
void Ex2()
{
    Console.Write("Podaj rozmiar tablicy: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] losowe = new int[size];
    //funkcja ktora wypelni losowymi  -100..100 wartosciami ta tablice

    FillArray(losowe);
    ShowArray(losowe);
    Console.WriteLine($"Max w tablicy: {max(losowe)}");
    Console.WriteLine($"Min w tablicy: {min(losowe)}");
    Console.WriteLine($"Min w tablicy: {losowe.Min()}");
    Console.WriteLine($"Max w tablicy: {losowe.Max()}");
    Console.WriteLine($"Sum w tablicy: {losowe.Sum()}");
    Console.WriteLine($"Average w tablicy: {losowe.Average()}");

    int max(int[] t){
        if(t.Length==0) throw new FormatException(message:"Tablica pusta");
        int m = t[0];
        foreach(var elem in t){
            if(elem>m) m=elem;
        }  
        return m;      
    }
   int min(int[] t){
        if(t.Length==0) throw new FormatException(message:"Tablica pusta");
        int m = t[0];
        foreach(var elem in t){
            if(elem<m) m=elem;
        }
         return m;  
    }
    void FillArray(int[] container)
    {
        Random rnd = new Random();
        for(int i=0;i<container.Length;i++){
            container[i]= rnd.Next(-100,101);
        }
    }
    void ShowArray(int[] container)
    {
        foreach (var item in container)
        {
            Console.Write(item+" ");
        }
         Console.WriteLine();
    }
    int getMax(int[] data)
    {
        return 0;
    }
}
//Ex1();
Ex2();



