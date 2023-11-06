-- SQLite
CREATE TABLE Posts(
    id INTEGER PRIMARY KEY,
    title VARCHAR(50) NOT NULL,
    content VARCHAR(50),
    date DATE 
)

INSERT INTO Posts(title,content,date)
VALUES("post 1","To jest pierwsy post"
    ,"2023-09-12");
INSERT INTO Posts(title,content,date)
VALUES("post 2","Lepiej pisać dla własnego dobra"
    ,"2023-11-06");
INSERT INTO Posts(title,content,date)
VALUES("post 3","Jest głośno ale mam sposoby na wyciszenia"
    ,"2023-11-06");    
SELECT strftime('%Y', date) FROM Posts;