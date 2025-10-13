USE master;
GO

IF DB_ID('AurumLab') IS NOT NULL
    DROP DATABASE AurumLab
GO

CREATE DATABASE AurumLab
GO

USE AurumLab
GO

CREATE TABLE Regra(
	IdRegra INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(40) NOT NULL UNIQUE
)
GO

CREATE TABLE Usuario(
	IdUsuario		INT IDENTITY (1,1) PRIMARY KEY,
	NomeCompleto	NVARCHAR(120) NOT NULL,
	Email			NVARCHAR(150) NOT NULL UNIQUE,
	Senha			VARBINARY(32) NOT NULL,	-- Armazena a hash da senha
	FotoURL			NVARCHAR(500) NULL,		-- Armazena caminho da url da imagem
	CriadoEm		DATETIME2(0)  NOT NULL DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME()),
	-- Zero casas decimais de segundo
	RegraId			INT NOT NULL,
	CONSTRAINT FK_Usuario_Regra FOREIGN KEY (RegraId) REFERENCES Regra(IdRegra)
)
GO

INSERT INTO Regra (Nome) VALUES
('Aluno'),
('Professor')
GO

SELECT * FROM Regra
GO

DECLARE @RegraId INT -- Declarando uma variável (RegraId)
SET @RegraId = (SELECT idRegra FROM Regra WHERE Nome = 'Aluno') -- RegraId = 1

INSERT INTO Usuario (NomeCompleto, Email, Senha, FotoURL, RegraId) VALUES
('Usuario1', 'usuario1@senai.com', HASHBYTES('SHA2_256', 'senha123'), 'https://imagem.png', @RegraId)
GO

SELECT * FROM Usuario
GO