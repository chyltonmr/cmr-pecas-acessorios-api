
CREATE TABLE marca (
  id CHAR(36) PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE
);

CREATE TABLE categoria (
  id CHAR(36) PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE
);

CREATE TABLE produto (
  id CHAR(36) PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  descricao TEXT,
  estoque INT DEFAULT 0,
  fk_categoria CHAR(36) NOT NULL,
  fk_marca CHAR(36) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (fk_categoria) REFERENCES categoria(id),
  FOREIGN KEY (fk_marca) REFERENCES marca(id)
);

CREATE TABLE tipo_preco (
  id CHAR(36) PRIMARY KEY,
  nome VARCHAR(50) NOT NULL,
  descricao TEXT,
  data_insercao DATE NOT NULL,
  data_desativacao DATE
);

CREATE TABLE preco (
  id CHAR(36) PRIMARY KEY,
  preco DECIMAL(10,2) NOT NULL,
  fk_produto CHAR(36) NOT NULL,
  fk_tipo_preco CHAR(36) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  observacao TEXT,
  FOREIGN KEY (fk_produto) REFERENCES produto(id),
  FOREIGN KEY (fk_tipo_preco) REFERENCES tipo_preco(id)
);

CREATE TABLE custo (
  id CHAR(36) PRIMARY KEY,
  fk_produto CHAR(36) NOT NULL,
  nome VARCHAR(100),
  descricao TEXT,
  custo DECIMAL(10,2) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (fk_produto) REFERENCES produto(id)
);

CREATE TABLE margem_lucro (
  id CHAR(36) PRIMARY KEY,
  porcentagem DECIMAL(5,2) NOT NULL,
  fk_preco CHAR(36) NOT NULL UNIQUE,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (fk_preco) REFERENCES preco(id)
);
