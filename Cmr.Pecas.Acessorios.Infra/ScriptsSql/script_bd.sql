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
  imagem_thumbnail VARCHAR(300),
  descricao TEXT,
  estoque INT DEFAULT 0,
  id_categoria CHAR(36) NOT NULL,
  id_marca CHAR(36) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (id_categoria) REFERENCES categoria(id),
  FOREIGN KEY (id_marca) REFERENCES marca(id)
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
  preco_pj DECIMAL(10,2) NOT NULL,
  preco_pf DECIMAL(10,2) NOT NULL,
  id_produto CHAR(36) NOT NULL,
  id_tipo_preco CHAR(36) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  observacao TEXT,
  FOREIGN KEY (id_produto) REFERENCES produto(id),
  FOREIGN KEY (id_tipo_preco) REFERENCES tipo_preco(id)
);

CREATE TABLE custo (
  id CHAR(36) PRIMARY KEY,
  id_produto CHAR(36) NOT NULL,
  nome VARCHAR(100),
  descricao TEXT,
  custo DECIMAL(10,2) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (id_produto) REFERENCES produto(id)
);

CREATE TABLE margem_lucro (
  id CHAR(36) PRIMARY KEY,
  porcentagem_pj DECIMAL(5,2) NOT NULL,
  porcentagem_pf DECIMAL(5,2) NOT NULL,
  valor_liquido_pj DECIMAL(5,2) NOT NULL,
  valor_liquido_pf DECIMAL(5,2) NOT NULL,
  id_preco CHAR(36) NOT NULL UNIQUE,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (id_preco) REFERENCES preco(id)
);


CREATE TABLE cliente (
  id CHAR(36) PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  observacao TEXT
);

-- Tabela para preços personalizado por cliente
CREATE TABLE preco_personalizado (
  id CHAR(36) PRIMARY KEY,
  id_cliente CHAR(36) NOT NULL,
  id_produto CHAR(36) NOT NULL,
  id_tipo_preco CHAR(36) NOT NULL,
  preco DECIMAL(10,2) NOT NULL,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  observacao TEXT,
  FOREIGN KEY (id_cliente) REFERENCES cliente(id),
  FOREIGN KEY (id_produto) REFERENCES produto(id),
  FOREIGN KEY (id_tipo_preco) REFERENCES tipo_preco(id)
);

-- Tabela para maregem lucro por 'preco_personalizado por cliente
CREATE TABLE margem_lucro_personalizado (
  id CHAR(36) PRIMARY KEY,
  porcentagem DECIMAL(5,2) NOT NULL,
  id_preco_personalizado CHAR(36) NOT NULL UNIQUE,
  data_insercao DATE NOT NULL,
  data_desativacao DATE,
  FOREIGN KEY (id_preco_personalizado) REFERENCES preco_personalizado(id)
);

