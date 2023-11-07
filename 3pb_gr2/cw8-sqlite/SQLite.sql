-- SQLite
CREATE TABLE Posts(
    Id INTEGER PRIMARY KEY,
    Title VARCHAR(50),
    Content VARCHAR(50),
    PostDate DATE
);
INSERT INTO Posts(Title,Content,
 PostDate)
 VALUES("Post 1","Mój pierwszy post","2022-09-12");
 INSERT INTO Posts(Title,Content,
 PostDate)
 VALUES("Post 21","Ciepły Listopad","2022-09-12");
 INSERT INTO Posts(Title,Content,
 PostDate)
 VALUES("Post 3","yyyyyyy","2023-11-07");
 INSERT INTO Posts(Title,Content,
 PostDate)
 VALUES("Post 4","Ostatni post dzisiaj","2023-11-07");