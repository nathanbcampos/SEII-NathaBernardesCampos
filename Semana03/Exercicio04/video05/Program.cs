// See https://aka.ms/new-console-template for more information
//
// Linear Search Array
//
int[] array = new int[] {1, 2, 3, 4, 5, 7, 8, 9, 10 };

bool LinearSearch(int[] array, int key)
{
	for(int i = 0; i < array.Length; i++)
	{
		if (array[i] == key)
		{
		return true;
		}
	}

	return false;
}

Console.WriteLine(LinearSearch(array, 7));


