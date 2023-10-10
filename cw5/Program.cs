using cw5;

Person p1 = new Person(); //utworzenie obiektu typu Person
Person p2 = new Person("Leon","Frecki",new DateTime(2005,12,9));
Console.WriteLine(p1);  //metoda ToString()
Console.WriteLine(p2);  //metoda ToString()


Console.WriteLine(p1.ToString());  //metoda ToString()
Console.WriteLine(p1.GetHashCode());  //metoda GetHashCode()
Console.WriteLine(p1.GetType());  //metoda GetType()

//napisac klase Car z polami marka cena rokProdukcji przebieg