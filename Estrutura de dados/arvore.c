#include <stdio.h>
#include <stdlib.h>
#define MAX(x, y) (((x) > (y)) ? (x) : (y))
// Estrutura do No
typedef struct no
{
    int chave;
    struct No *esquerda, *direita;
} No;
// Estrutura da arvore 
typedef struct
{
    No *raiz;
    int altura;
} ArvoreBin;

// Cria uma arvore
ArvoreBin *criarArvore()
{
    ArvoreBin *arvore = (ArvoreBin *)malloc(sizeof(ArvoreBin));// aloca espaço em memoria
    
    arvore->raiz = NULL; // inicializa a raiz como NULL
    return arvore;
}
// Cria um No
No *criarNo(int item)
{
    No *no = (No *)malloc(sizeof(No));// aloca espaço em memoria
    no->chave = item;
    no->esquerda = no->direita = NULL;
    return no;
}
//Função para buscar um elemento na arvore
void *busca(No *raiz, int chave)
{
    if (raiz == NULL)
    {
        return NULL;
    }
    else if (raiz->chave == chave)
    {
        return chave;
    }
    else if (chave <= raiz->chave)
    {
        return busca(raiz->esquerda, chave);
    }
    else
    {
        return busca(raiz->direita, chave);
    }
}
//Função para inserir um elemento na arvore
void *inserir(ArvoreBin *arvore, int chave)
{

    if (arvore->raiz == NULL)
        arvore->raiz = criarNo(chave);
    else
    {
        No *aux = arvore->raiz;
        while (aux != NULL)
        {
            if (chave < aux)
            {
                if (aux->esquerda == NULL)
                {
                    No *novoNo = criarNo(chave);
                    aux->esquerda = novoNo;
                    return arvore->raiz;
                }
                aux = aux->esquerda;
            }
            else
            {
                if (aux->direita == NULL)
                {
                    No *novoNo = criarNo(chave);
                    aux->direita = novoNo;
                    return arvore->raiz;
                }
                aux = aux->direita;
            }
        }
    }
}
//Função para exbir um elemento na arvore em ordem
void emOrdem(No *raiz)
{
    if (raiz != NULL)
    {
        emOrdem(raiz->esquerda);
        printf("Em: %d \n", raiz->chave);
        emOrdem(raiz->direita);
    }
}
//Função para exbir um elemento na arvore Preordem
void preOrdem(No *raiz)
{
    if (raiz != NULL)
    {
        printf("Pre: %d \n", raiz->chave);
        preOrdem(raiz->esquerda);
        preOrdem(raiz->direita);
    }
}
//Função para exbir um elemento na arvore Posordem
void posOrdem(No *raiz)
{
    if (raiz != NULL)
    {
        posOrdem(raiz->esquerda);
        posOrdem(raiz->direita);
        printf("Pos: %d \n", raiz->chave);
    }
}
//Função para encontrar o valor minimo na arvore
void *valorminimoNo(No *no)
{
    No *atual = no;

    while (atual->esquerda != NULL)
        atual = atual->esquerda;

    return atual;
}

//Função para encontrar o valor maximo na arvore
void *valormaximoNo(No *no)
{
    No *atual = no;

    while (atual->direita != NULL)
        atual = atual->direita;

    return atual;
}

//Função para remover o elemento especificado na arvore
No* deletarNo(No *raiz, int chave)
{
 
    if (raiz == NULL)
        return raiz;
 

    if ( chave < raiz->chave )
        raiz->esquerda = deletarNo(raiz->esquerda, chave);
 

    else if( chave > raiz->chave )
        raiz->direita = deletarNo(raiz->direita, chave);
 
    else
    {
        if( (raiz->esquerda == NULL) || (raiz->direita == NULL) )
        {
            No *temp = raiz->esquerda ? raiz->esquerda :
                                             raiz->direita;
 
            if (temp == NULL)
            {
                temp = raiz;
                raiz = NULL;
            }
            else 
             *raiz = *temp; 
                            
            free(temp);
        }
        else
        {

            No* temp = valorminimoNo(raiz->direita);
 

            raiz->chave = temp->chave;
 

            raiz->direita = deletarNo(raiz->direita, temp->chave);
        }
    }
 
    if (raiz == NULL)
      return raiz;
 
}

//Função para encontrar a altura da arvore
int altura(No *no)
{
    if (no == NULL)
    {
        return -1;
    }

    else
    {
        return 1 + MAX(altura(no->esquerda), altura(no->direita));
    }
}

int main()
{


    ArvoreBin *arvore = criarArvore();
    int resultado_busca, n, k, c, q;

    do
    {
        printf("\n\nOpcoes: \n1 -> Inserir novo elemento na arvore;\n2 -> Remover um elemento da arvore;\n3 -> Buscar um elemento na arvore;\n4 -> Preordem; \n5 -> Emordem;  \n6 -> Posordem; \n7 -> Altura da arvore; \n8 -> Para Sair \n:");
        scanf("%d", &q); /* Le a opcao do usuario */
        switch (q)
        {
        case 1:
            printf("Gostaria de inserir quantos elementos na arvore:\n");
            scanf("%d", &n);
            printf("Digite %d Inteiros\n", n);
            for (c = 0; c < n; c++)
            {
                scanf("%d", &k);
                inserir(arvore, k);
            }
            break;
        case 2:
            printf("Gostaria de remover quantos elementos da arvore:\n");
            scanf("%d", &n);
            printf("Digite %d Inteiros\n", n);
            for (c = 0; c < n; c++)
            {
                scanf("%d", &k);
                deletarNo(arvore->raiz, k);
            }
            break;

        case 3:
            printf("Gostaria de buscar quantos elementos da arvore:\n");
            scanf("%d", &n);
            printf("Digite os elementos a serem buscados\n", n);
            for (c = 0; c < n; c++)
            {
                scanf("%d", &k);
                resultado_busca = busca(arvore->raiz, k);
                if (resultado_busca == 0)
                {
                    printf("Numero nao encontrado\n");
                }
                else
                {
                    printf("\nNumero encontrado na arvore:%d", resultado_busca);
                }
            }
            break;

        case 4:
            preOrdem(arvore->raiz);
            break;
        case 5:
            emOrdem(arvore->raiz);
            break;
        case 6:
            posOrdem(arvore->raiz);
            break;
        case 7:
            printf("tamanho da altura: %d\n", altura(arvore->raiz));
            break;
        case 8:
            break;
        default:
            printf("\n\n Opcao nao valida");
        }
    } while (q != 8);

    system("pause");
    return 0;
}