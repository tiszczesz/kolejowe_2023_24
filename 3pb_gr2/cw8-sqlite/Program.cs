using cw8_sqlite;

PostsRepo repo = new PostsRepo();

var posts = repo.GetPosts();

ConsoleInter.ShowAllPosts(posts);
//var p = ConsoleInter.CreatePost();
//repo.InsertPost(p);
var filtered = ConsoleInter.SearchPostsByTitle(posts);
ConsoleInter.ShowAllPosts(filtered);
//dodac usuwanie posta po podaniu przez uzytkownika tytulu posta
// i potwierdzeniu ze wlasnie ten post chce usunac ---> 3
// dodac update wybranego posta po tytule
// uzytkownik decyduje co ma updatowac   ----> 4
// pelna aplikacja z menu jak we wczesniejszym projekcie  -----> 5
