Console.Write("Podaj fajny tekst: ");
string? text = Console.ReadLine();
Console.Write("Ile razy powtorzyc: ");
int times = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("petla for(;;){....}");
for(int i = 0; i<times;i++){    
    Console.WriteLine($"{text} i = {i}");
}
Console.WriteLine("petla while(){....}");
Console.WriteLine("petla do{....}while()");
