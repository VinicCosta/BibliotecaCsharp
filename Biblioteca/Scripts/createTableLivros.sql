-- Gerando a tabela LIVROS
CREATE TABLE Livros
(
ID_LIVRO INT PRIMARY KEY IDENTITY, 
NOME VARCHAR(100) NOT NULL,
GENERO VARCHAR(25) NOT NULL,
PAGINAS INT NOT NULL,
QUANTIDADE INT NOT NULL,
);