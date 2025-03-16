int[] intArray = new int[9];

int lenght = 0;
/*Preenche os array*/
for(int i = 0; i < 6; i++)
{
	intArray[lenght] = i;
	lenght++;
}


/*Deleta o ultimo array*/
/*lenght--;*/

/*Deleta o primeiro array*/
/*for (int i = 1; i < lenght; i++)*/
/*	intArray[i - 1] = intArray[i];*/

/*Deleta o array do meio */
for (int i = 4; i < lenght; i++)
	intArray[i - 1] = intArray[i];

lenght--;


for(int i =0; i < lenght; i++)
	Console.WriteLine(intArray[i]);
