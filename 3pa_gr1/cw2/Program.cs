Console.Write("Podaj tekst: ");
string text = Console.ReadLine();
Console.Write("Podaj ilosc powtorzen: ");
int times = Convert.ToInt32(Console.ReadLine());
for(int i=0; i<times;i++ ){
    Console.WriteLine($"i = {i}: {text}");    
}
int iterator = 0;
Console.WriteLine("-------------------------");
while(iterator<times){
    Console.WriteLine($"i = {iterator++}: {text}");
}
