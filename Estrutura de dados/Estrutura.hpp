#include <iostream>
#include <vector>
using namespace std;

namespace Estrutura
{
	class No
	{
	public:
		int chave;
		No *prox;
		No()
		{
			prox = NULL;
		}
	};

	class Estrutura
	{
	public:
		No *inicio;
		int tam;

	public:
		// LISTA()
		// {
		// 	tam = 0;
		// 	inicio = NULL;
		// }

		void class inserir_no_inicio(int chave)
		{
			No *temp = new No();
			temp->chave = chave;
			temp->prox = inicio;
			inicio = temp;
			tam++;
		}

		void inserir_no_fim(int chave)
		{
			No *temp = new No();
			temp->chave = chave;
			if (inicio == NULL)
			{
				// se a lista  estiver vazia
				// faça o temp o novo inicio
				inicio = temp;
			}
			else
			{
				// se a lista  não estiver vazia
				// vá para o ultimo No da lista endadeada
				No *aux = inicio;
				// o loop define aux como o ultimo No da lista
				while (aux->prox != NULL)
				{
					aux = aux->prox;
				}
				// aux agora aponta para o ultimo No da lista
				// armazenar temp no aux proximo
				aux->prox = temp;
				tam++;
			}
		}

		void deletar_no_inicio()
		{
			if (inicio == NULL)
			{
				cout << "Está vazia" << endl;
			}
			else
			{
				cout << "Elemento Deletado: " << inicio->chave << endl;
				// se a lista  não estiver vazia
				// armazenar o endereço do primeiro No da lista em temp
				No *temp = inicio;
				// define o segundo No como o novo inicio da lista
				inicio = inicio->prox;
				// libera o antigo inicio
				delete (temp);
				tam--;
			}
		}

		void deletar_no_fim()
		{
			if (inicio == NULL)
			{
				cout << "Está vazia" << endl;
			}
			else if (inicio->prox == NULL)
			{
				// se houver apenas 1 No na lista
				// libera o inicio e define como NULL
				cout << "Elemento Deletado: " << inicio->chave << endl;
				delete (inicio);
				inicio = NULL;
			}
			else
			{
				// se houver mais de  1 No na lista
				// passar para o segundo ultimo No da lista
				No *temp = inicio;
				// o loop define temp para o segundo ultimo No da lista
				while (temp->prox->prox != NULL)
				{
					temp = temp->prox;
				}
				// temp agora aponta para o segundo ultimo No da lista
				cout << "Elemento Deletado: " << temp->prox->chave << endl;
				// excluir ultimo No
				delete (temp->prox);
				// define o proximo, do segundo ultimo No, para NULL
				temp->prox = NULL;
				tam--;
			}
		}

		void print()
		{
			if (inicio == NULL)
			{
				cout << "Está vazia" << endl;
			}
			else
			{
				No *temp = inicio;
				cout << "Elemento: ";
				while (temp != NULL)
				{
					cout << temp->chave << "->";
					temp = temp->prox;
				}
				cout << "NULL" << endl;
			}
		}
		void tamanho()
		{
			cout << "Numero de elementos: " << tam << endl;
		}
	};

	int main()
	{

		printf("1 Para Inserir no inicio");
		printf("\n2 Para Inserir no fim");
		printf("\n3 Para Deletar no inicio");
		printf("\n4 Para Deletar no fim");
		printf("\n5 Para printar a lista");
		printf("\n6 Para mostrar o tamanho da lista");
		printf("\n7 Para Sair");

		int escolha, v;
		Estrutura lista;
		do
		{
			cout << "\nDigite sua escolha: ";
			cin >> escolha;
			switch (escolha)
			{
			case 1:
				cout << "Digite seu elemento: ";
				cin >> v;
				lista.inserir_no_inicio(v);
				break;

			case 2:
				cout << "Digite seu elemento: ";
				cin >> v;
				lista.inserir_no_fim(v);
				break;

			case 3:
				lista.deletar_no_inicio();
				break;

			case 4:
				lista.deletar_no_fim();
				break;

			case 5:
				lista.print();
				break;
			case 6:
				lista.tamanho();
				break;
			case 7:
				break;
			default:
				printf("\n\n Opcao nao valida");
			}
		} while (escolha != 7);
	}
};