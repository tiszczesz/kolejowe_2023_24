
string[] words = { "dom", "chleb", "cukier", "ryba", "kon" };
//string[] sorted = sort(words);
string[] sorted2 = words.OrderBy(w => w).ToArray();

string[] sort(string[] words)
{
    throw new NotImplementedException();
}

double[] numbers = { 12, 67, 90.8, 56, 78 };
print<string>(words);
print<double>(numbers);
void print<T>(T[] tab)
{
    foreach (T elem in tab)
    {
        Console.Write(elem + " ");
    }
    Console.WriteLine();
}
