CREATE TABLE aluno (
    id serial NOT NULL,
    data timestamp(0) without time zone DEFAULT CURRENT_TIMESTAMP(2) NOT NULL, 
    nome character varying(30) NOT NULL,
    sobrenome character varying(50) NOT NULL,
    matricula INTEGER NULL,
    serie character varying(30) NOT NULL
);

CREATE TABLE funcionario (
    iD serial NOT NULL,
    data timestamp(0) without time zone DEFAULT CURRENT_TIMESTAMP(2) NOT NULL, 
    nome character varying(30) NOT NULL,
    sobrenome character varying(50) NOT NULL,
    salario real NULL,
    cargo character varying(30) NOT NULL,
    codFuncionario integer NULL
);