-- CREATE DATABASE Atividade
-- DROP DATABASE Atividade
USE Atividade

-- DROP TABLE Aluno
-- DROP TABLE Jogo
-- DROP TABLE Livro
-- DROP TABLE Funcionario
-- DROP TABLE Pedido

-- Situa��o 1 � Cadastro de Alunos

 CREATE TABLE Aluno (
	IdAluno INT PRIMARY KEY,
	Nome NVARCHAR(100),
	Idade INT,
	Cidade NVARCHAR(100)
)

INSERT INTO Aluno VALUES
(1, 'Pedro', 18, 'S�o Paulo'),
(2, 'Maria', 19, 'S�o Bernado'),
(3, 'Jo�o', 20, 'S�o Paulo'),
(4, 'Ana', 21, 'S�o Caetano'),
(5, 'Guilherme', 22, 'S�o Paulo')

SELECT Nome FROM Aluno
SELECT Nome, Idade FROM Aluno WHERE Idade > 20
SELECT Nome, Cidade FROM Aluno WHERE Cidade = 'S�o Paulo'

-- Situa��o 2 � Loja de Games

CREATE TABLE Jogo (
	IdJogo INT PRIMARY KEY,
	Titulo NVARCHAR(100),
	Genero NVARCHAR(100),
	Preco DECIMAL(5,2)
)

INSERT INTO Jogo VALUES
(1, 'Celeste', 'Plataforma', 60.00),
(2, 'Undertale', 'RPG', 120.00),
(3, 'Cuphead', 'A��o', 270.00),
(4, 'Hollow Knight', 'A��o', 60.00),
(5, 'Stardew Valley', 'RPG', 140.00),
(6, 'Hades', 'A��o', 280.00)

SELECT Titulo FROM Jogo WHERE Genero = 'A��o'
SELECT Titulo, Preco FROM Jogo WHERE Preco > 200
SELECT Titulo, Preco FROM Jogo

-- Situa��o 3 � Biblioteca Virtual

CREATE TABLE Livro (
	IdLivro INT PRIMARY KEY,
	Titulo NVARCHAR(100),
	Autor NVARCHAR(100),
	AnoPublicacao INT
)

INSERT INTO Livro VALUES
(1, 'Dom Quixote de La Mancha', 'Miguel de Cervantes', 1605),
(2, 'Metamorfose', 'Franz Kafka', 1915),
(3, 'Ensaio Sobre a Cegueira', 'Jos� Saramago', 1995),
(4, 'Crime e Castigo', 'Fi�dor Dostoi�vsky', 1866),
(5, 'Sapiens: Uma Breve Hist�ria da Humanidade', 'Yuval Noah Harari', 2011)

SELECT Titulo, AnoPublicacao FROM Livro WHERE AnoPublicacao > 2010
SELECT Titulo, Autor FROM Livro WHERE Autor = 'George Orwell'
SELECT Titulo FROM Livro

-- Situa��o 4 � Cadastro de Funcion�rios

CREATE TABLE Funcionario (
	IdFunc INT PRIMARY KEY,
	Nome NVARCHAR(100),
	Cargo NVARCHAR(100),
	Salario DECIMAL(10,2)
)

INSERT INTO Funcionario VALUES
(1, 'Jo�o', 'Empilhador', 2500.00),
(2, 'Maria', 'Empilhador', 2500.00),
(3, 'Pedro', 'Gerente', 4500.00),
(4, 'Ana', 'Diretor', 6000.00),
(5, 'Guilherme', 'Empacotador', 2500.00)

SELECT Nome, Salario FROM Funcionario WHERE Salario > 3000.00
SELECT Nome, Cargo FROM Funcionario WHERE Cargo = 'Empilhador'
SELECT Nome, Cargo FROM Funcionario

-- Situa��o 5 � Sistema de Pedidos Simples

CREATE TABLE Pedido (
	IdPedido INT PRIMARY KEY,
	Cliente NVARCHAR(100),
	Produto NVARCHAR(100),
	Quantidade INT
)

INSERT INTO Pedido VALUES
(1, 'Jo�o', 'Pizza', 2),
(2, 'Maria', 'Macarr�o', 3),
(3, 'Pedro', 'Pizza', 1),
(4, 'Ana', 'Pizza', 1),
(5, 'Jo�o', 'Coca-cola', 2),
(6, 'Maria', 'Pepsi', 2)

SELECT Cliente, Produto FROM Pedido WHERE Cliente = 'Jo�o'
SELECT Cliente, Produto FROM Pedido WHERE Produto = 'Pizza'
SELECT Cliente, Produto, Quantidade FROM Pedido