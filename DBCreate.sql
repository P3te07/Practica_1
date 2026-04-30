--conectat la localhost, port 1433

CREATE DATABASE SalaFIT

USE SalaFIT 
CREATE TABLE Clienti
(
IdClient INT NOT NULL PRIMARY KEY,
NumePrenume NVARCHAR(MAX),
DataNasterii DATE,
Telefon CHAR(10),
Email NVARCHAR(MAX) CHECK (Email LIKE '%@%')
)

CREATE TABLE Abonamente
(
IdAbonament INT NOT NULL PRIMARY KEY,
Tip NVARCHAR(MAX),
Pret MONEY,
GradAcces INT 
)

CREATE TABLE InregistrareAbonament
(
Id INT NOT NULL PRIMARY KEY,
IdClient INT NOT NULL FOREIGN KEY REFERENCES Clienti(IdClient),
IdAbonament INT NOT NULL FOREIGN KEY REFERENCES Abonamente(IdAbonament),
DataStart DATE,
DataFinish DATE
)
