using SistemaEscola.Utils;
using Moq;
using SistemaEscola.Model;
using SchoolApp.Utils;

namespace Teste
{

    public class TestesDeFuncoesDadosInvalidos
    {
        PostgreSql Banco = new PostgreSql();

        [Test]
        public void InserirComDadosInválidosFuncionario()
        {

            Funcionario funcionario = new Funcionario()
            {
                Nome = "",
                Sobrenome = "",
                Salario = 0,
                Cargo = "diretor",
                CodFuncionario = 2691,
            };

            Assert.Catch<Exception>(() => Banco.Inserir(funcionario));

        }
        [Test]
        public void InserirComDadosInválidosAluno()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "",
                Sobrenome = "",
                Matricula = 25167,
                Serie = "PrimeiraSerie",
            };



            Assert.Catch<Exception>(() => Banco.Inserir(aluno));

        }

        [Test]
        public void EditarComDadosInválidosFuncionario()
        {

            Funcionario funcionario = new Funcionario()
            {
                Nome = "sergio",
                Sobrenome = "botelho",
                Salario = 2156,
                Cargo = "Diretor",
                CodFuncionario = 2691,
            };

            Funcionario editado = new Funcionario()
            {
                Nome = "sergio",
                Sobrenome = "botelho",
                Salario = 2156,
                Cargo = "Diretor",
                CodFuncionario = 4456,
            };

            Assert.Catch<Exception>(() => Banco.EditarFuncionario(funcionario, editado));

        }
        [Test]
        public void EditarComDadosInválidosAluno()
        {

            Aluno aluno = new Aluno()
            {
                Nome = "Danielli Yasmin",
                Sobrenome = "Caovilla",
                Matricula = 9900,
                Serie = "QuartaSerie",
            };

            Aluno editado = new Aluno()
            {
                Nome = "sergio",
                Sobrenome = "botelho",
                Matricula = 8965,
                Serie = "PrimeiraSerie",
            };

            Assert.Catch<Exception>(() => Banco.EditarAluno(aluno, editado));

        }   

    }

    public class TestesDeIntegracao
    {

        PostgreSql Banco = new PostgreSql();
        [Test]
        public void InserirComDadosVálidosFuncionario()
        {

            
            Funcionario funcionario = new Funcionario()
            {
                Nome = "Sergio",
                Sobrenome = "Botelho",
                Salario = 2133,
                Cargo = "Diretor",
                CodFuncionario = 6100,
            };

            try
            {
                Banco.Inserir(funcionario);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exceção não esperada, porém foi devolvido: " + ex.Message);
            }
            

        }
        [Test]
        public void InserirComDadosVálidosAluno()
        {


            Aluno aluno = new Aluno()
            {
                Nome = "Danielli Yasmin",
                Sobrenome = "Caovilla",
                Matricula = 9700,
                Serie = "QuartaSerie",

            };
            try
            {
                Banco.Inserir(aluno);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exceção não esperada, porém foi devolvido: " + ex.Message);
            }


        }

        [Test]
        public void RemoverDadosVálidosAluno()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Danielli Yasmin",
                Sobrenome = "Caovilla",
                Matricula = 8968,
                Serie = "QuartaSerie",
            };
            try
            {
                Banco.Remover(aluno);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exceção não esperada, porém foi devolvido: " + ex.Message);
            }
            
        }

        [Test]
        public void RemoverDadosVálidosFuncionario()
        {
            Funcionario funcionario = new Funcionario()
            {
                Nome = "Fernando",
                Sobrenome = "Ferreira",
                Cargo = "Professor",
                CodFuncionario = 7000,
                Salario = 2500,
            };
            try
            {
                Banco.Remover(funcionario);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exceção não esperada, porém foi devolvido: " + ex.Message);
            }

        }


        [Test]
        public void EditarDadosVálidosAluno()
        {
                Aluno aluno = new Aluno()
                {
                    Nome = "fer",
                    Sobrenome = "renan",
                    Matricula = 2020,
                    Serie = "QuartaSerie",
                };

                Aluno editado = new Aluno()
                {
                    Nome = "blabla",
                    Sobrenome = "oi",
                    Matricula = 5025,
                    Serie = "QuintaSerie",
                };
                try
                {
                Banco.EditarAluno(aluno,editado);
                }
                catch (Exception ex)
                {
                    Assert.Fail("Exceção não esperada, porém foi devolvido: " + ex.Message);
                }

        }
        [Test]
        public void EditarDadosVálidosFuncionario()
        {
            Funcionario funcionario = new Funcionario()
            {
                Nome = "Sergio",
                Sobrenome = "Botelho",
                Cargo = "Diretor",
                CodFuncionario = 6100,
                Salario = 2133,
            };

            Funcionario editado = new Funcionario()
            {
                Nome = "Fernando",
                Sobrenome = "Ferreira",
                Cargo = "Professor",
                CodFuncionario = 7050,
                Salario = 2500,
            };
            try
            {
                Banco.EditarFuncionario(funcionario, editado);
            }
            catch (Exception ex)
            {
                Assert.Fail("Exceção não esperada, porém foi devolvido: " + ex.Message);
            }

        }

    }

    public class TestesDeMock
    {
        public PostgreSql? Banco
        {
            get;
            set;
        }

        [Test]
        public void InsertFuncionarioComBancoCaidoPostgres()
        {
            Funcionario funcionario = new Funcionario()
            {
            };

            Mock<IConexao> database = new Mock<IConexao>();
            Conexao con = new Conexao(database.Object);

            string messagem = "Não foi possivel inserir um funcionario, preencha todos os campos!";
            database.Setup(x => x.Inserir(funcionario)).Throws(new Exception(messagem));
            Exception ex = Assert.Catch<Exception>(() => con.Inserir(funcionario));
            Assert.That(ex.Message, Is.EqualTo(messagem));
        }
        [Test]
        public void InsertAlunoComBancoCaidoPostgres()
        {
            Aluno aluno = new Aluno()
            {
            };

            Mock<IConexao> database = new Mock<IConexao>();
            Conexao con = new Conexao(database.Object);

            string messagem = "Não foi possivel inserir um aluno, preencha todos os campos!";
            database.Setup(x => x.Inserir(aluno)).Throws(new Exception(messagem));
            Exception ex = Assert.Catch<Exception>(() => con.Inserir(aluno));
            Assert.That(ex.Message, Is.EqualTo(messagem));
        }
        [Test]
        public void UpdateAlunoComBancoCaidoPostgres()
        {
            Aluno aluno = new Aluno()
            {
            };
            Aluno editado = new Aluno()
            {
            };

            Mock<IConexao> database = new Mock<IConexao>();
            Conexao con = new Conexao(database.Object);

            string messagem = "Não foi possivel atualizar o aluno, preencha todos os campos!";
            database.Setup(x => x.EditarAluno(aluno, editado)).Throws(new Exception(messagem));
            Exception ex = Assert.Catch<Exception>(() => con.EditarAluno(aluno, editado));
            Assert.That(ex.Message, Is.EqualTo(messagem));
        }
        [Test]
        public void UpdateFuncionarioComBancoCaidoPostgres()
        {
            Funcionario funcionario = new Funcionario()
            {
            };
            Funcionario editado = new Funcionario()
            {
            };

            Mock<IConexao> database = new Mock<IConexao>();
            Conexao con = new Conexao(database.Object);

            string messagem = "Não foi possivel atualizar o funcionario, preencha todos os campos!";
            database.Setup(x => x.EditarFuncionario(funcionario, editado)).Throws(new Exception(messagem));
            Exception ex = Assert.Catch<Exception>(() => con.EditarFuncionario(funcionario, editado));
            Assert.That(ex.Message, Is.EqualTo(messagem));
        }
    }
}