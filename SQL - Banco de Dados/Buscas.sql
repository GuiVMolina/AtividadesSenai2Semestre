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
	(2, 'Memórias Póstumas de Brás Cubas', 1881, 1),
	(3, 'A hora da estrela', 1977, 2),
	(4, 'O sonho de uma noite de verão', 1600, 4),		
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
	(2, 4, 4, '2025-08-27', '2025-09-05'), -- Késsia pegou o sonho de uma noite
	(3, 1, 2, '2025-05-01', '2025-06-10'); -- Caique pegou Dom casmurro
GO

-- COUNT: Contar o total de registros
SELECT * FROM Leitor;

SELECT COUNT(*) AS QtdLeitores
FROM Leitor;

SELECT * FROM Emprestimo;

-- COUNT + GROUP BY
-- Função agregada precisa do GROUP BY para mais atributos
SELECT l.nome, COUNT(id_emprestimo) AS QtdEmprestimo
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor =e.id_Leitor
GROUP BY l.nome;

-- MIN / MAX
SELECT Ano FROM Livro;

SELECT MIN(Ano) AS MenorAno FROM Livro;
SELECT MAX(Ano) AS MaiorAno FROM Livro;

----------------------
-- FUNÇÕES DE TEXTO --
----------------------

-- LEN
-- Retorna quantidade de caracteres (incluindo espaços)
SELECT LEN('Késsia') AS TamanhoString;
SELECT nome, LEN(nome) FROM Autor;

-- UPPER / LOWER
-- Retorna em maiúsculo (UPPER) ou minúsculo (LOWER) o valor exibido
SELECT UPPER(nome) FROM Leitor;
SELECT LOWER(email) FROM Leitor;

-- LEFT / RIGHT
-- Pega as letras a esquerda (LEFT) ou a direita (RIGHT)
SELECT * FROM Livro;
SELECT LEFT(titulo, 5) AS Primeiros5 FROM Livro;
SELECT RIGHT(titulo, 5) AS Ultimos5 FROM Livro;

-- REPLACE
-- Trocar caracteres
SELECT REPLACE(titulo, 'Harry Potter', 'Hermione')
FROM Livro;

-- CHARINDEX
-- Localizar a posição de alguma palavra
SELECT titulo, CHARINDEX('de', titulo) AS PosicaoTexto
FROM Livro;

-- CONCAT
-- Concatenar os textos
-- SELECT e.id_Emprestimo, le.nome, li.titulo -- SELECT Padrão
SELECT CONCAT('Empréstimo ', e.id_Emprestimo, ' - Leitor: ', le.nome, ' - Livro: ', li.titulo)
FROM Emprestimo e
JOIN Leitor le ON le.id_Leitor = e.id_Leitor
JOIN Livro li ON li.id_Livro = e.id_Livro

-- SUBSTRING
-- Mostra o texto conforme o tamanho inserido
SELECT SUBSTRING(titulo, 1, 10)
FROM Livro;

-- RTRIM / LTRIM / TRIM
-- Remove espaços da direita (RTRIM), esquerda (LTRIM) e em ambos os lados (TRIM)
SELECT Nome, RTRIM(nome), LTRIM(nome), TRIM(nome)
FROM Leitor;

----------------------------
-- FUNÇÕES DE DATA E HORA --
----------------------------

-- GETDATE
-- Dia e hora atual (Local atual)
SELECT GETDATE();

-- SYSDATETIMEOFFSET
-- Dia e hora atual (Zona específica)
SELECT SYSDATETIMEOFFSET()
AT TIME ZONE 'E. South America Standard Time';

USE BIBLIOTECA2

-- DATEADD
-- Adiciona um tempo a mais dentro de uma data
-- YEAR = Ano / MONTH = Mês / DAY = Dia / WEEK = Semana
SELECT id_Emprestimo, data_emprestimo,
DATEADD(YEAR, 7, data_emprestimo) AS PrevisaoDevolucao
FROM Emprestimo

-- Diminuir o tempo
SELECT id_Emprestimo, data_emprestimo,
DATEADD(MONTH, -1, data_emprestimo) AS PrevisaoDevolucao
FROM Emprestimo

