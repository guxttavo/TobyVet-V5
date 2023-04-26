CREATE TABLE especie (
  id int GENERATED ALWAYS AS IDENTITY,
  nome VARCHAR(10) NOT NULL,
  CONSTRAINT pk_especie PRIMARY KEY(id)
);

CREATE TABLE animal (
  id int GENERATED ALWAYS AS IDENTITY,
  id_especie INT NOT NULL,
  nome VARCHAR(60) NOT NULL,
  responsavel VARCHAR(60) NOT NULL,
  sexo VARCHAR(15) NOT NULL,
  peso DECIMAL(5,2) NOT NULL,
  altura DECIMAL(5,1) NOT NULL,
  cor VARCHAR(30) NOT NULL,
  CONSTRAINT pk_animal PRIMARY KEY(id),
  CONSTRAINT fk_animal_especie FOREIGN KEY(id_especie) REFERENCES especie(id)
);

--INSERTS

INSERT INTO especie (nome) VALUES ('Macaco'), ('Cachorro'),('Gato');
INSERT INTO animal (id_especie, nome, responsavel, sexo, peso, altura, cor)
              VALUES (1, 'Toby', 'João', 'Macho', 10.5, 70.2, 'Marrom'),
                     (2, 'Toby', 'Maria', 'Fêmea', 5.8, 40.5, 'Preto'),
                     (3, 'Toby', 'José', 'Macho', 8.2, 65.0, 'Branco'),
                     (1, 'Fido', 'Ana', 'Macho', 7.5, 50.0, 'Preto'),
                     (2, 'Bella', 'Lucas', 'Fêmea', 4.2, 30.1, 'Branco e preto'),
                     (3, 'Roberto', 'Felipe', 'Macho', 9.8, 80.5, 'Dourado'),
                     (1, 'Thor', 'Paulo', 'Macho', 12.1, 85.0, 'Cinza'),
                     (2, 'Mel', 'Carla', 'Fêmea', 3.7, 25.8, 'Marrom'),
                     (3, 'Molly', 'Fernanda', 'Fêmea', 6.5, 60.2, 'Preto e branco')



