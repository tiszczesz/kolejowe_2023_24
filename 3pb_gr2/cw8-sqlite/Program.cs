using cw8_sqlite;

PostsRepo repo = new PostsRepo();

var posts = repo.GetPosts();

Console.WriteLine(posts.Count);
