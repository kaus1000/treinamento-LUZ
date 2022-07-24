using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Enum
{
		public enum Serie
		{
			PrimeiraSerie = 1,
			SegundaSerie = 2,
			TerceiraSerie = 3,
			QuartaSerie = 4,
			QuintaSerie = 5,
			SextaSerie = 6,
			SetimaSerie = 7,
			OitavaSerie = 8,
			PrimeiroAnoMedio = 9,
			SegundoAnoMedio = 10,
			TerceiroAnoMedio = 11
		}
		public enum Cargo
		{
			Diretor = 1,
			Coordenador = 2,
			Secretária = 3,
			Professor = 4,
			Faxineiro = 5,
			Cozinheiro = 6,
			Porteiro = 7,
			Bibliotecário = 8,
		}
	public enum AdicionarPessoas 
		{
			Todos = 0,
			Aluno = 1,
			Funcionario = 2
		}
}
