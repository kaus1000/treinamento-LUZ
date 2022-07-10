#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h> //Para usar calloc()
#include <time.h>

//Chamando a função para preencher o array com os numeros aleatorios
void fill_random(int array[], int length, int max);

//swap- usado dentro do bubble para fazer a troca dos numeros
void swap(int *xp, int *yp)
{
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}
  
// Aqui é a implementação do Bubble Sort no codigo
void bubbleSort(int arr[], int n)
{
   int i, j;
   bool swapped;
   for (i = 0; i < n-1; i++)
   {

    //  printf("%d ", n-1);
     swapped = false; // swapped controle para saber se a posição foi trocada
     for (j = 0; j < n-i-1; j++)
     {
        printf("\nj:%d i:%d ", j, i);
        if (arr[j] > arr[j+1])
        {
           swap(&arr[j], &arr[j+1]);
           swapped = true;
        }
     }
  
     // dois elementos não forem trocados no loop, 
     if (swapped == false)
        break;
   }
}
  
// Essa é a função que mostra o array no console
void printArray(int arr[], int size)
{
    int i;
    for (i=0; i < size; i++)
        printf("%d ", arr[i]);
    printf("n");
}

int main()
{
    srand( time(NULL) ); //é a função que manda para o rand o horario do computador
  
    int i;
    int a=11; //tamanho da array
    int *ptr; //ponteiro utilizado para alocar memoria dinamica com o calloc
    ptr = (int *)calloc(a, sizeof(int)); /*Aloca a números inteiros ptr pode agora ser tratado como um 
                                              vetor com a posicoes. ptr retorna um ponteiro void*/

    // preenche com numeros inteiros aleatorios
    fill_random(ptr, 11, 11);


    bubbleSort(ptr, a); // chamando a função (algoritmo) para realizar a ordenação dos numeros
    printf("Array Ordenada: \n");
    printArray(ptr, a); //mostrar os numeros ordenados

    system("pause"); // pausar antes de fechar o console
    return 0; // finalizar o programa
}
void fill_random(int array[], int length, int max) //função que preenche o array com numeros aleatorios
{
  // esse for está rodando a array[i] para preenche-lá
  for (int i = 0; i < length; i++)
    array[i] = ((rand() * rand()) % max) + 1;
    // Esse array multiplica o tamanho de rand para conseguir sortear numeros maiores. Max é rand maximo de numeros
    //aleatorios que pode gerar, e o +1 é para não começar do 0.
}