try
{
    Console.Write("Podaj swoje imie: ");
    string? firstname = Console.ReadLine();
    Console.Write("Podaj swoj wiek: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Witaj: " + firstname?.ToUpper());
    if (age >= 18)
    {
        Console.WriteLine($"Witaj {firstname} w swiecie doroslych");
    }
    else
    {
        Console.WriteLine($"Witaj {firstname} niestety to serwis nie dla Ciebie");
    }
}catch(FormatException ex){
    Console.WriteLine("Bledne dane");
    Console.WriteLine(ex.Message);
}


