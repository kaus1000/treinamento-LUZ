using System;

namespace SistemaEscola.Model
{
    internal class Funcionario : Pessoa, ICloneable, IPessoa
    {
        private float salario;
        private string cargo = string.Empty;
        private int codFuncionario;

        public float Salario { get { return salario; } set { salario = value; Notifica("Salario"); } }
        public string Cargo { get { return cargo; } set { cargo = value; Notifica("Cargo"); } }
        public int CodFuncionario { get { return codFuncionario; } set { codFuncionario = value; Notifica("CodFuncionario"); } }
        public Funcionario()
        {

        }
        public Funcionario(Funcionario p)
        {
            this.Nome = p.Nome;
            this.Sobrenome = p.Sobrenome;
            this.Salario = p.Salario;
            this.Cargo = p.Cargo;
            this.CodFuncionario = p.CodFuncionario;
        }
        public object Clone()
        {

            return new Funcionario(this);
        }
      
    }
}
