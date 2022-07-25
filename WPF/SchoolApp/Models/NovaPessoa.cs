using SistemaEscola.Model;
using SistemaEscola.View;

using System.Windows;

namespace SistemaEscola.Models
{
    internal static class NovaPessoa
    {
        public static IPessoa criaNovaPessoa(string pessoa)
        {
            if (pessoa == "Aluno")
            {
                return new Aluno();
            }
            else if (pessoa == "Funcionario")
            {
                return new Funcionario();
            }
            return null;
        }

        public static Window criaNovaTela(string pessoa)
        {
            if (pessoa == "Aluno")
            {
                return new FormularioAluno();
            }
            else if (pessoa == "Funcionario")
            {
                return new FormularioFuncionario();
            }
            return null;
        }
    }
}
