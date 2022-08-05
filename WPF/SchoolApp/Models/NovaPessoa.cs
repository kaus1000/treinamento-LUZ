using SistemaEscola.Enum;
using SistemaEscola.Model;
using SistemaEscola.View;

using System.Windows;

namespace SistemaEscola.Models
{
    internal static class NovaPessoa
    {
        public static IPessoa criaNovaPessoa(AdicionarPessoas pessoa)
        {
            if (pessoa == AdicionarPessoas.Aluno)
            {
                return new Aluno();
            }
            else if (pessoa == AdicionarPessoas.Funcionario)
            {
                return new Funcionario();
            }
            return null;
        }

        public static Window criaNovaTela(AdicionarPessoas pessoa)
        {
            if (pessoa == AdicionarPessoas.Aluno)
            {
                return new FormularioAluno();
            }
            else if (pessoa == AdicionarPessoas.Funcionario)
            {
                return new FormularioFuncionario();
            }
            return null;
        }
    }
}
