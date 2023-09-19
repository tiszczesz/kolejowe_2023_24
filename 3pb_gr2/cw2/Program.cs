void part1()
{
    Console.Write("Podaj fajny tekst: ");
    string? text = Console.ReadLine();
    Console.Write("Ile razy powtorzyc: ");
    int times = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("petla for(;;){....}");
    for (int i = 0; i < times; i++)
    {
        Console.WriteLine($"{text} i = {i}");
    }
    Console.WriteLine("petla while(){....}");
    int j = 0;
    while (j < times)
    {
        Console.WriteLine($"{text} j = {j++}");
    }
    j = 0;
    Console.WriteLine("petla do{....}while()");
    do
    {
        Console.WriteLine($"{text} j = {j++}");
    } while (j < times);

}
//part1();
void part2(){
    //zgadywanka dla Janka
    //losujemy liczbe z przedzialu 0..50
    //a uzytkownik zgaduje podpowiadamy 
    //czy za duzo czy za malo
    //zliczamy ilosc prob
    Random rnd = new Random();
    int szukana = rnd.Next(0,50);
}
part2();

