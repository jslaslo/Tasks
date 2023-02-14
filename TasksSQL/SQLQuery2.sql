create database TasksDB

CREATE TABLE Products1 (
	Id INT PRIMARY KEY,
	"Name" TEXT);

INSERT INTO Products1
VALUES
	(1, 'C# in a Nutshell'),
	(2, 'KIA Rio'),
	(3, 'ASUS Rog Strix');

CREATE TABLE Categories1 (
	Id INT PRIMARY KEY,
	"Name" TEXT);

INSERT INTO Categories1
VALUES
	(1, 'Book'),
	(2, 'Car'),
	(3, 'Gift');

CREATE TABLE Product1Categories1 (
	ProductId INT FOREIGN KEY REFERENCES Products1(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories1(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Product1Categories1
VALUES
	(1, 1),
	(1, 3),
	(2, 2);

SELECT P."Name", C."Name"
FROM Products1 P
LEFT JOIN Product1Categories1 PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories1 C
	ON PC.CategoryId = C.Id;