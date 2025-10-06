-- DDL - Linguagem de definição de dados

-- APAGAR BASE DE DADOS (caso exista)
USE master;
GO

IF DB_ID('Clinica_Medica') IS NOT NULL
    DROP DATABASE Clinica_Medica;
GO

-- CRIAR A BASE DE DADOS (Clínica médica)
CREATE DATABASE Clinica_Medica;
GO

USE Clinica_Medica;
GO

DROP TABLE IF EXISTS Consulta;
DROP TABLE IF EXISTS Medico;
DROP TABLE IF EXISTS Paciente;
GO

-- TABLE PACIENTE
CREATE TABLE Paciente(
	CPF VARCHAR(14) PRIMARY KEY,
	Nome VARCHAR(40),
	Telefone VARCHAR(30),
	NumeroPlano INT,
	NomePlano VARCHAR(20),
	TipoPlano VARCHAR(10)
);
GO

-- EX1 - Inserir dados na tabela Paciente
-- Adicione pelo menos seis pacientes diferentes
INSERT INTO Paciente (CPF, Nome, Telefone, NumeroPlano, NomePlano, TipoPlano) VALUES
('111.111.111-11', 'Pedro', '(11) 11111-1111', 1, 'Platinum', 'P'),
('222.222.222-22', 'Maria', '(22) 22222-2222', 2, 'Platinum', 'P'),
('333.333.333-33', 'João', '(33) 33333-333', 3, 'Gold', 'G'),
('444.444.444-22', 'Ana', '(44) 44444-4444', 4, 'Gold', 'G'),
('555.555.555-55', 'Guilherme', '(55) 55555-5555', 5, 'Silver', 'S'),
('666.666.666-66', 'Carlos', '(66) 66666-6666', 6, 'Silver', 'S');
GO

-- TABLE MEDICO
CREATE TABLE Medico(
	CRM INT PRIMARY KEY,
	NomeMedico VARCHAR(30),
	Especialidade VARCHAR(20)
);
GO

-- EX2 - Inserir dados na tabela Medico
-- Adicione pelo menos cinco médicos com especialidades distintas
-- <-- Adicionei também o CRM 600 aqui para que a inserção de consultas que usam 600 funcione -->
INSERT INTO Medico (CRM, NomeMedico, Especialidade) VALUES
(100, 'Pedro', 'Cardiologista'),
(200, 'Mariana', 'Enfermeira'),
(300, 'Allan', 'Psiquiatra'),
(400, 'Rosa', 'Pediatra'),
(500, 'Paula', 'Endocrinologista'),
(600, 'Yasmin', 'Psiquiatra'); -- adicionado para corresponder à consulta com CRM = 600
GO

-- TABLE CONSULTA
CREATE TABLE Consulta(
	NumeroConsulta INT PRIMARY KEY IDENTITY(100, 1),
	DataConsulta DATE,
	HorarioConsulta TIME,
	CRM_Medico INT FOREIGN KEY REFERENCES Medico(CRM),
	CPF_Paciente VARCHAR(14) FOREIGN KEY REFERENCES Paciente(CPF)
);
GO

-- EX3 - Inserir consultas médicas
-- Agende consultas para diferentes pacientes com diferentes médicos
INSERT INTO Consulta (DataConsulta, HorarioConsulta, CRM_Medico, CPF_Paciente) VALUES
('2025-01-01','09:00:00',100,'111.111.111-11'),
('2025-02-02','10:00:00',200,'222.222.222-22'),
('2025-03-03','11:00:00',300,'333.333.333-33'),
('2025-04-04','14:30:00',400,'444.444.444-22'),
('2025-05-05','15:45:00',500,'555.555.555-55'),
('2025-06-06','08:00:00',600,'666.666.666-66');
GO

-- EX4 - Listar todos os pacientes cadastrados
SELECT CPF, Nome, Telefone, NumeroPlano, NomePlano, TipoPlano FROM Paciente;
GO

-- EX5 - Listar todos os médicos e suas especialidades
SELECT CRM, NomeMedico, Especialidade FROM Medico;
GO

-- EX6 - Buscar todas as consultas agendadas.
-- Exibir o número da consulta, a data, o horário, o nome do paciente e o nome do médico
-- INNER JOIN / JOIN
SELECT c.NumeroConsulta, c.DataConsulta, c.HorarioConsulta, p.Nome AS NomePaciente, m.NomeMedico AS NomeMedico
FROM Consulta c
INNER JOIN Paciente p ON c.CPF_Paciente = p.CPF
INNER JOIN Medico m ON c.CRM_Medico = m.CRM;
GO

-- EX7 - Buscar consultas de um paciente específico
-- Filtrar as consultas de um paciente pelo CPF
-- LEFT JOIN
SELECT p.Nome, c.DataConsulta, m.NomeMedico AS NomeMedico
FROM Paciente p
LEFT JOIN Consulta c ON p.CPF = c.CPF_Paciente
LEFT JOIN Medico m ON c.CRM_Medico = m.CRM;
GO

-- EX8 -  Buscar consultas de um médico específico
-- Filtrar as consultas de um médico pelo CRM
-- RIGHT JOIN
SELECT m.NomeMedico, m.Especialidade, c.DataConsulta, p.Nome
FROM Consulta c
RIGHT JOIN Medico m ON c.CRM_Medico = m.CRM
RIGHT JOIN Paciente p ON c.CPF_Paciente = p.CPF;
GO

-- EX9 - Atualizar o número do plano de três pacientes
UPDATE Paciente
SET NumeroPlano = 10, NomePlano = 'Black', TipoPlano = 'B'
WHERE CPF = '111.111.111-11';

UPDATE Paciente
SET NumeroPlano = 11, NomePlano = 'Black', TipoPlano = 'B'
WHERE CPF = '222.222.222-22';

UPDATE Paciente
SET NumeroPlano = 12, NomePlano = 'Black', TipoPlano = 'B'
WHERE CPF = '333.333.333-33';
GO

-- EX10 - Deletar dois pacientes do sistema
DELETE FROM Consulta WHERE CPF_Paciente IN ('555.555.555-55','666.666.666-66');
DELETE FROM Paciente WHERE CPF IN ('555.555.555-55','666.666.666-66');
GO

-- EX11 - Inserir novos dados
-- Cadastre mais três médicos e dois pacientes extras no sistema
INSERT INTO Paciente (CPF, Nome, Telefone, NumeroPlano, NomePlano, TipoPlano) VALUES
('777.777.777-77', 'Elton', '(77) 77777-7777', 7, 'A', 'A'),
('888.888.888-88', 'Marina', '(88) 88888-8888', 8, 'B', 'B');
GO

-- Ajustei estes CRMs para não duplicar o 600 já inserido
INSERT INTO Medico (CRM, NomeMedico, Especialidade) VALUES
(700, 'Ricardo', 'Pediatra'),
(800, 'Fabio', 'Endocrinologista'),
(900, 'Marcos', 'Dermatologista');
GO

-- EX12 - Atualizar informações de médicos
-- Atualize a especialidade de dois médicos já cadastrados
UPDATE Medico
SET Especialidade = 'Neurologista'
WHERE CRM IN (100, 200);
GO