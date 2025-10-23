USE master;
GO

IF DB_ID('BIBLIOTECA2') IS NOT NULL
    DROP DATABASE BIBLIOTECA2
GO

CREATE DATABASE BIBLIOTECA2;
GO

USE BIBLIOTECA2;
GO

CREATE TABLE Autor (
	id_Autor INT PRIMARY KEY,
	nome VARCHAR(100) NOT NULL
	);
GO

CREATE TABLE Livro (
	id_Livro INT PRIMARY KEY,
	titulo VARCHAR(150) NOT NULL,
	ano INT,
	id_Autor INT NOT NULL,
	CONSTRAINT fk_livro_autor FOREIGN KEY (id_Autor) REFERENCES Autor(id_Autor) ON DELETE CASCADE
	);
GO

CREATE TABLE Leitor (
	id_Leitor INT PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR (120) UNIQUE
	);
GO

CREATE TABLE Emprestimo (
	id_Emprestimo INT PRIMARY KEY,
	id_Livro INT NOT NULL,
	id_Leitor INT NOT NULL,
	data_emprestimo DATE NOT NULL, 
	data_devolucao DATE,
	CONSTRAINT fk_empr_livro FOREIGN KEY (id_Livro) REFERENCES Livro(id_Livro) ON DELETE CASCADE,
	CONSTRAINT fk_empr_leitor FOREIGN KEY (id_Leitor) REFERENCES Leitor(id_Leitor) ON DELETE CASCADE
	);
GO

INSERT INTO Autor VALUES -- id_Autor, nome
  (1,'Machado de Assis'),
  (2,'Clarice Lispector'),
  (3,'J. K. Rowling'),
  (4,'Shakespeare');
GO

INSERT INTO Livro VALUES -- id_Livro, titulo, ano, id_Autor, fk_livro_autor
	(1, 'Dom Casmurro', 1899, 1),
	(2, 'Mem�rias P�stumas de Br�s Cubas', 1881, 1),
	(3, 'A hora da estrela', 1977, 2),
	(4, 'O sonho de uma noite de ver�o', 1600, 4),		
	(5, 'Harry Potter e o calice de fogo', 2000, 3);
GO

INSERT INTO Leitor VALUES -- id_Leitor, nome, email
	(1, 'Thiago Oliveira' , 'thiago@gmail.com'),
	(2, 'Caique' , 'caique@gmail.com'),
	(3, 'Odirlei' , 'odi@gmail.com' ),
	(4, 'Kessia', 'kessia@gmail.com');
GO

INSERT INTO Emprestimo VALUES -- id_emprestimo, id_livro, id_leitor, data_empr, data_dev
	(1, 5, 1, '2025-09-02', '2025-09-09'), -- Thiago pegou harry potter
	(2, 4, 4, '2025-08-27', '2025-09-05'), -- K�ssia pegou o sonho de uma noite
	(3, 1, 2, '2025-05-01', '2025-06-10'); -- Caique pegou Dom casmurro
GO

--------------------------
-- 1. Fun��es Agregadas --
--------------------------
-- 1. Quantos livros existem cadastrados na biblioteca?
-- 2. Qual � o ano m�dio de publica��o dos livros?
-- 3. Qual leitor fez o maior n�mero de empr�stimos?

SELECT COUNT(*) AS QuantidadeLivros
FROM Livro

SELECT AVG(ano) AS MediaAno
FROM Livro

SELECT TOP 1
    l.nome AS NomeLeitor,
    COUNT(*) AS QuantidadeEmprestimos
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor = e.id_Leitor
GROUP BY l.id_Leitor, l.nome
ORDER BY COUNT(*) DESC;

-------------------------
-- 2. Fun��es de Texto --
-------------------------
-- 1. Mostre os 3 primeiros caracteres de todos os nomes de autores
-- 2. Exiba os t�tulos de livros com todas as letras em min�sculo
-- 3. Mostre apenas os leitores cujo e-mail termina com `.com`
-- 4. Substitua a palavra �estrela� por �sol� no t�tulo do livro da Clarice Lispector

SELECT SUBSTRING(titulo, 1, 3) AS PrimeirosTres
FROM Livro

SELECT LOWER(titulo) AS TituloEmMinisculo
FROM Livro

SELECT email AS Email
FROM Leitor
WHERE email LIKE '%.com%'

SELECT REPLACE(titulo, 'estrela', 'sol') AS EstrelaPorSol
FROM Livro

-------------------------------
-- 3. Fun��es de Data e Hora --
-------------------------------
-- 1. Mostre os empr�stimos realizados no m�s de agosto de 2025 (mostrar n�mero do m�s)
-- 2. Calcule quantos dias se passaram desde o primeiro empr�stimo registrado at� hoje
-- 3. Mostre a data do empr�stimo e o nome do dia da semana em que ele aconteceu

SELECT l.nome AS NomeLeitor,
	   DATEPART(YEAR, e.data_emprestimo) AS Ano,
	   DATENAME(MONTH, e.data_emprestimo) AS Mes
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor = e.id_Leitor
WHERE MONTH(data_emprestimo) = '08'

SELECT l.nome AS NomeLeitor,
	   e.data_emprestimo AS DataEmprestimo,
	   e.data_devolucao AS DataDevolucao,
	   DATEDIFF(DAY, data_emprestimo, ISNULL(data_devolucao, GETDATE())) AS DiasComLivro
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor = e.id_Leitor

SELECT l.nome AS NomeLeitor,
	   e.data_emprestimo AS DataEmprestimo,
	   DATENAME(WEEKDAY, e.data_emprestimo) AS DiaDaSemana
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor = e.id_Leitor

-------------------------------------------
-- 4. Operadores de Compara��o e L�gicos --
-------------------------------------------
-- 1. Liste os livros publicados entre 1950 e 2005, mas que n�o sejam de J. K. Rowling
-- 2. Mostre todos os leitores que t�m nome come�ando com a letra �C�
-- 3. Mostre os empr�stimos que aconteceram em 2025, mas ainda n�o foram devolvidos
-- 4. Liste os autores que n�o t�m nenhum livro cadastrado no banco (dica: `LEFT JOIN`)

SELECT titulo AS Titulo,
	   ano AS AnoPublicacao
FROM Livro
WHERE ano > 1950
AND ano < 2005

SELECT nome AS NomeComC
FROM Leitor
WHERE nome LIKE 'C%'

SELECT l.nome AS LeitorSemDevolver,
       e.data_emprestimo AS DataEmprestimo,
       e.data_devolucao AS DataDevolucao
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor =  e.id_Leitor
WHERE YEAR(e.data_emprestimo) = 2025
AND e.data_devolucao IS NULL;

SELECT a.nome AS AutorSemLivro
FROM Autor a
LEFT JOIN Livro l ON l.id_Autor = a.id_Autor
WHERE l.id_Livro IS NULL