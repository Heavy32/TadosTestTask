Запросы указаны для MS SQL в папке https://github.com/Heavy32/TadosTestTask/tree/master/Queries
Запрос 3 работает некорректно, к сожалению, не хватило времени, чтобы разобраться до конца, что не так. Очевидно, что функция AVG работает, опираясь на неправильно структурированные данные. Декомпозиция запросов на более мелкие и проработка каждого из них способна решить эту проблему.
Была реализована простейшая логика работы с базой данных при помощи MVC (https://github.com/Heavy32/TadosTestTask/tree/master/TadosTestTaskMVC) и Ef core (https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Data/ContentContext.cs)
К сожалению, не хватило избавиться от недочетов, а именно:
1) Перегруженные "толстые" контроллеры
2) Отсутствие тестов контроллеров и валидации данных
3) Более сложной и продуманной валидации
4) Отсутствие запросов из задания с помощью Linq to Sql
5) Мелкие шероховатости в code style

На устранение недочетов уйдёт около 4-х часов, вне зависимости от результатов тестирования, данные проблемы будут устранены.

Ниже описано задание и ссылки к файлам.

Дана предметная область: 
Пользователь – обладает идентификатором, логином (почтой), городом. https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Models/User.cs

Контент – обладает идентификатором (целое число) и названием (строка) и категорией (статья, видео, галерея) и создателем (пользователь). 
https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Models/Contents/Content.cs

Статья – контент, у которого есть текст (возможно, очень большой). 
https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Models/Contents/Article.cs

Видео – контент, у которого есть ссылка (URL) на видео (например, на видеохостинге (youtube)). 
https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Models/Contents/Video.cs

Галерея – контент, у которого есть ссылки (URL) на оригинальные изображения. У галереи также есть обложка – изображение. 
https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Models/Contents/Gallery.cs

Пользователь может оценивать контент. Один пользователь может оценить один контент один раз. Оценка – целое число в диапазоне от 1 до 5. 
https://github.com/Heavy32/TadosTestTask/blob/master/TadosTestTaskMVC/Models/Contents/UsersRating.cs

Со временем могут появляться новые категории контента.

Ваша задача:
1. Описать предметную область в виде классов на языке C#. 
https://github.com/Heavy32/TadosTestTask/tree/master/TadosTestTaskMVC/Models
2. Описать схему базы данных.
https://github.com/Heavy32/TadosTestTask/blob/master/Queries/DataBaseFillingsql.sql

  Для разработанной схемы написать запросы:
  a. Получить контент, отсортированный по убыванию по рейтингу (среднее от оценок пользователей. Если оценок нет, то среднее – 0). В результате запроса – идентификатор контента, название, рейтинг, категория, количество оценок.
  https://github.com/Heavy32/TadosTestTask/blob/master/Queries/Query1.sql
  
  b. Получить пользователей, отсортированных по убыванию рейтинга (рейтинг пользователя – средний рейтинг созданного им контента). В результате запроса – идентификатор пользователя, логин пользователя, рейтинг пользователя.
  https://github.com/Heavy32/TadosTestTask/blob/master/Queries/Query2.sql
  
  c. Написать запрос на получение контента по идентификатору. В результате запроса – идентификатор контента, название, категория, идентификатор пользователя, логин пользователя. В этом же запросе должны возвращаться все данные для конкретной категории (для статьи – текст, для видео – ссылка, для галереи – обложка). 
  https://github.com/Heavy32/TadosTestTask/blob/master/Queries/Query3.sql
  
  d. Вывести все оценки видео всеми пользователями. Если оценки нет, то считать, что оценка – 0. 
  https://github.com/Heavy32/TadosTestTask/blob/master/Queries/Query4.sql
  
  При возникновении вопросов со мной можно связаться
  ВК: https://vk.com/im?peers=83660669_71459019
  Почта: maksim.gorankov@gmail.com
  Телефон или Telegram: 8-952-659-22-2
