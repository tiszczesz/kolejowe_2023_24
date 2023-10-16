Ex1();
Ex2();
void Ex2(){
    //tworzy losowe listy liczb
    //zapisywane potem do pliku jena lista jedna linia zakonczona
    // suma tych liczb po 
    // 3 6 9|18|ilosc liczb pierwszych
}
void Ex3(){
    //aplikacja za menu
    //dodaj nowa gre
    //pokaz wszystkie gry
    //zakoncz program
    //z operacji na pliku
    //linia pliku: tytul;cena;gatunek;cool:bool 

}
void Ex1()
{
    string[] words = new string[]{
        "ala ma kota",
        "frtretete jeaad ere wr",
        "qwqw qw qewwqewe qeqeq qew",
        "ui yuyiyuiyuyyiy"
    };
    File.WriteAllLines("dane.txt", words);

    var dane = File.ReadAllLines("dane.txt");
    foreach (string line in dane)
    {
        Console.WriteLine(line); 
    }
}
