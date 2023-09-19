Console.Write("Podaj tekst: ");
string? text = Console.ReadLine();
Console.Write("Podaj ilosc wykonan: ");
int times = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Za pomoca petli for(...){....}");
for(int i=0; i<times;i++ ){    
    Console.WriteLine($"{text} i = {i}");
}

//wykorzystac petle while i do-while do identycznego efektu ja petla for