-- DATEDIFF
-- Comparação de tempo
SELECT id_emprestimo, data_emprestimo, data_devolucao,
DATEDIFF(DAY, data_emprestimo, ISNULL(data_devolucao, GETDATE())) AS DiasComLivro
FROM Emprestimo -- Se data_devolucao estiver vazio, acrescenta o GETDATE
-- Insere a data atual e compara com a data empréstimo

-- FORMAT
-- Formatar as datas
SELECT FORMAT(data_emprestimo, 'dd-MM-yyyy') AS Emprestimo,
	   FORMAT(data_devolucao, 'dd/MM/yy') AS Devolucao
FROM Emprestimo

-- Extraindo ano, mês e dia de uma data
SELECT YEAR(data_emprestimo) AS Ano,
	   MONTH(data_emprestimo) AS Mes,
	   DAY(data_emprestimo) AS Dia
FROM Emprestimo

-- DATEPART / DATENAME
-- Traz o valor (DATEPART) e o nome (DATENAME) referente a data
SET LANGUAGE Portuguese;
SELECT DATEPART(YEAR, data_emprestimo) AS Ano,
	   DATEPART(WEEKDAY, data_emprestimo) AS DiaSemana,
	   DATENAME(WEEKDAY, data_emprestimo) AS NomeDiaSemana,
	   DATENAME(MONTH, data_emprestimo) AS NomeMes
FROM Emprestimo

------------------------------
-- OPERADORES DE COMPARAÇÃO --
------------------------------

-- Igualdade ( = )
SELECT titulo, ano
FROM Livro
WHERE ano = 2000

-- Diferente ( != ou <> )
SELECT titulo, ano
FROM Livro
WHERE ano != 2000

-- Diferente - NOT LIKE
SELECT nome, email
FROM Leitor
WHERE email NOT LIKE 'kes%'

-- Maior que ( > )
SELECT titulo, ano
FROM Livro
WHERE ano > 1900

-- Menor que ( < )
SELECT titulo, ano
FROM Livro
WHERE ano < 1900

-- Maior ou igual ( >= )
SELECT id_emprestimo, data_emprestimo
FROM Emprestimo
WHERE data_emprestimo >= '2025-09-01'

-- Menor ou igual ( <= )
SELECT id_emprestimo, data_emprestimo
FROM Emprestimo
WHERE data_emprestimo <= '2025-08-31'

------------------------
-- OPERADORES LÓGICOS --
------------------------

-- AND (Duas ou mais condições verdadeiras)
SELECT emprestimo.id_Emprestimo, leitor.nome,
emprestimo.data_emprestimo, emprestimo.data_devolucao
FROM Emprestimo
JOIN Leitor ON leitor.id_Leitor = Emprestimo.id_Leitor
WHERE MONTH(emprestimo.data_emprestimo) = 9
AND YEAR(emprestimo.data_emprestimo) = 2025

-- OR (Uma ou outra condição verdadeira)
SELECT l.titulo, l.ano, a.nome
FROM Livro l
JOIN Autor a ON a.id_Autor = l.id_Autor
WHERE a.nome = 'Machado de Assis'
OR a.nome = 'Clarice Lispector'

-- NOT (Negação da condição)
SELECT l.titulo, l.ano, a.nome
FROM Livro l
JOIN Autor a ON a.id_Autor = l.id_Autor
WHERE NOT a.nome = 'Shakespeare'

--------------------------
-- OPERADORES ESPECIAIS --
--------------------------

-- BETWEEN
-- Verifica uma lista entre valores
SELECT titulo, ano
FROM Livro
WHERE ano BETWEEN 1900 AND 2000

-- IN 
-- Verifica uma lista de valores
SELECT * FROM Autor
WHERE nome IN ('Machado de Assis', 'Shakespeare')

-- LIKE
-- Verifica valores com determinada condição de texto
SELECT titulo
FROM Livro
WHERE titulo LIKE '%O%'
-- '%' antes da letra - existe texto antes da letra
-- '%' depois da letra - existe texto depois da letra
-- '%' entre a letra - existe texto antes e depois da letra

-- IS NULL
-- Registros vazios
SELECT id_Emprestimo, id_livro, data_emprestimo
FROM Emprestimo
WHERE data_devolucao IS NULL

-- IS NOT NULL
-- Registros não vazios
SELECT id_Emprestimo, id_livro, data_emprestimo
FROM Emprestimo
WHERE data_devolucao IS NOT NULL