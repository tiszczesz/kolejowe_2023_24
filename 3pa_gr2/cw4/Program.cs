
void ex1()
{
    int[] tab = new int[10];
    showTab(tab);

    tab[6] = 666;
    //tab[10] = 7777;
    showTab(tab);
    fillTab(tab);
    showTab(tab);
}
void ex2()
{
    Console.Write("Podaj rozmiar tablicy: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    fillTab(numbers);
    showTab(numbers);
    Console.WriteLine($"Max element: {getMax(numbers)}");
    Console.WriteLine($"Min element: {getMin(numbers)}");
    Console.WriteLine($"Max element: {numbers.Max()}");
    Console.WriteLine($"Min element: {numbers.Min()}");
    string[] tt = {"dsfsdfs","ewrwerwr","retreterte","erwerwr"};
    showTab<string>(tt);
   // Console.WriteLine($"suma: {numbers.Sum()}");
   // Console.WriteLine($"srednia: {numbers.Average()}");

}

int getMin(int[] numbers)
{
    if (numbers.Length <= 0) throw new FormatException(message: "Pusty zbior");
    int min = numbers[0];
    foreach (var e in numbers)
    {
        if (e < min) min = e;
    }
    return min;
}

int getMax(int[] numbers)
{
    if (numbers.Length <= 0) throw new FormatException(message: "Pusty zbior");
    int max = numbers[0];
    foreach (var e in numbers)
    {
        if (e > max) max = e;
    }
    return max;

}

//ex1();
ex2();
//Console.WriteLine(tab.Length);
void showTab<T>(T[] t)
{
    foreach (T elem in t)
    {
        Console.Write(elem + " ");
    }
    Console.WriteLine();
}
void fillTab(int[] t)
{
    Random rnd = new Random();
    for (int i = 0; i < t.Length; i++)
    {
        t[i] = rnd.Next(-10, 200);
    }

}