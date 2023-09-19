try{
    Console.WriteLine("Witamy w swiecie dotnet");
    //Console.ReadKey();
    Console.Write("Podaj a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Podaj b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a + " + " + b + " = " + (a + b));
    Console.WriteLine($"{a} + {b} = {a + b}");
    Console.WriteLine($"{a} - {b} = {a - b}");
    Console.WriteLine($"{a} * {b} = {a * b}");
    if (b == 0)    {
        Console.WriteLine($"{a} / {b} = BRAK WYNIKU!!");
    }
    else    {
        Console.WriteLine($"{a} / {b} = {(double)a / b}");
    }
}
catch (FormatException ex){
    Console.WriteLine("Bledne dane");
    Console.WriteLine(ex.Message);
}


