void Part1()
{
    Console.Write("Podaj tekst: ");
    string? text = Console.ReadLine();
    Console.Write("Podaj ilosc wykonan: ");
    int times = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Za pomoca petli for(...){....}");
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine($"{text} i = {i}");
        if (i < times - 2)
        {
            continue;
        }
        Console.WriteLine("Po continue");
    }
    //wykorzystac petle while i do-while do identycznego efektu ja petla for
    Console.WriteLine("Za pomoca petli while(...){....}");
    int j = 0;
    while (j < times)
    {
        Console.WriteLine($"{text} j = {j++}");
    }
    Console.WriteLine("Za pomoca petli do{....}while(...)");
    j = 0;
    do
    {
        Console.WriteLine($"{text} j = {j++}");
    } while (j < times);
}

//Part1();
void Part2()
{

    //zgadywanka program losuje liczbe z przedzialu 0,50
    //uzytkownik zgaduje
    // podpwiadamy czy liczba ma byc wieksza czy mniejsza
    Random rnd = new Random();
    int losowa = rnd.Next(0, 50);
}


