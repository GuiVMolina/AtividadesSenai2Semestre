-- ====== Create/Drop do banco ====== --
USE master;
GO

IF DB_ID('bdProcedureTrigger') IS NOT NULL
    DROP DATABASE bdProcedureTrigger;
GO

CREATE DATABASE bdProcedureTrigger;
GO

USE bdProcedureTrigger;
GO

-- ====== Remover objetos que podem existir de execuções anteriores ====== --
DROP TRIGGER IF EXISTS trg_AuditoriaCliente;
DROP TRIGGER IF EXISTS trg_AtualizarEstoque;
DROP TRIGGER IF EXISTS trg_PrevenirExclusaoProdutos;
GO

DROP PROCEDURE IF EXISTS InserirCliente;
DROP PROCEDURE IF EXISTS InserirPedido;
DROP PROCEDURE IF EXISTS AtualizarPrecoProduto;
DROP PROCEDURE IF EXISTS ObterTotalVendas;
DROP PROCEDURE IF EXISTS VendasPorCliente;
DROP PROCEDURE IF EXISTS AtualizarPrecoProdutoComHistorico;
GO

DROP TABLE IF EXISTS Auditoria_Cliente;
DROP TABLE IF EXISTS HistoricoPrecos;
DROP TABLE IF EXISTS DetalhesPedido;
DROP TABLE IF EXISTS Pedido;
DROP TABLE IF EXISTS Produto;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Categoria;
DROP TABLE IF EXISTS StatusPedido;
GO

CREATE TABLE StatusPedido (
    StatusId INT IDENTITY(1,1) PRIMARY KEY,
    Nome     VARCHAR(40) NOT NULL
);
GO

CREATE TABLE Categoria (
    CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
    Nome        VARCHAR(60) NOT NULL
);
GO

CREATE TABLE Cliente (
    ClienteID    INT IDENTITY(1,1) PRIMARY KEY,
    Nome         VARCHAR(50) NOT NULL,
    Sobrenome    VARCHAR(50) NOT NULL,
    Email        VARCHAR(100) UNIQUE,
    Telefone     VARCHAR(20),
    DataCadastro DATETIME2(0) NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME())
);
GO

CREATE TABLE Produto (
    ProdutoID          INT IDENTITY(1,1) PRIMARY KEY,
    CategoriaID        INT NOT NULL,
    Nome               VARCHAR(120) NOT NULL,
    Preco              DECIMAL(10,2) NOT NULL CHECK (Preco >= 0),
    QuantidadeEstoque  INT NOT NULL CHECK (QuantidadeEstoque >= 0),
    CONSTRAINT FK_Produto_Categoria FOREIGN KEY (CategoriaID) REFERENCES Categoria(CategoriaID)
);
GO

CREATE TABLE Pedido (
    PedidoID   INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID  INT NOT NULL,
    DataPedido DATETIME2(0) NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME()),
    ValorTotal DECIMAL(10,2) NOT NULL DEFAULT 0,
    StatusID   INT NOT NULL,
    CONSTRAINT FK_Pedido_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
    CONSTRAINT FK_Pedido_Status  FOREIGN KEY (StatusID)  REFERENCES StatusPedido(StatusId)
);
GO

CREATE TABLE DetalhesPedido (
    DetalheID     INT IDENTITY(1,1) PRIMARY KEY,
    PedidoID      INT NOT NULL,
    ProdutoID     INT NOT NULL,
    Quantidade    INT NOT NULL CHECK (Quantidade > 0),
    PrecoUnitario DECIMAL(10,2) NOT NULL CHECK (PrecoUnitario >= 0),
    CONSTRAINT FK_Detalhes_Pedido  FOREIGN KEY (PedidoID)  REFERENCES Pedido(PedidoID),
    CONSTRAINT FK_Detalhes_Produto FOREIGN KEY (ProdutoID) REFERENCES Produto(ProdutoID)
);
GO

-- INSERINDO DADOS

INSERT INTO StatusPedido (Nome) VALUES 
('Novo'), 
('Enviado'), 
('Cancelado');
GO

INSERT INTO Categoria (Nome) VALUES 
('Informática'), 
('Acessórios');
GO

INSERT INTO Cliente (Nome, Sobrenome, Email, Telefone, DataCadastro) VALUES
('João', 'Silva', 'joao@email.com', '11999999999', '2025-04-09');
GO

