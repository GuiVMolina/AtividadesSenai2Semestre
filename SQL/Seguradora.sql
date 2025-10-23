-- Script corrigido e seguro: cria o DB no estado final desejado
USE master;
GO

-- Se existir, coloca em single user e dropa para evitar conflitos
IF DB_ID('Seguradora') IS NOT NULL
BEGIN
    ALTER DATABASE Seguradora SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Seguradora;
END
GO

CREATE DATABASE Seguradora;
GO

USE Seguradora;
GO

-- ---------- CRIAÇÃO DAS TABELAS (usar nomes finais: Cliente, ClienteId) ----------
CREATE TABLE Cliente (
    ClienteId INT CONSTRAINT PK_Cliente_ClienteId PRIMARY KEY,
    Nome NVARCHAR(150) NOT NULL,
    CPF VARCHAR(14) CONSTRAINT UQ_Cliente_CPF UNIQUE
);
GO

CREATE TABLE Apolice (
    ID_Apol INT CONSTRAINT PK_Apolice_IDApol PRIMARY KEY,
    Numero INT CONSTRAINT UQ_Apolice_Numero UNIQUE NOT NULL,
    ClienteId INT NOT NULL,
    CONSTRAINT FK_Apolice_Cliente FOREIGN KEY (ClienteId) REFERENCES Cliente(ClienteId)
);
GO

CREATE TABLE Perito (
    ID_Per INT CONSTRAINT PK_Perito_IDPer PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Sinistro (
    ID_Sin INT CONSTRAINT PK_Sinistro_IDSin PRIMARY KEY,
    ID_Apol INT NOT NULL,
    ID_Per INT NULL,
    DataSinistro DATE NOT NULL,
    Valor DECIMAL(10,2),
    CONSTRAINT FK_Sinistro_Apolice FOREIGN KEY (ID_Apol) REFERENCES Apolice(ID_Apol),
    CONSTRAINT FK_Sinistro_Perito FOREIGN KEY (ID_Per) REFERENCES Perito(ID_Per)
);
GO

-- ---------- POPULAÇÃO ----------
INSERT INTO Cliente (ClienteId, Nome, CPF) VALUES
(1, 'Allan', '111.111.111-11'),
(2, 'Giuliano', '222.222.222-22'),
(3, 'Matheus', '333.333.333-33'),
(4, 'Vitor', '444.444.444-44'),
(5, 'João', '555.555.555-55');
GO

INSERT INTO Apolice (ID_Apol, Numero, ClienteId) VALUES
(1, 101, 1),
(2, 202, 1),
(3, 303, 3),
(4, 404, 4),
(5, 505, 5);
GO

INSERT INTO Perito (ID_Per, Nome) VALUES
(1, 'Eduardo'),
(2, 'Natan'),
(3, 'Giovanni'),
(4, 'Pedro'),
(5, 'Gustavo');
GO

INSERT INTO Sinistro (ID_Sin, ID_Apol, ID_Per, DataSinistro, Valor) VALUES
(1, 1, 1, '2025-01-01', 250.00),
(2, 2, 2, '2025-02-02', 500.00),
(3, 3, 3, '2025-03-03', 750.00),
(4, 4, 4, '2025-04-04', 1000.00),
(5, 5, 5, '2025-05-05', 1250.00);
GO

-- ---------- EXEMPLOS DE UPDATEs ----------
UPDATE Cliente
SET Nome = 'Marina', CPF = '666.666.666-66'
WHERE ClienteId = 3;
GO

UPDATE Apolice
SET Numero = 606
WHERE ID_Apol = 3;
GO

UPDATE Sinistro
SET DataSinistro = '2025-06-06'
WHERE ID_Sin = 3;
GO

-- ---------- RECRIAR FK COM ON DELETE CASCADE ----------

-- Primeiro dropamos a FK atual se quisermos testar CASCADE (aqui renomeei a FK ao criar: FK_Apolice_Cliente)
ALTER TABLE Apolice
DROP CONSTRAINT FK_Apolice_Cliente;
GO

ALTER TABLE Apolice
ADD CONSTRAINT FK_Apolice_Cliente FOREIGN KEY (ClienteId) REFERENCES Cliente(ClienteId) ON DELETE CASCADE;
GO

-- ---------- SELECTs para verificação ----------
SELECT c.ClienteId, c.Nome, c.CPF, a.ID_Apol, a.Numero
FROM Cliente c
LEFT JOIN Apolice a ON a.ClienteId = c.ClienteId;
GO

SELECT c.Nome AS Segurado, c.CPF, p.Nome AS NomePerito, a.Numero AS NumeroApolice, si.DataSinistro, si.Valor
FROM Sinistro si
INNER JOIN Apolice a ON si.ID_Apol = a.ID_Apol
INNER JOIN Cliente c ON a.ClienteId = c.ClienteId
LEFT JOIN Perito p ON si.ID_Per = p.ID_Per;
GO

-- ---------- TESTE DO ON DELETE CASCADE (opcional: descomente para testar) ----------
-- SELECT * FROM Cliente WHERE ClienteId = 5;
-- SELECT * FROM Apolice WHERE ClienteId = 5;
-- DELETE FROM Cliente WHERE ClienteId = 5;  -- isto deve remover as apólices com ClienteId = 5
-- SELECT * FROM Apolice WHERE ClienteId = 5; -- deve retornar 0 linhas
-- GO

-- FULL OUTER JOIN
-- Retorna todos os registros das duas tabelas, combinando onde houver correspondência e colocando NULL onde não houver
SELECT c.Nome, a.Numero
FROM Cliente c
FULL OUTER JOIN Apolice a ON c.ClienteId = a.ClienteId

-- CROSS JOIN
-- Faz a combinação cartesiana: todos os registros da tabela A com todos da tabela B
SELECT c.Nome, p.Nome
FROM Cliente c
CROSS JOIN Perito p

SELECT * FROM Cliente
SELECT * FROM Apolice
SELECT * FROM Sinistro
SELECT * FROM Perito