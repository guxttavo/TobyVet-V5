-- Entidades
CREATE TABLE Animal (
  id int generated always as identity,
  Nome VARCHAR(60) NOT NULL,
  Responsavel VARCHAR(60) NOT NULL,
  Especie VARCHAR(15) NOT NULL,
  Genero VARCHAR(15) NOT NULL,
  Peso DECIMAL(5,2) NOT NULL,
  Altura DECIMAL(5,1) NOT NULL,
  Cor VARCHAR(30) NOT NULL,
  constraint pk_Animal primary key(id)
);

-- DOMÍNIO

CREATE TABLE Genero (
  id int generated always as identity,
  Nome VARCHAR(10) NOT NULL,
  constraint pk_Genero primary key(id)
);

CREATE TABLE Especie (
  id int generated always as identity,
  Nome VARCHAR(10) NOT NULL,
  constraint pk_Especie primary key(id)
);

