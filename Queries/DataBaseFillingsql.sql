INSERT INTO Users(Login, City)
Values('abc@gmail.com', 'London');

INSERT INTO Users(Login, City)
Values('Alex95@gmail.com', 'Berlin');

INSERT INTO Users(Login, City)
Values('Sasha12@yandex.ru', 'Moscow');

INSERT INTO Users(Login, City)
Values('Bazinga@mail.ru', 'Perm');

INSERT INTO Users(Login, City)
Values('DeafultUser@default.com', 'Boston');

INSERT INTO Content_Types (Name)
VALUES('Video');

INSERT INTO Content_Types (Name)
VALUES('Gallery');

INSERT INTO Content_Types (Name)
VALUES('Article');

INSERT INTO Content(Name, Video_URL, Content_Type_Id, Author_Id)
Values('Mega prank video', 'https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstleyVEVO', 1, 1);

INSERT INTO Content(Name, Video_URL, Content_Type_Id, Author_Id)
Values('Video before going to sleep', 'https://www.youtube.com/watch?v=gfkts0u-m6w&t=6s&ab_channel=%231AinsleyHarriottFan', 1, 1);

INSERT INTO Content(Name, Video_URL, Content_Type_Id, Author_Id)
Values('Corgi compilation', 'https://www.youtube.com/watch?v=67SMrv9EwlI&ab_channel=FunnyPetVideos', 1, 1);

INSERT INTO Content(Name, Video_URL, Content_Type_Id, Author_Id)
Values('Epic battle', 'https://www.youtube.com/watch?v=7e_QpIBC8xk&ab_channel=minhvolg', 1, 2);

INSERT INTO Content(Name, Article_Text, Content_Type_Id, Author_Id)
Values('A real big text', 'The biggest text you have ever seen', 2, 2);

INSERT INTO Content(Name, Gallery_Cover, Content_Type_Id, Author_Id)
Values('Puppies', 'FunnyPuppy.img', 3, 2);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('4', '1', 5);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('2', '1', 4);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('3', '1', 5);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('5', '1', 3);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('2', '4', 5);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('3', '4', 5);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('4', '4', 5);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('1', '6', 3);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('3', '6', 3);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('4', '6', 2);

INSERT INTO Content_Rating (User_Id, Content_Id, Rating)
VALUES ('5', '6', 1);