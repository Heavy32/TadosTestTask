SELECT Users.Login as Author, AVG(ISNULL(Rating, 0)) as Rating
  FROM Content
	   LEFT JOIN Content_Rating
	   ON Content_Rating.Content_Id = Content.Content_Id

	   INNER JOIN Users
	   ON Content.Author_Id = Users.User_Id

GROUP BY Users.Login
ORDER BY Users.Login DESC;