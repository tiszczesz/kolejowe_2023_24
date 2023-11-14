using cw8_sqlite;

PostsRepo repo = new PostsRepo();

var posts = repo.GetPosts();

ConsoleInter.ShowAllPosts(posts);
var p = ConsoleInter.GetPost();
repo.InsertPost(p);
