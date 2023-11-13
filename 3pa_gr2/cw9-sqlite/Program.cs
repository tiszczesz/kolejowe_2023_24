using cw9_sqlite;

PostsRepo repo = new PostsRepo();
var posts = repo.GetPosts();
Console.WriteLine($"Ilosc postow: {posts.Count}");
