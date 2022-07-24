using SistemaEscola.Utils;
using SistemaEscola.Model;
using SistemaEscola.Enum;
using SistemaEscola.View;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System;
using SchoolApp.Models;

namespace SistemaEscola.ViewModel
{
	internal class MainViewModel : Observe 
	{
		private Model.SistemaEscola sistemaEscola;
		public AdicionarPessoas itemadicionar { get; set; }

		public ObservableCollection<Pessoa> listaPessoas
		{ 
			get { return sistemaEscola.Pessoas; }
			
		}
		public IPessoa nova { get; set; }
		public ICommand CadastroPessoa { get; set; }

		public Pessoa PessoaSelecionada { get; set; }

		public ICommand RemoverPessoa { get; set; }
		public ICommand AtualizarPessoa { get; set; }

		public AdicionarPessoas itemAdicionar
		{
			get => itemadicionar;
			set
			{
				itemadicionar = value;
				Console.WriteLine((int)itemAdicionar);
			}
		}
		public MainViewModel()
		{
			sistemaEscola = new Model.SistemaEscola();
            
				CadastroPessoa = new RelayCommand((_) =>
				{

					CriaEntidade.UsaEntidade(nova);
					this.nova = Aluno.Adicionar();
					formulario.DataContext = nova;
					formulario.ShowDialog();
					if (formulario.DialogResult == true)
						if (nova.Nome != "" && nova.Sobrenome != "")
							listaPessoas.Add(nova);
					
                    


				});

			RemoverPessoa = new RelayCommand((_) =>
			{
				if (PessoaSelecionada != null)
				{
					listaPessoas.Remove(PessoaSelecionada);
				}
			});

			AtualizarPessoa = new RelayCommand((_) =>
			{

				if (PessoaSelecionada != null)
				{
					Aluno aluno = PessoaSelecionada as Aluno;
					Funcionario funcionario = PessoaSelecionada as Funcionario;

					if (aluno != null)
					{
						
						Aluno nova = (Aluno)aluno.Clone();
						FormularioAluno form = new FormularioAluno();
						form.DataContext = nova;
						form.ShowDialog();
						if (form.DialogResult == true) { 
							aluno.Nome = nova.Nome;
							aluno.Sobrenome = nova.Sobrenome;
							aluno.Matricula = nova.Matricula;
							aluno.Serie = nova.Serie;

						}
					}

					if (funcionario != null)
					{
						Funcionario nova = (Funcionario)funcionario.Clone();
						FormularioFuncionario form = new FormularioFuncionario();
						form.DataContext = nova;
						form.ShowDialog();
						if (form.DialogResult == true)
						{
							funcionario.Nome = nova.Nome;
							funcionario.Sobrenome = nova.Sobrenome;
							funcionario.Salario = nova.Salario;
							funcionario.Cargo = nova.Cargo;
						}
					}

				}
			});
		}

	}
}