using cw6;

Person p1 = new Person();
Person p2 = new Person("Adam","Nowak",new DateTime(2006,12,23));
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());

