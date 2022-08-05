using SistemaEscola.Utils;
using System;

namespace SistemaEscola.Model
{


    public class Pessoa : Observe, IPessoa
    {
        protected int id;
        protected string nome = string.Empty;
        protected string sobrenome = string.Empty;

        public int Id { get { return id; } set { id = value; Notifica("Id"); } }
        public string Nome { get { return nome; } set { nome = value; Notifica("Nome"); } }
        public string Sobrenome { get { return sobrenome; } set { sobrenome = value; Notifica("Sobrenome"); } }


        public Pessoa()
        {

            
        }


    }
    public interface IPessoa
    {
    }
}