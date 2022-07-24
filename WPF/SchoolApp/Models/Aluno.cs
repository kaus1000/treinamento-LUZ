using SchoolApp.Models;
using SistemaEscola.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Model
{
	internal class Aluno : Pessoa,  ICloneable, IPessoa
	{
		private int matricula;
		private string serie;
		public int Matricula { get { return matricula; } set { matricula = value; Notifica("Matricula"); } }

		public string Serie { get { return serie; } set { serie = value; Notifica("Serie"); } }

		public Aluno()
		{

		}
		public Aluno(Aluno p)
		{
			this.Nome = p.Nome;
			this.Sobrenome = p.Sobrenome;
			this.Matricula = p.Matricula;
			this.Serie = p.Serie;
		}
		public void Adicionar()
        {
			FormularioAluno formulario = new FormularioAluno();
			Pessoa nova = new Aluno();

			
			
		}
		public object Clone()
		{

			return new Aluno(this);
		}
	}
}