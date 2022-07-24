using System.Collections.ObjectModel;

namespace SistemaEscola.Model
{

	public class SistemaEscola
	{
		private ObservableCollection<Pessoa> pessoas;
		public ObservableCollection<Pessoa> Pessoas { get { return pessoas; } }

		public SistemaEscola()
		{
			pessoas = new ObservableCollection<Pessoa>();
		}

		public void AdicionarPessoa(Pessoa pessoa)
		{
			if (pessoa != null &&
				!string.IsNullOrEmpty(pessoa.Nome) &&
				!string.IsNullOrEmpty(pessoa.Sobrenome))
			{
				pessoas.Add(pessoa);
			}
		}
		public void RemoverPessoa(Pessoa pessoa) => pessoas.Remove(pessoa);
	}

}