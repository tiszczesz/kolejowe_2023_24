using cw6;

Student s1 = new Student();
Student s2 = new Student();
Student s3 = new Student("Franek","Dzbanek",33);
Console.WriteLine(s1.ToString());
// Console.WriteLine(s1.GetHashCode());
// Console.WriteLine(s2.GetHashCode());
// Console.WriteLine(s1.GetType());
Console.WriteLine(s3);

Console.WriteLine(s3.Lastname);
s3.Age = -21;
s3.Avg = 4.5;
Console.WriteLine(s3);
Console.WriteLine(s3.Avg);
//Klasa Rectangle pola a i b prywatne property A i B aby tylko dodatnie
//metoda ToString() wyswietla informacje o obiekcie czyli a i b oraz 
//pole i obwod  --> metody osobne
