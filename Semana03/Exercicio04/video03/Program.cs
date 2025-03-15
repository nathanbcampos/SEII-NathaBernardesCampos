//Array 
//Array insertions 


int[] intArray = new int[6];

int length = 0;

for(int i =0; i < intArray.Length; i++)
{
	intArray[length] = i + 1;
	length++;
	/*Console.WriteLine("intArray["+ length + "] = " + intArray[i]);*/
}
/**/
/*intArray[length] = 8;*/
/*length++;*/
/*Console.WriteLine("intArray["+ length + "] = " + intArray[length]);*/
/*Console.WriteLine("_________________________");*/

/*for (int i = 4; i >= 0; i--)*/
/*{*/
/*	intArray[i + 1] = intArray[i];*/
/**/
/*}*/

/*intArray[0] = 20;*/
/*Console.WriteLine(intArray[0]);*/

for (int i = 4; i >= 2; i--)
{
	intArray[i + 1] = intArray[i];

}

intArray[2] = 390;

for (int j = 0; j < intArray.Length; j++)
{
	Console.WriteLine("intArray["+ j + "] = " + intArray[j]);
}