INSERT INTO Produto (CategoriaID, Nome, Preco, QuantidadeEstoque) VALUES
(1, 'Notebook X', 4500.00, 10),
(2, 'Mouse Óptico', 50.00, 100);
GO

----------------
-- PROCEDURES --
----------------

-- Procedure 1: Inserir Cliente
CREATE PROCEDURE InserirCliente
    @Nome VARCHAR(50),
    @Sobrenome VARCHAR(50),
    @Email VARCHAR(100),
    @Telefone VARCHAR(20),
    @DataCadastro DATETIME2(0)
AS
BEGIN
    SET NOCOUNT ON; -- Não mostra informação de linhas afetadas
    INSERT INTO Cliente(Nome, Sobrenome, Email, Telefone, DataCadastro)
    VALUES (@Nome, @Sobrenome, @Email, @Telefone, @DataCadastro);
END
GO

-- Testando Procedure 1
EXEC InserirCliente 'Ana', 'Souza', 'ana@email.com', '11999999999', '2025-10-13';
GO

SELECT * FROM Cliente;
GO

-- Procedure 2: Inserir Pedido
CREATE PROCEDURE InserirPedido
    @ClienteId INT,
    @DataPedido DATETIME2(0),
    @ValorTotal DECIMAL(10,2),
    @StatusId INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Pedido (ClienteID, DataPedido, ValorTotal, StatusID)
    VALUES (@ClienteId, @DataPedido, @ValorTotal, @StatusId);
END
GO

-- Testando Procedure 2
EXEC InserirPedido 2, '2025-10-13', 250.00, 1;
GO

SELECT * FROM Pedido;
GO

-- Procedure 3: Atualizar preço de produto
CREATE PROCEDURE AtualizarPrecoProduto
    @ProdutoId INT,
    @PercentualAumento DECIMAL(5,2)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Produto
        SET Preco = Preco * (1 + @PercentualAumento / 100.00)
    WHERE ProdutoID = @ProdutoId;
END
GO

-- Testando Procedure 3
SELECT * FROM Produto -- Antes: Mouse = 50
GO

EXEC AtualizarPrecoProduto 2, 10
GO

SELECT * FROM Produto -- Depois: Mouse = 55
GO

-- Procedure 4: Total de vendas por cliente (saída)
-- (Removi o "USE Vendas" — a procedure será criada no banco atual bdProcedureTrigger)
CREATE PROCEDURE ObterTotalVendas
    @ClienteId INT,
    @TotalVendas DECIMAL(10,2) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @TotalVendas = COALESCE(SUM(ValorTotal), 0)
    FROM Pedido
    WHERE ClienteID = @ClienteId;
END
GO

-- Testando Procedure 4
DECLARE @Total DECIMAL(10,2);
EXEC ObterTotalVendas 1, @Total OUTPUT;
SELECT @Total AS TotalDeVendas;
GO

-- Procedure 5: Relatório de Vendas por Cliente
CREATE PROCEDURE VendasPorCliente
    @DataLimite DATE
AS
BEGIN
    SET NOCOUNT ON;
        
    SELECT C.ClienteID, C.Nome,
           SUM(D.Quantidade * D.PrecoUnitario) AS TotalGasto
    FROM Cliente C
    JOIN Pedido P ON P.ClienteID = C.ClienteID
    JOIN DetalhesPedido D ON D.PedidoID = P.PedidoID
    WHERE P.DataPedido < @DataLimite
    GROUP BY C.ClienteID, C.Nome;
END
GO

-- Testando Procedure 5
INSERT INTO DetalhesPedido(PedidoID, ProdutoID, Quantidade, PrecoUnitario) VALUES
(1, 1, 1, 4500.00);
GO

EXEC VendasPorCliente '2025-10-14';
GO

SELECT * FROM Pedido;
GO

-- Procedure 6: Histórico de preço com tabela própria
CREATE TABLE HistoricoPrecos (
    HistoricoId INT IDENTITY(1,1) PRIMARY KEY,
    ProdutoID INT NOT NULL,
    PrecoAntigo DECIMAL(10,2),
    PrecoNovo DECIMAL(10,2),
    DataModificacao DATETIME2(0),
    CONSTRAINT FK_Historico_Produto FOREIGN KEY (ProdutoID) REFERENCES Produto(ProdutoID)
);
GO

