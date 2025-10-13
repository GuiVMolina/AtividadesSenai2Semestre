USE master;
GO

IF DB_ID('Vendas') IS NOT NULL
    DROP DATABASE Vendas
GO

-- BANCO DE DADOS - Vendas
CREATE DATABASE Vendas;
GO

USE Vendas;
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
    DataCadastro DATE NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME())
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
    DataPedido DATE NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME()),
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
    @DataCadastro DATE
AS
BEGIN
    SET NOCOUNT ON -- Não mostra informação de linha afetadas
    INSERT INTO Cliente(Nome, Sobrenome, Email, Telefone, DataCadastro)
    VALUES (@Nome, @Sobrenome, @Email, @Telefone, @DataCadastro)
END
GO

-- Testando Procedure 1
EXEC InserirCliente 'Ana', 'Souza', 'ana@email.com', '11999999999', '2025-10-13'
GO

SELECT * FROM Cliente

-- Procedure 2: Inserir Pedido
CREATE PROCEDURE InserirPedido
    @ClienteId INT,
    @DataPedido DATE,
    @ValorTotal DECIMAL(10,2),
    @StatusId INT
AS
BEGIN
    SET NOCOUNT ON
    INSERT INTO Pedido (ClienteID, DataPedido, ValorTotal, StatusID)
    VALUES (@ClienteId, @DataPedido, @ValorTotal, @StatusId)
END
GO

-- Testando Procedure 2