#include <stdio.h>
#include <stdlib.h> //Para usar calloc()
#include <stdbool.h>
#include <time.h>
#include <math.h>

//Chamando a função para preencher o array com os numeros aleatorios
void fill_random(int array[], int length, int max);

void swap(int *a, int *b) {
  int t = *a;
  *a = *b;
  *b = t;
}

int partition(int array[], int low, int high) {
  
  int pivot = array[high];
  
  int i = (low - 1);

  for (int j = low; j < high; j++) {
    if (array[j] <= pivot) {
        
      i++;
      
      swap(&array[i], &array[j]);
    }
  }

  swap(&array[i + 1], &array[high]);
  
  return (i + 1);
}

void quickSort(int array[], int low, int high) {
  if (low < high) {
    
    int pi = partition(array, low, high);
    
    quickSort(array, low, pi - 1);
    
    quickSort(array, pi + 1, high);
  }
}
// Essa é a função que mostra o array no console
void printArray(int array[], int size) {
  for (int i = 0; i < size; ++i) {
    printf("%d  ", array[i]);
  }
  printf("\n");
}

int main() {
  srand( time(NULL) ); //é a função que manda para o rand o horario do computador
  
  int i;
  int a=100; //tamanho da array
  int *ptr; //ponteiro utilizado para alocar memoria dinamica com o calloc
  ptr = (int *)calloc(a, sizeof(int)); /*Aloca a números inteiros ptr pode agora ser tratado como um 
                                              vetor com a posicoes. ptr retorna um ponteiro void*/

  fill_random(ptr, a, 101);
  
  
  quickSort(ptr, 0, a - 1);
  
  printf("Array Ordenada: \n"); // chamando a função (algoritmo) para realizar a ordenação dos numeros
  printArray(ptr, a); //mostrar os numeros ordenados
  // printf("%d  ", ptr[0]);
  // printf("%d  ", ptr[a-1]);
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