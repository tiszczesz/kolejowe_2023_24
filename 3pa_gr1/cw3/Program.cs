using System.Globalization;

void ex1()
{
    int[] numbers = new int[10];
    showTab(numbers);
    numbers[3] = 1233;
    //numbers[10] = 45455;
    showTab(numbers);
    fillTab(numbers);
    showTab(numbers);
}
void fillTab(int[] dane)
{
    Random rnd = new Random();
    for (int i = 0; i < dane.Length; i++)
    {
        dane[i] = rnd.Next(0, 100);
    }
}
void showTab(int[] dane)
{
    for (int i = 0; i < dane.Length; i++)
    {
        Console.WriteLine($"numbers[{i}] = {dane[i]}");
    }
}
//ex1();
//ex2();
ex3();
void ex2()
{
    Console.Write("Podaj rozmiar tablicy: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    fillTab(numbers);
    showTab(numbers);
    //napisac funkcje ktora oblicza sume i srednia liczb z tablicy
    Console.WriteLine($"Suma elementow: {sum(numbers)}");
    Console.WriteLine($"Srednia elementow: {avg(numbers)}");
    Console.WriteLine($"Max element : {getMax(numbers)}");
    Console.WriteLine($"Min element : {getMin(numbers)}"); //O(n)

    // Console.WriteLine($"Suma2 elementow: {numbers.Sum()}");
    // Console.WriteLine($"Srednia2 elementow: {numbers.Average()}");
    Console.WriteLine($"Max element : {numbers.Max()}");
    Console.WriteLine($"Min element : {numbers.Min()}"); //O(n)
}
void ex3()
{
    string[] strings = { "ddddd", "sdfsfsfs", "wrwerwrwrw", "ertet eeetee" };
    foreach (var elem in strings)
    {
        Console.WriteLine(elem.ToUpper());
    }
    Console.WriteLine($"Najdluzszy tekst: {strings.Max(e => e.Length)}");
    Console.WriteLine($"Najkrotszy tekst: {strings.Min(e => e.Length)}");
}
int sum(int[] numbers)
{
    int result = 0;
    foreach (int elem in numbers)
    {
        result += elem;
    }
    return result;
}

double avg(int[] numbers)
{
    if (numbers.Length > 0)
    {
        return (double)sum(numbers) / numbers.Length;
    }
    else
    {
        throw new FormatException(message: "Tablica pusta");
    }
}
int getMax(int[] numbers)
{
    if (numbers.Length > 0)
    {
        int max = numbers[0];
        foreach (var elem in numbers)
        {
            if (elem > max) max = elem;
        }
        return max;
    }
    else
    {
        throw new FormatException(message: "Tablica pusta");
    }
}
int getMin(int[] numbers)
{
    if (numbers.Length > 0)
    {
        int min = numbers[0];
        foreach (var elem in numbers)
        {
            if (elem < min) min = elem;
        }
        return min;
    }
    else
    {
        throw new FormatException(message: "Tablica pusta");
    }
}