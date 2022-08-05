using System;
using Npgsql;
using SistemaEscola.Model;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace SistemaEscola.Utils
{
    public class PostgreSql : IConexao
    {
        private NpgsqlDataReader reader;
        private NpgsqlCommand cmd;
        private string query;
        private NpgsqlConnection conn;

        public PostgreSql()
        {
            
        }
        public PostgreSql(NpgsqlConnection conn)
        {
            this.conn = conn;
        }
        
        public void InserirFuncionario(Funcionario funcionario)
        {
            int n;
            string checagem = $@"select 1 from funcionario where codfuncionario = '{funcionario.CodFuncionario}' limit 1";
            int existe;
            
            using (NpgsqlConnection con = Conectar())
            {
                Testarconexao();
                try
                {
                    
                    existe = VerificaValorJaExistente(checagem);
                    if (
                        existe != 1 && funcionario.Nome != "" 
                        && funcionario.Sobrenome != "" 
                        && funcionario.CodFuncionario != 0 
                        && funcionario.Cargo != ""
                        && funcionario.Salario != 0
                        )
                    {
                        query = $@"INSERT INTO public.funcionario (nome, sobrenome, salario, cargo, codfuncionario)
                                VALUES('{funcionario.Nome}',
                                '{funcionario.Sobrenome}',
                                '{funcionario.Salario}',
                                '{funcionario.Cargo}',
                                '{funcionario.CodFuncionario}')";
                        cmd = new NpgsqlCommand(query, con);
                        con.Open();
                    }
                    else
                    {
                        throw new Exception("Erro, Ao inserir funcionario, preencha todos os campos!");
                    }

                    n = cmd.ExecuteNonQuery();
                    if (n == 1)
                    {
                        
                        Console.WriteLine("Funcionario Inserido com sucesso");
                    }

                }
                catch
                {
                    throw new Exception("Erro, Ao inserir funcionario!");

                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        public void InserirAluno(Aluno aluno)
        {
            
            int n;
            string checagem = $@"select 1 from aluno where matricula = '{aluno.Matricula}' limit 1";
            int existe;

            using (NpgsqlConnection con = Conectar())
            {
                try
                {
                    existe = VerificaValorJaExistente(checagem);
                    if (existe != 1 && aluno.Nome != "" && aluno.Sobrenome != "" && aluno.Matricula != 0 && aluno.Serie != "")
                    {
                        query = $@"INSERT INTO public.aluno (nome, sobrenome, matricula, serie)
                        VALUES('{aluno.Nome}',
                        '{aluno.Sobrenome}',
                        '{aluno.Matricula}',
                        '{aluno.Serie}')";
                        cmd = new NpgsqlCommand(query, con);
                        con.Open();
                    }
                    else
                    {
                        throw new Exception("Erro, Ao inserir Aluno, preencha todos os campos!");

                    }

                    n = cmd.ExecuteNonQuery();
                    if (n == 1)
                    {
                        Console.WriteLine("Aluno Inserido com sucesso");
                    }

                }
                catch
                {
                    throw new Exception("Erro, Ao inserir Aluno!");

                }
                finally
                {
                    con.Close();
                    cmd.Dispose();
                }
            }
        }

        public int VerificaValorJaExistente(string query)
        {
            using (NpgsqlConnection con = Conectar())
            {
                cmd = new NpgsqlCommand(query, con);
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    int val;

                    while (reader.Read())
                    {
                        val = Int32.Parse(reader[0].ToString());

                        return val;
                    }
                    return 0;
                }
                catch
                {
                    throw new Exception("Erro, Ao fazer a checagem!");

                }
                finally
                {
                    cmd.Dispose();
                    reader.Close();
                    reader.Dispose();
                }



            }
        }
        public void Inserir(Pessoa pessoa)
        {
            try
            {
                
                if (pessoa is Aluno aluno)
                {
                    InserirAluno(aluno);
                }
                else if (pessoa is Funcionario funcionario)
                {

                    InserirFuncionario(funcionario);
                }
            }
            catch(Exception ex)
            {
               throw ex;
            }
        }

        public void CarregarAlunos(List<IPessoa> lista)
        {
            using (NpgsqlConnection con = Conectar())
            {

                Console.WriteLine("oi");
                Testarconexao();
                query = ("SELECT * FROM public.aluno;");
                cmd = new NpgsqlCommand(query, con);

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Aluno aluno = new Aluno()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome")),
                            Matricula = reader.GetInt32(reader.GetOrdinal("matricula")),
                            Serie = reader.GetString(reader.GetOrdinal("serie")),

                        };

                        lista.Add(aluno);

                    }
                }
                catch
                {
                    throw new Exception("Erro, Ao carregar aluno!");
                }
                finally
                {
                    reader.Close();
                    reader.Dispose();
                    cmd.Dispose();
                }
            }
        }

        public void CarregarFuncionarios(List<IPessoa> lista)
        {
            using (NpgsqlConnection con = Conectar())
            {
                Testarconexao();
                query = ("SELECT * FROM public.funcionario;");
                cmd = new NpgsqlCommand(query, con);
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Funcionario funcionario = new Funcionario()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Nome = reader.GetString(reader.GetOrdinal("nome")),
                            Sobrenome = reader.GetString(reader.GetOrdinal("sobrenome")),
                            Salario = reader.GetFloat(reader.GetOrdinal("salario")),
                            Cargo = reader.GetString(reader.GetOrdinal("cargo")),
                            CodFuncionario = reader.GetInt32(reader.GetOrdinal("codfuncionario")),
                        };

                        lista.Add(funcionario);
                    }
                }
                catch
                {
                    throw new Exception("Erro, Ao carregar Funcionario!");
                }
                finally
                {
                    reader.Close();
                    reader.Dispose();
                    cmd.Dispose();
                }
            }
        }
        public void Remover(Pessoa pessoa)
        {
            string tabela = string.Empty;
            string tipo = string.Empty; 
            Funcionario aux = pessoa as Funcionario;
            Aluno temporario = pessoa as Aluno;
            int codUnico = 0;
            if (pessoa is Aluno)
            {
                tabela = "aluno"; tipo = "matricula"; codUnico = temporario.Matricula;
            }
            else if (pessoa is Funcionario)
            {
                tabela = "funcionario"; codUnico = aux.CodFuncionario; tipo = "codfuncionario";
            }

            query = ($"DELETE FROM {tabela} WHERE " +
                                            $"{tipo}='{codUnico}'");
            using (NpgsqlConnection con = Conectar())
            {
                cmd = new NpgsqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw new Exception("Erro, ao remover");

                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        public void Testarconexao()
        {
            Console.WriteLine("Conectado");

            using (NpgsqlConnection con = Conectar())
            {
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Conectado");
                    }
                }
                catch
                {
                    throw new NpgsqlException("Erro ao tentar se comunicar com o banco de dados");
                }




            }
        }
        public void EditarAluno(Aluno aluno, Aluno editado)
        {
            string checagem = $@"select 1 from aluno where matricula = '{editado.Matricula}' limit 1";
            int existe;
            if (aluno.Matricula == editado.Matricula)
            {
                existe = 0;
            }
            else
            {
                existe = VerificaValorJaExistente(checagem);
            }
            using (NpgsqlConnection con = Conectar())
            {
                query = ($@"UPDATE aluno SET nome='{editado.Nome}', 
                    sobrenome='{editado.Sobrenome}',
                    matricula='{editado.Matricula}', 
                    serie='{editado.Serie}' 
                    WHERE matricula='{aluno.Matricula}';");
                
                cmd = new NpgsqlCommand(query, con);
                try
                    {

                    if (existe != 1)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new Exception("Matricula já existe!");
                    }
                    
                }
                catch
                {
                    throw new Exception("Erro, ao editar aluno");
                }
                finally
                {
                    cmd.Dispose();
                }


            }
        }
        public void EditarFuncionario(Funcionario funcionario, Funcionario editado)
        {
            string checagem = $@"select 1 from funcionario where codfuncionario = '{editado.CodFuncionario}' limit 1";
           
            int existe;

            if (funcionario.CodFuncionario == editado.CodFuncionario)
            {
                existe = 0; 
            }
            else
            {
                existe = VerificaValorJaExistente(checagem);
            }
            using (NpgsqlConnection con = Conectar())
            {

                query = ($@"UPDATE funcionario SET nome='{editado.Nome}', 
                sobrenome='{editado.Sobrenome}',
                Cargo='{editado.Cargo}', 
                salario='{editado.Salario}',
                codfuncionario='{editado.CodFuncionario}' 
                WHERE codfuncionario='{funcionario.CodFuncionario}';");
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
               
                cmd = new NpgsqlCommand(query, con);
                try
                {

                    if (existe != 1)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                        throw new Exception("CodFuncionario já existe!");

                    }
                }
                catch
                {
                    throw new Exception("Erro, Ao editar funcionario!");

                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        public List<IPessoa> Carregar()
        {

            try
            {
                
                List<IPessoa> pessoas= new List<IPessoa>();

                CarregarAlunos(pessoas);
                CarregarFuncionarios(pessoas);
                return pessoas;              
            }
            catch(Exception ex)
            {
                throw ex;

            }
        }
      
        public NpgsqlConnection Conectar()
        {
            try
            {

                NpgsqlConnection con = new NpgsqlConnection(@"Server=localhost;Port=5432;User admin;Password=admin;Database=yourdatabase;");
                return con;
            }
            catch
            {
                throw new Exception("Erro ao se conectar com banco de dados!");

            }
        }
    }
}