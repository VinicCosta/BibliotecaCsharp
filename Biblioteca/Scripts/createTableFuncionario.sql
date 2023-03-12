-- Gerando a tabela FUNCIONARIO
CREATE TABLE Funcionario
(
	ID_MATRICULA INT PRIMARY KEY IDENTITY,
	NOME VARCHAR(100) NOT NULL,
	DATA_NASCIMENTO DATETIME NOT NULL,
	CPF VARCHAR(14) NOT NULL,
	EMAIL VARCHAR(25) NOT NULL,
	SENHA VARCHAR(25) NOT NULL,
	TELEFONE VARCHAR(12) NOT NULL,
	CARGO VARCHAR(35) NOT NULL,
);