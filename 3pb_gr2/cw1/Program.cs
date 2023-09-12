// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Podaj a: ");
int a = Convert.ToInt32( Console.ReadLine());
Console.Write("Podaj b: ");
int b = Convert.ToInt32( Console.ReadLine());
Console.WriteLine(a+" + "+b+" = "+(a+b));
Console.WriteLine($"{a} + {b} = {(a+b)}");
Console.WriteLine($"{a} - {b} = {(a-b)}");
Console.WriteLine($"{a} * {b} = {(a*b)}");
if(b==0){
Console.WriteLine($"{a} / {b} = BRAK WYNIKU!!!");

}else{
    Console.WriteLine($"{a} / {b} = {((double)a/b)}");
}
