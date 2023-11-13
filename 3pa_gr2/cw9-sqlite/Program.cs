using cw9_sqlite;

PostsRepo repo = new PostsRepo();
var posts = repo.GetPosts();
PostsInterface.ShowPosts(posts);
