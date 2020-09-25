SELECT Content.Content_Id, Content.Name, Content_Types.Name as Content_Types, Users.Login as Author, ISNULL(AVG(Rating), 0) AS Rating, COUNT(Rating) as Rating_Count
  FROM Content
	   LEFT JOIN Content_Rating
	   ON Content_Rating.Content_Id = Content.Content_Id

	   INNER JOIN Content_Types
	   ON Content_Types.Content_Type_Id = Content.Content_Type_Id

	   INNER JOIN Users
	   ON Users.User_Id = Content.Author_Id

GROUP BY Content.Name, Content.Content_Id, Content_Types.Name, Users.Login
ORDER BY Rating DESC;