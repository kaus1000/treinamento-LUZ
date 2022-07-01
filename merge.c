#include <stdio.h>
#include <stdlib.h> //Para usar calloc()
#include <stdbool.h>
#include <time.h>
#include <math.h>

//Chamando a função para preencher o array com os numeros aleatorios
void fill_random(int array[], int length, int max);

//swap- usado dentro do merge para fazer a troca dos numeros
void merge(int arr[], int l, int m, int r)
{
    int i, j, k;
    int n1 = m - l + 1;
    int n2 = r - m;
    /* criando array temporarios */
    int L[n1], R[n2];
      /* copiando os dados para os arrays temporarios L[] e R[] */
    for (i = 0; i < n1; i++)
        L[i] = arr[l + i];
    for (j = 0; j < n2; j++)
        R[j] = arr[m + 1 + j];

     /* funde os array temporarios de volta para arr[l..r]*/
    i = 0; // Índice inicial do primeiro subarray
    j = 0; // Índice inicial do segundo subarray
    k = l; // Índice inicial da fusão do subarray
    while (i < n1 && j < n2) {
        if (L[i] <= R[j]) {
            arr[k] = L[i];
            i++;
        }
        else {
            arr[k] = R[j];
            j++;
        }
        k++;
    }
    /* copia os elementos restantes L[], se existir algum */
    while (i < n1) {
        arr[k] = L[i];
        i++;
        k++;
    }
     /* copia os elementos restantes R[], se existir algum */
    while (j < n2) {
        arr[k] = R[j];
        j++;
        k++;
    }
}
 
/* l é para o index da esquerda e r é para o index da direita
sub-array para que arr seja ordenado */
void mergeSort(int arr[], int l, int r)
{
    if (l < r) {
        // o mesmo que (l+r)/2, mas evita que ultrapasse
        int m = l + (r - l) / 2;
 

        mergeSort(arr, l, m);
        mergeSort(arr, m + 1, r);
 
        merge(arr, l, m, r);
    }
}
 // Essa é a função que mostra o array no console
void printArray(int A[], int size)
{
    int i;
    for (i = 0; i < size; i++)
        printf("%d ", A[i]);
    printf("\n");
}
 
int main()
{
    srand( time(NULL) ); //é a função que manda para o rand o horario do computador
  
    int i;
    int a=101; //tamanho da array
    int *ptr; //ponteiro utilizado para alocar memoria dinamica com o calloc
    ptr = (int *)calloc(a, sizeof(int)); /*Aloca a números inteiros ptr pode agora ser tratado como um 
                                              vetor com a posicoes. ptr retorna um ponteiro void*/

    fill_random(ptr, a, 101);
 
    printf("Array Desordenada\n");
    printArray(ptr, a);
 
    mergeSort(ptr, 0, a - 1);
 
    printf("\nArray Ordenada \n"); // chamando a função (algoritmo) para realizar a ordenação dos numeros
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