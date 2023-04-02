USE Test2;
--Таблица: Игрок
CREATE TABLE Player
(
  Id INT PRIMARY KEY,
  FirstТame NVARCHAR(50) NOT NULL,
  LastName NVARCHAR(50) NOT NULL,
  MiddleName NVARCHAR(50) NOT NULL,
  Price MONEY,
  TeamId INT,
  GroupsId INT,
  FOREIGN KEY (TeamId) REFERENCES Team(Id),
  FOREIGN KEY (GroupsId) REFERENCES Groups(Id)
)
INSERT Player VALUES(234235234, 'Евгений','Бондарь','Игоревич',3000000, 2, 100);
INSERT Player VALUES(112312321,'Артем','Иванов','Николаевич',4500000, 1, 101);
INSERT Player VALUES(121432457,'Николай','Петров','Харитонович',6500000,3, 102);
INSERT Player VALUES(456456653,'Олег','Сидоров','Олегович',1400000,4, 100);
INSERT Player VALUES(345436777,'Иван','Бадминтонов','Петрович',4500000,6, 101);
INSERT Player VALUES(342343433,'Игорь','Футболеров','Дмитриев',2600000,5, 102);
INSERT Player VALUES(346366444,'Николай','Казак','Олегович',9300000, 7, 100);
--DROP TABLE Player

--Таблица: Команда
CREATE TABLE Team
(
  Id INT PRIMARY KEY,
  Name NVARCHAR(50) NOT NULL,
  Price MONEY,
  TrenerId INT,
  FOREIGN KEY (TrenerId) REFERENCES Trener(Id)
);
INSERT Team VALUES (1, 'ФК Балтика', 1000000, 7);
INSERT Team VALUES (2, 'ФК Краснодар', 4000000, 7);
INSERT Team VALUES (3, 'ФК ЦСКА', 5000000, 6);
INSERT Team VALUES (4, 'ФК Шинник', 3000000, 1);
INSERT Team VALUES (5, 'ФК Торпедо', 5066000, 2);
INSERT Team VALUES (6, 'ФК Алания', 1033000, 4);
INSERT Team VALUES (7, 'ФК Зенит', 1234000, 5);
INSERT Team VALUES (8, 'ФК Ростов', 15677000, 5);
DROP TABLE Team

--Таблица: Тренер
CREATE TABLE Trener
(
  Id INT PRIMARY KEY,
  Trener NVARCHAR(50) NOT NULL,
  Age INT NOT NULL,
  Rating INT NOT NULL
);
INSERT Trener VALUES (1, 'Семенов Е.И.', 40, 70);
INSERT Trener VALUES (2, 'Петров И.Л.', 50, 99);
INSERT Trener VALUES (3, 'Иванов И.П.', 60, 80);
INSERT Trener VALUES (4, 'Сидоров П.И.', 55, 76);
INSERT Trener VALUES (5, 'Бондарь С.М.', 44, 74);
INSERT Trener VALUES (6, 'Харламов К.А.', 66, 34);
INSERT Trener VALUES (7, 'Харитонов А.В.', 77, 78);
DROP TABLE Trener

--Таблица: Группы
CREATE Table Groups
(
  Id INT PRIMARY KEY,
  Name NVARCHAR(50) NOT NULL,
  TeamID INT
)
DROP TABLE Groups

INSERT Groups VALUES(100, 'low', 2);
INSERT Groups VALUES(105, 'Medium', 1);
INSERT Groups VALUES(105, 'High', 3);
INSERT Groups VALUES(103, 'High', 4);
INSERT Groups VALUES(133, 'High', 5);
INSERT Groups VALUES(345, 'High', 6);

--Таблица: Расписание
CREATE TABLE Schedule
(
  Id INT PRIMARY KEY NOT NULL,
  GroupsID INT NOT NULL,
  FOREIGN KEY (GroupsID) REFERENCES Groups(Id),
  TeamID INT NOT NULL,
  FOREIGN KEY (TeamID) REFERENCES Team(Id),
  TIME DATE NOT NULL,
  CHECK (TIME!='2023-12-31')
)
DROP TABLE Schedule

INSERT Schedule VALUES(1, 100, 1,'2023-11-28');
INSERT Schedule VALUES(13123123, 101, 2,'2023-07-14');
INSERT Schedule VALUES(34343144, 102, 3,'2023-05-13');
INSERT Schedule VALUES(23432434, 100, 4,'2023-04-21');
INSERT Schedule VALUES(12313221, 101, 5,'2023-11-10');
INSERT Schedule VALUES(12123112, 102, 6,'2023-11-11');
