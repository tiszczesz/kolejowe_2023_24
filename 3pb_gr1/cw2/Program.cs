Console.Write("Podaj tekst: ");
string? text = Console.ReadLine();
Console.Write("Podaj ilosc wykonan: ");
int times = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Za pomoca petli for(...){....}");
for(int i=0; i<times;i++ ){    
    Console.WriteLine($"{text} i = {i}");
    if(i<times-2){
        continue;
    }
    Console.WriteLine("Po continue");
}
Console.WriteLine("Za pomoca petli while(...){....}");
int j = 0;
while(j<times ){    
    Console.WriteLine($"{text} j = {j++}");
}
//wykorzystac petle while i do-while do identycznego efektu ja petla for
Console.WriteLine("Za pomoca petli do{....}while(...)");
j = 0;
do{    
    Console.WriteLine($"{text} j = {j++}");
}while(j<times);