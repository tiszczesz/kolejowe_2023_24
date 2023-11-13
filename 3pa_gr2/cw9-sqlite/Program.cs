using cw9_sqlite;

PostsRepo repo = new PostsRepo();
var posts = repo.GetPosts();
PostsInterface.ShowPosts(posts);
Post p = PostsInterface.NewPost();
repo.InsertPost(p);
posts = repo.GetPosts();
PostsInterface.ShowPosts(posts);