CREATE PROCEDURE AtualizarPrecoProdutoComHistorico
    @ProdutoId INT,
    @NovoPreco DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @PrecoAntigo DECIMAL(10,2);

    SELECT @PrecoAntigo = Preco
    FROM Produto
    WHERE ProdutoID = @ProdutoId;

    UPDATE Produto SET Preco = @NovoPreco
    WHERE ProdutoID = @ProdutoId;

    INSERT INTO HistoricoPrecos (ProdutoID, PrecoAntigo, PrecoNovo, DataModificacao) VALUES
    (@ProdutoId, @PrecoAntigo, @NovoPreco, DATEADD(HOUR, -3, SYSUTCDATETIME()));
END
GO

-- Testando Procedure 6
EXEC AtualizarPrecoProdutoComHistorico 2, 75.00;
GO

SELECT * FROM Produto;
SELECT * FROM HistoricoPrecos;
GO

--------------
-- Triggers --
--------------

-- Trigger 1: Auditoria Clientes inseridos
CREATE TABLE Auditoria_Cliente (
    AuditoriaId INT IDENTITY(1,1) PRIMARY KEY,
    ClienteID INT NOT NULL,
    DataInsercao DATETIME2(0),
    CONSTRAINT FK_Auditoria_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID)
);
GO

CREATE TRIGGER trg_AuditoriaCliente
ON Cliente -- Tabela que vai disparar a trigger
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Auditoria_Cliente(ClienteID, DataInsercao)
    SELECT ClienteID, DATEADD(HOUR, -3, SYSUTCDATETIME())
    FROM inserted; -- Armazena insert de forma temporária
END
GO

-- INSERT INTO Cliente (Nome, Sobrenome, Email, Telefone, DataCadastro) VALUES
-- ('João', 'Silva', 'joao@email.com', '11999999999', '2025-04-09'),
-- ('Ana', 'Souza', 'ana@email.com', '11999999999', '2025-10-13');
-- GO

-- Testando Trigger 1
INSERT INTO Cliente(Nome, Sobrenome, Email, Telefone, DataCadastro) VALUES
('Carlos', 'Pereira', 'carlos@email.com', '11999999999', '2025-10-14');
GO

SELECT * FROM Auditoria_Cliente;
SELECT * FROM Cliente;
GO

-- Trigger 2: Atualizar o estoque ao inserir um pedido
CREATE TRIGGER trg_AtualizarEstoque
ON DetalhesPedido
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE p
    SET QuantidadeEstoque = p.QuantidadeEstoque - i.Quantidade
    FROM Produto p
    JOIN inserted i ON p.ProdutoID = i.ProdutoID;
END
GO

-- Testando Trigger 2
SELECT * FROM Produto;
SELECT * FROM Pedido;
SELECT * FROM DetalhesPedido;
GO

INSERT INTO DetalhesPedido (PedidoID, ProdutoID, Quantidade, PrecoUnitario) VALUES
(1, 2, 3, 75.0);
GO

-- Trigger 3: Prevenir exclusão de produto com pedidos (Solução B estendida)
CREATE OR ALTER TRIGGER trg_PrevenirExclusaoProdutos
ON Produto
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;
    -- Remove primeiro os detalhes do pedido relacionados ao produto
    DELETE FROM DetalhesPedido
    WHERE ProdutoID IN (SELECT ProdutoID FROM deleted);
    -- Remove o histórico de preços relacionado ao produto
    DELETE FROM HistoricoPrecos
    WHERE ProdutoID IN (SELECT ProdutoID FROM deleted);
    -- Remove o produto com segurança
    DELETE FROM Produto
    WHERE ProdutoID IN (SELECT ProdutoID FROM deleted);
END
GO

-- Testando Trigger 3
DELETE FROM Produto WHERE ProdutoID = 2;
GO

SELECT * FROM DetalhesPedido;
GO

-- Trigger 4: Criar log de Funcionários
CREATE TABLE Funcionario(
    FuncionarioId INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100),
    CPF VARCHAR(14) UNIQUE
);
GO

CREATE TABLE LogFuncionario(
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    FuncionarioId INT NULL,
    Nome VARCHAR(100),
    DataCadastro DATETIME2(0) DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME()),
    CONSTRAINT FK_LogFuncionario_Funcionario FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(FuncionarioId)
);
GO

CREATE TRIGGER trg_LogFuncionario
ON Funcionario
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LogFuncionario(FuncionarioId, Nome)
    SELECT FuncionarioId, Nome FROM inserted;
END
GO

INSERT INTO Funcionario (Nome, CPF) VALUES
('Kessia','13312548555');
GO

SELECT * FROM Funcionario;
GO

SELECT * FROM LogFuncionario;
GO