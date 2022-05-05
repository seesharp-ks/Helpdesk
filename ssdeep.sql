DROP DATABASE SSdeep
CREATE DATABASE SSdeep
USE SSdeep
Go

CREATE TABLE [Rank](
ID int primary key identity,
RankName nvarchar(20) NULL,
UNIQUE(RankName)
)

CREATE TABLE Account(
ID int primary key identity,
[Login] nvarchar(50) NOT NULL,
[Password] nvarchar(50) NOT NULL,
HashedPassword varbinary(max) NULL,
[IDRank] int REFERENCES [Rank](ID),
UNIQUE([Login])
)

CREATE TABLE QA(
ID int primary key identity,
Question nvarchar(400) NULL,
Answer nvarchar(400) NULL,
AuthorID int REFERENCES Account(ID),
UNIQUE(Question,Answer)
)

INSERT INTO [Rank] VALUES
('Администратор'),('Пользователь')

INSERT INTO [Account] Values
('cubzone','destruction',PWDENCRYPT('destruction'),1),
('user','paworld',PWDENCRYPT('paworld'),2)