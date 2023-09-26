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
    int[] losowe = new int[10];
    //funkcja ktora wypelni losowymi  0..100 wartosciami ta tablice

    FillArray(losowe);
    ShowArray(losowe);
    int max = getMax(losowe);
    void FillArray(int[] contener)
    {

    }
    void ShowArray(int[] contener)
    {
        foreach (var item in contener)
        {
            Console.WriteLine(item);
        }
    }
    int getMax(int[] data)
    {
        return 0;
    }
}
//Ex1();
Ex2();



