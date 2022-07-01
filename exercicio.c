#include <stdio.h>
int main ()
{
	int variavel1 = 10;
    int *variavel2 = &variavel1; /* Pega o endereco de memoria de variavel1 */
    int *variavel3 = variavel2; /* valor da variavel apontada  */
    
      
	printf ("\n\n%d\n",variavel1);
	printf ("Endereco para onde o ponteiro aponta: %p\n",variavel2);
	printf ("Valor da variavel apontada: %d\n",*variavel3); /* variavel3 é igualado a variavel1 de uma maneira indireta */
	return(0);
}