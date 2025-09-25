-- CREATE DATABASE Atividade
-- DROP DATABASE Atividade
USE Atividade

-- DROP TABLE Aluno
-- DROP TABLE Jogo
-- DROP TABLE Livro
-- DROP TABLE Funcionario
-- DROP TABLE Pedido

-- Situação 1 – Cadastro de Alunos

 CREATE TABLE Aluno (
	IdAluno INT PRIMARY KEY,
	Nome NVARCHAR(100),
	Idade INT,
	Cidade NVARCHAR(100)
)

INSERT INTO Aluno VALUES
(1, 'Pedro', 18, 'São Paulo'),
(2, 'Maria', 19, 'São Bernado'),
(3, 'João', 20, 'São Paulo'),
(4, 'Ana', 21, 'São Caetano'),
(5, 'Guilherme', 22, 'São Paulo')

SELECT Nome FROM Aluno
SELECT Nome, Idade FROM Aluno WHERE Idade > 20
SELECT Nome, Cidade FROM Aluno WHERE Cidade = 'São Paulo'

-- Situação 2 – Loja de Games

CREATE TABLE Jogo (
	IdJogo INT PRIMARY KEY,
	Titulo NVARCHAR(100),
	Genero NVARCHAR(100),
	Preco DECIMAL(5,2)
)

INSERT INTO Jogo VALUES
(1, 'Celeste', 'Plataforma', 60.00),
(2, 'Undertale', 'RPG', 120.00),
(3, 'Cuphead', 'Ação', 270.00),
(4, 'Hollow Knight', 'Ação', 60.00),
(5, 'Stardew Valley', 'RPG', 140.00),
(6, 'Hades', 'Ação', 280.00)

SELECT Titulo FROM Jogo WHERE Genero = 'Ação'
SELECT Titulo, Preco FROM Jogo WHERE Preco > 200
SELECT Titulo, Preco FROM Jogo

-- Situação 3 – Biblioteca Virtual

CREATE TABLE Livro (
	IdLivro INT PRIMARY KEY,
	Titulo NVARCHAR(100),
	Autor NVARCHAR(100),
	AnoPublicacao INT
)

INSERT INTO Livro VALUES
(1, 'Dom Quixote de La Mancha', 'Miguel de Cervantes', 1605),
(2, 'Metamorfose', 'Franz Kafka', 1915),
(3, 'Ensaio Sobre a Cegueira', 'José Saramago', 1995),
(4, 'Crime e Castigo', 'Fiódor Dostoiévsky', 1866),
(5, 'Sapiens: Uma Breve História da Humanidade', 'Yuval Noah Harari', 2011)

SELECT Titulo, AnoPublicacao FROM Livro WHERE AnoPublicacao > 2010
SELECT Titulo, Autor FROM Livro WHERE Autor = 'George Orwell'
SELECT Titulo FROM Livro

-- Situação 4 – Cadastro de Funcionários

CREATE TABLE Funcionario (
	IdFunc INT PRIMARY KEY,
	Nome NVARCHAR(100),
	Cargo NVARCHAR(100),
	Salario DECIMAL(10,2)
)

INSERT INTO Funcionario VALUES
(1, 'João', 'Empilhador', 2500.00),
(2, 'Maria', 'Empilhador', 2500.00),
(3, 'Pedro', 'Gerente', 4500.00),
(4, 'Ana', 'Diretor', 6000.00),
(5, 'Guilherme', 'Empacotador', 2500.00)

SELECT Nome, Salario FROM Funcionario WHERE Salario > 3000.00
SELECT Nome, Cargo FROM Funcionario WHERE Cargo = 'Empilhador'
SELECT Nome, Cargo FROM Funcionario

-- Situação 5 – Sistema de Pedidos Simples

CREATE TABLE Pedido (
	IdPedido INT PRIMARY KEY,
	Cliente NVARCHAR(100),
	Produto NVARCHAR(100),
	Quantidade INT
)

INSERT INTO Pedido VALUES
(1, 'João', 'Pizza', 2),
(2, 'Maria', 'Macarrão', 3),
(3, 'Pedro', 'Pizza', 1),
(4, 'Ana', 'Pizza', 1),
(5, 'João', 'Coca-cola', 2),
(6, 'Maria', 'Pepsi', 2)

SELECT Cliente, Produto FROM Pedido WHERE Cliente = 'João'
SELECT Cliente, Produto FROM Pedido WHERE Produto = 'Pizza'
SELECT Cliente, Produto, Quantidade FROM Pedido