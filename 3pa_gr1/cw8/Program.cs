using cw8;

GamesRepo repo = new GamesRepo();

var games = repo.GetGames();
Console.WriteLine($"Ilosc gier: {games.Count}");
GameInterface.ShowAll(games);
//Game game = GameInterface.CreateGame();
//Console.WriteLine(game);
//repo.InsertGame(game);
// Console.Write("Podaj tytul gry: ");
// var title = Console.ReadLine()?.Trim().ToLower();
// var answer = repo.GetGamesByTitle(title);