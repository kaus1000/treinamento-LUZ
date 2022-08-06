# CRUD WPF MVVM | POSTGRES | DOCKER | SOLID | UNIT TEST |

<br />
<br />
<h1 align="center">
  <img alt="Luz" src="https://cdn.cdnlogo.com/logos/c/27/c.svg" width="220px" /> 
  <br />
  <br />
   C# | .NET | WPF | MVVM | POSTGRES | DOCKER | SOLID

</h1>

<p align="center">
  <img alt="License MIT" src="https://img.shields.io/badge/License-MIT-%2398C611" />
  <img alt="C#" src="https://img.shields.io/badge/%20language-dotnet-%232F74C0" />
  <img alt=".NET" src="https://img.shields.io/badge/%20language-.NET-%232F74C0" /> <br />
</p> 
<br />
<br />

## :bookmark: Sobre o Projeto
<br />


![Screenshot_16](https://user-images.githubusercontent.com/66697772/183262265-17f0cded-0628-4f2f-b43d-8fcecb3f07af.png)
![Screenshot_17](https://user-images.githubusercontent.com/66697772/183262266-76f88716-f641-475c-b868-3f6f04e758ce.png)
![Screenshot_11](https://user-images.githubusercontent.com/66697772/183262272-08ab4e7f-5708-48e4-9360-6e68120bdcee.png)
![Screenshot_12](https://user-images.githubusercontent.com/66697772/183262273-f5cc2d89-8368-479b-a59c-2e4819afbd04.png)
![Screenshot_13](https://user-images.githubusercontent.com/66697772/183262274-b5dfbdd8-079c-42d2-b057-c60f23ddb5f7.png)
![Screenshot_14](https://user-images.githubusercontent.com/66697772/183262275-2b949048-e297-4226-85b9-95e098c82a5e.png)
![Screenshot_15](https://user-images.githubusercontent.com/66697772/183262277-897f7088-1535-4ab1-b843-3e00acd4443a.png)



Projeto desenvolvido durante o treinamento com a empresa Luz Soluções Financeiras,  Trata-se de um CRUD, de um sistema de Escola, feito em dotnet, MVVM, WPF, Utilizando design patern SOLID, integrando com o banco de dados PostgresSQL, Rodando com Docker, Foram feitos testes unitarios, testes de integração, juntamento com a utilização de MOCK.

<br />




<br />

## :bulb: Tecnologias Utilizadas:
<br />

* [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/en-us/)
* [POSTGRES](https://www.postgresql.org/)
* [DOCKER](https://www.docker.com/)
* [SOLID](https://www.freecodecamp.org/portuguese/news/os-principios-solid-da-programacao-orientada-a-objetos-explicados-em-bom-portugues/)
* [WPF](https://docs.microsoft.com/pt-br/visualstudio/designers/getting-started-with-wpf?view=vs-2022)
* [MVVM](https://docs.microsoft.com/pt-br/windows/uwp/data-binding/data-binding-and-mvvm)




<br />

## Se Preparando

Esse é um exemplo de instruções de como você pode configurar o projeto localmente.
Para conseguir uma cópia local e iniciar o projeto, siga essas etapas 👇.



### Pré-requisitos

Clone repositório 
   ```sh
   git clone https://github.com/treinamento-LUZ
   ```

### Instalação IDE

* [VISUAL STUDIO](https://visualstudio.microsoft.com/)
    ```sh
    Você vai precisar fazer o download e instalar o visual studio(link acima)
    ```

### Instalação Postgres
  
  * [Postgres](https://www.postgresql.org/)
    ```sh
    Você vai precisar fazer o download e instalar o postgres(link acima)
    ```
  * [Docker](https://www.docker.com/)
    ```sh
    Você vai precisar fazer o download e instalar o Docker(link acima) e colocar uma instância do banco postgres rodando por ele.
    ```
  * Você pode criar um banco com o seguinte comando(Lembre de alterar os dados:POSTGRES_USER, POSTGRES_PASSWORD, POSTGRES_DB.): 
     ```sh
     docker run --name myPostgresDb -p 5455:5432 -e POSTGRES_USER=postgresUser -e POSTGRES_PASSWORD=postgresPW -e POSTGRES_DB=postgresDB -d postgres
     ```
  * No Arquivo PostgresSQL.cs 
     ```sh
     Mude para os seu dados na função Conectar().
     ```
   * Instale o NPGSQL no seu projeto clicando em cima do seu projeto como na imagem
    ![Screenshot_18](https://user-images.githubusercontent.com/66697772/183262268-e07ad4b0-76b1-4612-b175-b22c7ff63253.png)
    ![Screenshot_19](https://user-images.githubusercontent.com/66697772/183262270-788cd7cc-3542-4f84-bb2a-211d0d51a45f.png)
 * Crie as tabelas no seu banco de dados com as seguintes querys. 
     ```sh
     CREATE TABLE aluno (
    id serial NOT NULL,
    data timestamp(0) without time zone DEFAULT CURRENT_TIMESTAMP(2) NOT NULL, 
    nome character varying(30) NOT NULL,
    sobrenome character varying(50) NOT NULL,
    matricula INTEGER NULL,
    serie character varying(30) NOT NULL);
     
     CREATE TABLE funcionario (
    iD serial NOT NULL,
    data timestamp(0) without time zone DEFAULT CURRENT_TIMESTAMP(2) NOT NULL, 
    nome character varying(30) NOT NULL,
    sobrenome character varying(50) NOT NULL,
    salario real NULL,
    cargo character varying(30) NOT NULL,
    codFuncionario integer NULL);
     ```

## :memo: License

Este projeto esta sob a [MIT license](LICENSE) para mais detalhes.
<br />
<br />

## :wave: Social

Siga nas redes :wink:
<br />


- [LinkedIn](https://www.linkedin.com/in/sergio-damaceno-botelho/) Sérgio Damaceno
- [LinkedIn](https://www.linkedin.com/in/danielli-caovilla-1802a919a/) Danielli Caovilla

<br />
<br />



