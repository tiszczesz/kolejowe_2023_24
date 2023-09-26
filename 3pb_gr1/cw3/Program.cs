Console.Write("Podaj rozmiar tablicy: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] tab = new int[size];
//tab[5] = 678;
//tab[10] = 9999;
print(tab);
fillArray(tab);
print(tab);
Console.WriteLine($"Suma elementow: {sum(tab)}");
Console.WriteLine($"Srednia elementow: {avg(tab)}");
Console.WriteLine($"Suma elementow: {tab.Sum()}");
Console.WriteLine($"Srednia elementow: {tab.Average()}");
Console.WriteLine($"Max elementow: {max(tab)}");


Console.WriteLine($"Min elementow: {min(tab)}");
int max(int[] tab)
{
     if (tab.Length <= 0) throw new FormatException(message: "Pusta tablica");
     
}

int min(int[] tab)
{
     if (tab.Length <= 0) throw new FormatException(message: "Pusta tablica");
}

int sum(int[] tab){
    if (tab.Length <= 0) throw new FormatException(message: "Pusta tablica");
    int sum = 0;
    foreach (var elem in tab)    {
        sum += elem;
    }
    return sum;
}



double avg(int[] tab){
    if (tab.Length <= 0) throw new FormatException(message: "Pusta tablica");
    return (double)sum(tab)/tab.Length;
}
void print(int[] t)
{
    foreach (int elem in t)
    {
        Console.Write(elem + " ");
    }
    Console.WriteLine($" Rozmiar tablicy: {t.Length}");
}
void fillArray(int[] t)
{
    Random rnd = new Random();
    for (int i = 0; i < t.Length; i++)
    {
        t[i] = rnd.Next(-10, 100);
    }
}