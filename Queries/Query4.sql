SELECT Content.Name, Content_Rating.Rating, Users.Login
From Content_Rating
	Join Content on Content_Rating.Content_Id = Content.Content_Id
	Join Users on Content_Rating.User_Id = Users.User_Id
Where Content.Content_Type_Id = 1;