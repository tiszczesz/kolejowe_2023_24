void cw0()
{
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
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
void cw1()
{
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
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
void cw2()
{
    Console.Write("Podaj tekst: ");
    string? text = Console.ReadLine();
    Console.Write("Ile razy pwtorzyc: ");
    int ile = Convert.ToInt32(Console.ReadLine());
    //for ,while, do-while
    Console.WriteLine(" ============================================== ");
}
cw2();
Random rnd = new Random();
int losowa = rnd.Next(0,100);

