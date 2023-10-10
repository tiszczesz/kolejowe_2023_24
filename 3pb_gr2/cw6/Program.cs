using cw6;

Person p1 = new Person();
Person p2 = new Person("Adam","Nowak",new DateTime(2006,12,23));
p2.Lastname = "Gawerski";
p2.PESEL = "23131313131";
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());

//Napisac klase Circle pola srodek (x,y) oraz promien(musi byc dodatni)
//property dwa konstruktory i nadpisav metode ToString
// obwod i pole kola
//napisac metde sprawdzajaca ile wspolnych punktow maja okregi

