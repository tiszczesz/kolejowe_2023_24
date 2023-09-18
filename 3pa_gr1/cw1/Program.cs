
try
{
    string firstname = Console.ReadLine();
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} * {b} = {a * b}");
    if (b != 0)
    {
        Console.WriteLine($"{a} / {b} = {(float)a / b}");
    }
    else
    {
        Console.WriteLine($"{a} / {b} = BRAK WYNIKU");
    }

}
catch (FormatException ex)
{
    Console.WriteLine("Bledne dane");
    Console.WriteLine(ex.Message);
}
