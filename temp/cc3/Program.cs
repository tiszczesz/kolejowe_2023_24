using System.Text.Json;
using cc3;

List<Game> games = new List<Game>{
     new Game{Id=1,Title="Wiedzmin",Price=66.90m,Edition=new DateTime(2008,12,9)},
     new Game{Id=2,Title="Rymok",Price=66.90m,Edition=new DateTime(2012,12,9)},
     new Game{Id=3,Title="Cyberpunk 2077",Price=166.90m,Edition=new DateTime(2019,12,9)},
     new Game{Id=4,Title="FIFA 2019",Price=67.90m,Edition=new DateTime(2017,3,19)}
};
List<string> lines = new List<string>();
 foreach(Game g in games){
    lines.Add(JsonSerializer.Serialize(g));
}
File.WriteAllLines("games.txt",lines);
List<string> deserialize = File.ReadAllLines("games.txt").ToList();

var g1 = JsonSerializer.Deserialize<Game>(deserialize[2]);
Console.WriteLine(g1);
