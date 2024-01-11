-- 1 - CRIAR O BANCO
CREATE DATABASE programacao_do_zero;

-- USAR O BANCO
USE programacao_do_zero;

-- CRIAR TABELA USUÁRIO
CREATE TABLE usuario(
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(50) NOT NULL,
	sobrenome VARCHAR(150) NOT NULL,
	telefone VARCHAR(15) NOT NULL,
	email VARCHAR(50) NOT NULL,
	genero VARCHAR(20) NOT NULL,
	senha VARCHAR(30) NOT NULL,
	PRIMARY KEY (id)
);

-- CRIAR TABELA ENDERECO
CREATE TABLE endereco(
	id INT NOT NULL AUTO_INCREMENT,
	rua VARCHAR(250) NOT NULL,
	numero VARCHAR(30) NOT NULL,
	bairro VARCHAR(150) NOT NULL,
	cidade VARCHAR(250) NOT NULL,
	complemento VARCHAR(150) NOT NULL,
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(2) NOT NULL,
	PRIMARY KEY (id)
);
-- ALTERAR TABELA ENDERECO 
ALTER TABLE endereco ADD usuario_id INT NOT NULL;]

-- ADICIONAR CHAVE ESTRANGEIRA 
ALTER TABLE endereco ADD CONSTRAINT FK_usuario FOREIGN KEY (usuario_id) REFERENCES usuario(id);

-- INSERIR USUÁRIOS
INSERT INTO usuario(nome, 
sobrenome, telefone, email, genero, senha) 
VALUES 
('Junior', 'Nascimento', '(84) 981035313', 'juniornascimento1608@gmail.com', 'Masculino', 'teste123')

INSERT INTO usuario(nome, 
sobrenome, telefone, email, genero, senha) 
VALUES 
('Joao', 'Batista', '(84) 981038423', 'Jb.dev@gmail.com', 'Masculino', 'testando123')

-- SELECIONAR TODOS USUÁRIO
SELECT * FROM usuario;

-- SELECIONAR UM USUÁRIO ESPECÍFICO
SELECT * FROM usuario WHERE email = 'juniornascimento1608@gmail.com';

-- ALTERAR USUÁRIO
UPDATE usuario SET email = 'Jb.dev@gmail.com' WHERE id = 3;

-- EXCLUIR USUÁRIO
DELETE FROM usuario WHERE ID = 3;