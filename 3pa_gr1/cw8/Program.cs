using cw8;

GamesRepo repo = new GamesRepo();

var games = repo.GetGames();
Console.WriteLine($"Ilosc gier: {games.Count}");
Game game = GameInterface.CreateGame();
Console.WriteLine(game);
repo.InsertGame(game);
