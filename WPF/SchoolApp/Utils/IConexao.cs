using Npgsql;
using SistemaEscola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Utils
{
    public interface IConexao
    {
        void InserirFuncionario(Funcionario funcionario);
        void InserirAluno(Aluno aluno);
        void Inserir(Pessoa pessoa);
        void Remover(Pessoa pessoa);
        int VerificaValorJaExistente(string query);
        void CarregarAlunos(List<IPessoa> lista);
        void CarregarFuncionarios(List<IPessoa> lista);
        void Testarconexao();
        void EditarAluno(Aluno aluno, Aluno editado);
        void EditarFuncionario(Funcionario funcionario, Funcionario editado);
        List<IPessoa> Carregar();
        NpgsqlConnection Conectar();




    }
}
