using cw5;

Game g1 = new Game();
Game g2 = new Game("Wiedzmin 3","Rpg",new DateTime(2015,9,12),68.99M);
Empty e1 = new Empty();
Empty e2 = new Empty();
g2.Price = -45.67m;
// Console.WriteLine(e1.ToString());
// Console.WriteLine(e1.GetHashCode());
// Console.WriteLine(e2.GetHashCode());
 Console.WriteLine(g2.ToString());
