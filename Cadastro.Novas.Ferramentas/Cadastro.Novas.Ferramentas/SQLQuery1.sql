CREATE TABLE marca (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(20)    ,
  descricao VARCHAR(50)      ,
PRIMARY KEY(codigo));
CREATE TABLE uf (
  codigo INTEGER  NOT NULL   IDENTITY ,
  uf VARCHAR(2)    ,
  nome VARCHAR(10)      ,
PRIMARY KEY(codigo));
CREATE TABLE cliente (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(30)    ,
  cpf VARCHAR(14)    ,
  rua VARCHAR(35)    ,
  numero INTEGER    ,
  telefone VARCHAR(12)    ,
  cidade VARCHAR(20)    ,
  uf VARCHAR(2)    ,
  complemento VARCHAR(15)    ,
  cep VARCHAR(9)    ,
  dtnascimento DATE      ,
PRIMARY KEY(codigo));
CREATE TABLE fornecedor (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(50)    ,
  cnpj VARCHAR(16)    ,
  rua VARCHAR(35)    ,
  numero INTEGER    ,
  cidade VARCHAR(30)    ,
  uf VARCHAR(2)    ,
  telefone VARCHAR(12)    ,
  cep VARCHAR      ,
PRIMARY KEY(codigo));
CREATE TABLE vendas (
  codigo INTEGER  NOT NULL   IDENTITY ,
  cliente_codigo INTEGER  NOT NULL  ,
  delvenda DATE    ,
  valortotal DECIMAL(7,2)    ,
  formapagamento VARCHAR(15)      ,
PRIMARY KEY(codigo)  ,
  FOREIGN KEY(cliente_codigo)
    REFERENCES cliente(codigo));
CREATE INDEX vendas_FKIndex1 ON vendas (cliente_codigo);
CREATE INDEX IFK_Rel_04 ON vendas (cliente_codigo);
CREATE TABLE produto (
  codigo INTEGER  NOT NULL   IDENTITY ,
  marca_codigo INTEGER  NOT NULL  ,
  fornecedor_codigo INTEGER  NOT NULL  ,
  nome VARCHAR(20)    ,
  qtd INTEGER    ,
  valorunitario DECIMAL(7,2)    ,
  descricao VARCHAR(50)      ,
PRIMARY KEY(codigo)    ,
  FOREIGN KEY(fornecedor_codigo)
    REFERENCES fornecedor(codigo),
  FOREIGN KEY(marca_codigo)
    REFERENCES marca(codigo));
CREATE INDEX produto_FKIndex1 ON produto (fornecedor_codigo);
CREATE INDEX produto_FKIndex2 ON produto (marca_codigo);
CREATE INDEX IFK_Rel_01 ON produto (fornecedor_codigo);
CREATE INDEX IFK_Rel_03 ON produto (marca_codigo);
CREATE TABLE itensdavenda (
  codigo INTEGER  NOT NULL   IDENTITY ,
  vendas_codigo INTEGER  NOT NULL  ,
  produto_codigo INTEGER  NOT NULL  ,
  qtd INTEGER    ,
  totalitens INTEGER      ,
PRIMARY KEY(codigo)    ,
  FOREIGN KEY(produto_codigo)
    REFERENCES produto(codigo),
  FOREIGN KEY(vendas_codigo)
    REFERENCES vendas(codigo));
CREATE INDEX itensdavenda_FKIndex1 ON itensdavenda (produto_codigo);
CREATE INDEX itensdavenda_FKIndex2 ON itensdavenda (vendas_codigo);
CREATE INDEX IFK_Rel_05 ON itensdavenda (produto_codigo);
CREATE INDEX IFK_Rel_06 ON itensdavenda (vendas_codigo);



