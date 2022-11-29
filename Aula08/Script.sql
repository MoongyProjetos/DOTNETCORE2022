--CRUD


INSERT INTO Alunos (Nome, DataNascimento) VALUES ('Maria', '2000-01-01')


SELECT UPPER(Nome), * --2
FROM Alunos WHERE Nome = 'Joao' --1
ORDER BY Nome DESC	--3

UPDATE Alunos 
SET Nome = 'Joao da Silva'
WHERE Nome = 'Joao'

DELETE FROM Alunos