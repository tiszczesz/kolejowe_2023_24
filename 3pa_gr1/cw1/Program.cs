// See https://aka.ms/new-console-template for more information
Console.WriteLine("Witaj swiecie");
Console.Write("Podaj a: ");
int a = Convert.ToInt32( Console.ReadLine());
Console.Write("Podaj b: ");
int b = Convert.ToInt32( Console.ReadLine());
Console.WriteLine($"a = {a}");
Console.WriteLine($"{a} + {b} = {a+b}");
Console.WriteLine($"{a} - {b} = {a-b}");
Console.WriteLine($"{a} * {b} = {a*b}");
Console.WriteLine($"{a} / {b} = {(float)a/b}");