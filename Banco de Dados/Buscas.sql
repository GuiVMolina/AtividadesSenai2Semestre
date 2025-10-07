-- COUNT: Contar o total de registros
SELECT * FROM Leitor;

SELECT COUNT(*) AS QtdLeitores
FROM Leitor;

SELECT * FROM Emprestimo;

-- COUNT + GROUP BY
-- Fun��o agregada precisa do GROUP BY para mais atributos
SELECT l.nome, COUNT(id_emprestimo) AS QtdEmprestimo
FROM Emprestimo e
JOIN Leitor l ON l.id_Leitor =e.id_Leitor
GROUP BY l.nome;

-- MIN / MAX
SELECT Ano FROM Livro;

SELECT MIN(Ano) AS MenorAno FROM Livro;
SELECT MAX(Ano) AS MaiorAno FROM Livro;

----------------------
-- FUN��ES de TEXTO --
----------------------

-- LEN
-- Retorna quantidade de caracteres (incluindo espa�os)
SELECT LEN('K�ssia') AS TamanhoString;
SELECT nome, LEN(nome) FROM Autor;

-- UPPER / LOWER
-- Retorna em mai�sculo (UPPER) ou min�sculo (LOWER) o valor exibido
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
-- Localizar a posi��o de alguma palavra
SELECT titulo, CHARINDEX('de', titulo) AS PosicaoTexto
FROM Livro;

-- CONCAT
-- Concatenar os textos
-- SELECT e.id_Emprestimo, le.nome, li.titulo -- SELECT Padr�o
SELECT CONCAT ('Empr�stimo ', e.id_Emprestimo, ' - Leitor: ', le.nome, ' - Livro: ', li.titulo)
FROM Emprestimo e
JOIN Leitor le ON le.id_Leitor = e.id_Leitor
JOIN Livro li ON li.id_Livro = e.id_Livro

-- SUBSTRING
-- Mostra o texto conforme o tamanho inserido
SELECT SUBSTRING(titulo, 1, 10)
FROM Livro;

-- RTRIM / LTRIM / TRIM
-- Remove espa�os da direita (RTRIM), esquerda (LTRIM) e em ambos os lados (TRIM)
SELECT Nome, RTRIM(nome), LTRIM(nome), TRIM(nome)
FROM Leitor;

----------------------------
-- Fun��es de data e hora --
----------------------------

-- GETDATE
-- Dia e hora atual (Local atual)
SELECT GETDATE();

-- SYSDATETIMEOFFSET
-- Dia e hora atual (Zona espec�fica)
SELECT SYSDATETIMEOFFSET()
AT TIME ZONE 'E. South America Standard Time';