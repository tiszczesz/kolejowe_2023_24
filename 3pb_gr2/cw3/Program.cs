string[] imiona = { "Anna", "Joanna", "Tomasz" };
foreach (var item in imiona)
{
    Console.WriteLine(item);
}
imiona[imiona.Length - 1] = "Roman";
Console.WriteLine($"Rozmiar: {imiona.Length}");
foreach (var item in imiona)
{
    Console.WriteLine(item);
}
int[] losowe = new int[10];
//funkcja ktora wypelni losowymi  0..100 wartosciami ta tablice
void FillArray(int[] contener)
{

}
void ShowArray(int[] contener)
{
    foreach (var item in contener)
    {
        Console.WriteLine(item);
    }
}
FillArray(losowe);
ShowArray(losowe);
int max = getMax(losowe);
