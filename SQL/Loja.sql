USE master;
GO

IF DB_ID('Loja') IS NOT NULL
    DROP DATABASE Loja
GO

CREATE DATABASE Loja
GO

USE Loja
GO

CREATE TABLE Cliente(
	ClienteId INT IDENTITY(100, 1),
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(100) UNIQUE,
	CONSTRAINT PK_Cliente PRIMARY KEY (ClienteId)
	-- PK = PRIMARY KEY (Chave primária)
)

CREATE TABLE Pedido(
	PedidoId INT IDENTITY(100, 1),
	DataPedido DATE NOT NULL,
	Valor Decimal(10,2),
	ClienteId INT,
	CONSTRAINT PK_Pedido PRIMARY KEY (PedidoId),
	CONSTRAINT FK_Pedido FOREIGN KEY (ClienteId)
	REFERENCES Cliente(ClienteId) -- ON DELETE CASCADE
	-- FK = FOREIGN KEY (Chave estrangeira)
)

INSERT INTO Cliente VALUES -- (Nome, Email)
('Thiago Augusto', 'titi@senai.com'),
('Kessia Milena', NULL),
('Odirlei', 'odirlei@senai.com')

INSERT INTO Pedido VALUES -- (DataPedido, Valor, ClienteId)
('2025-10-01', '100.80', 100),
('2025-09-10', '49.99', 100),
('2025-09-23', '350.00', 101)

SELECT * FROM Cliente
SELECT * FROM Pedido

-- Ajustar e-mail de cliente
UPDATE Cliente SET Email = 'kessia@senai.com'
WHERE ClienteId = 101

-- Atualizar o valor de um pedido
UPDATE Pedido SET Valor = Valor + '10.00'
WHERE PedidoId = 101
SELECT * FROM Pedido

-- Renomear a tabela Cliente para Funcionario
EXEC sp_rename 'Cliente', 'Funcionario'

-- Renomear a coluna ClienteId para FuncionarioId
EXEC sp_rename 'Funcionario.ClienteId', 'Funcionario.FuncionarioId', 'COLUMN'
SELECT * FROM Funcionario

-- Alterar tamanho do tipo de dado
ALTER TABLE Funcionario
ALTER COLUMN Nome VARCHAR(150) NOT NULL

-- Ver a estrutura da tabela
EXEC sp_help 'Funcionario'

-- Apagando a chave primária (PK) da tabela Pedido
ALTER TABLE Pedido
DROP CONSTRAINT PK_Pedido
SELECT * FROM Pedido

-- Recriando a chave primária
ALTER TABLE Pedido
ADD CONSTRAINT PK_Pedido PRIMARY KEY (PedidoId)
SELECT * FROM Pedido

-- Apagando a chave estrangeira (FK) da tabela Pedido
-- ON DELETE CASCADE
ALTER TABLE Pedido
DROP CONSTRAINT FK_Pedido

-- Recriando a chave estrangeira
ALTER TABLE Pedido
ADD CONSTRAINT FK_Pedido_Cliente
FOREIGN KEY (ClienteId) REFERENCES Funcionario(FuncionarioId)
ON DELETE CASCADE

SELECT * FROM Funcionario
SELECT * FROM Pedido

-- Deletar um funcionario
DELETE Funcionario
WHERE FuncionarioId = 105

-- Adicionar novas colunas
ALTER TABLE Funcionario
ADD Cargo VARCHAR(50)
SELECT * FROM Funcionario