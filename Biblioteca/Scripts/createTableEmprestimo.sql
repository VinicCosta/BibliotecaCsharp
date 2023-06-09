-- Gerando a tabela EMPRESTIMO
CREATE TABLE Emprestimo
(
ID_EMPRESTIMO INT PRIMARY KEY, 
ID_LIVRO INT,
CONSTRAINT fk_LivEmprestimo FOREIGN KEY (ID_LIVRO) REFERENCES Livros (ID_LIVRO),
QUANTIDADE INT NOT NULL,
DATA_RETIRADA DATETIME NOT NULL,
DATA_ENTREGA DATETIME,
DATA_DEVOLUCAO DATETIME,
ENTREGUE VARCHAR(3) DEFAULT 'nao'
);