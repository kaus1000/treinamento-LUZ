using SistemaEscola.Model;
using SistemaEscola.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Utils
{
    public class Conexao 
    {
        private IConexao conn;
        public Conexao(IConexao conn)
        {
            this.conn = conn;
        }
        public void Carregar()
        {
            try
            {
                conn.Carregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Inserir(Pessoa pessoa)
        {
            try
            {
                conn.Inserir(pessoa);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void EditarAluno(Aluno aluno, Aluno editada)
        {
            try
            {
                conn.EditarAluno(aluno, editada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditarFuncionario(Funcionario funcionario, Funcionario editada)
        {
            try
            {
                conn.EditarFuncionario(funcionario, editada);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    }

