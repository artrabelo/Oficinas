-- 
--  Oficina 3.1 do curso de Fundamentos de Desenvolvimento de Aplicações com Visual C#
--
--  [x] Implementar as tabelas informadas e seus respectivos campos:
--     - ALUNO (matricula, nome, curso, data_nascimento)
--     - TURMA (nr_turma, nometurma, sala, horario)
--  [x] Inserir 3 registros em cada uma das tabelas.
--

CREATE DATABASE BDCursos;
USE BDCursos;

CREATE TABLE Aluno (
matricula int not null primary key,
nome varchar(30) not null,
curso varchar(30) not null,
data_nascimento date not null
);

CREATE TABLE Turma (
nr_turma int not null primary key,
nometurma char(2) not null,
sala int not null,
horario varchar(30)
);

INSERT INTO Aluno(matricula,nome,curso,data_nascimento)
VALUES
(20210222,'Artur','Desenvolvimento em Visual C#','1995-05-15'),
(20210221,'Clarissa','Programação para Android','1998-02-12'),
(20210220,'Caroline','Desenvolvimento em Python','1996-03-20');

INSERT INTO Turma(nr_turma,nometurma,sala,horario)
VALUES
(192020,'A3',201,'Segunda e quarta, 18h-20h30'),
(192032,'A1',102,'Fins de semana, 8h-10h'),
(192030,'B2',101,'Terça e quinta, 8h-9h');

SELECT * FROM Aluno;
SELECT * FROM Turma;