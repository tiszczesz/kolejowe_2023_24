Console.Write("Podaj tekst: ");
string text = Console.ReadLine();
Console.Write("Podaj ilosc powtorzen: ");
int times = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------petla for------------");
for(int i=0; i<times;i++ ){
    Console.WriteLine($"i = {i}: {text}");    
}
int iterator = 0;
Console.WriteLine("--------petla while------------");
while(iterator<times){
    Console.WriteLine($"i = {iterator++}: {text}");
}
Console.WriteLine("petla do while");
iterator = 0;
do{
    Console.WriteLine($"i = {iterator++}: {text}");
} while(iterator<times);
