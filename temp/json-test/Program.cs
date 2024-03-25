// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");

var dane = File.ReadAllText("dane.json");
var reciples = JsonSerializer.Deserialize<List<Recipe>>(dane);
Console.WriteLine(reciples.Count);
