string[] words = {"dom","szkola","to","ryba"};
string[] sort = words.OrderBy(x=>x).ToArray();
double[] numbers = {23.5, 45.8, 78,89.99};
print<string>(words);
print<string>(sort);
print<double>(numbers);
if (string.Compare(words[0],words[1])<0)
{
    Console.WriteLine("gggg");
}


void print<T>(T[] t)
{
    foreach (T elem in t)
    {
        Console.Write(elem + " ");
    }
    Console.WriteLine($" Rozmiar tablicy: {t.Length}");
}