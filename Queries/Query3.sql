SELECT Content_Id, Content.Name, Content.Article_Text, Content.Gallery_Cover, Content.Video_URL, Content.Author_Id, Users.Login, Content_Types.Name   
  FROM Content
	JOIN Users on Content.Author_Id = Users.User_Id
	JOIN Content_Types on Content.Content_Type_Id = Content_Types.Content_Type_Id
where Content_Id = 1;