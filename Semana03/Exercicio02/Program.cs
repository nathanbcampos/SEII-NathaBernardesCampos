
int[] myArray = new int[10];
string[] myString = new string[7];
myString[0] = "Monday"; 
myString[1] = "Tuesday"; 
myString[2] = "Wednesday"; 
myString[3] = "Thursday"; 
myString[4] = "Friday"; 
myString[5] = "Saturday"; 
myString[6] = "Sunday"; 

/*for (int i = 0; i < myString.Length; i++)*/
/*{*/
/*	Console.WriteLine(myString[i]);*/
/*}*/

List<string> list = new List<string>();

list.Add("Monday"); 
list.Add("Tuesday"); 
list.Add("Wednesday"); 
list.Add("Thursday"); 
list.Add("Friday"); 
list.Add("Saturday"); 
list.Add("Sunday"); 

/*for (int i = 0; i < myString.Length; i++)*/
/*{*/
/*	list[i] = list[i].Substring(0,3);*/
/*	Console.WriteLine(list[i]);*/
/*}*/

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary[0] = "Monday"; 
dictionary[1] = "Tuesday"; 
dictionary[2] = "Wednesday"; 
dictionary[3] = "Thursday"; 
dictionary[4] = "Friday"; 
dictionary[5] = "Saturday"; 
dictionary[6] = "Sunday"; 

for (int i = 0; i < myString.Length; i++)
{
	dictionary[i] = dictionary[i].Substring(0,3);
	Console.WriteLine(dictionary[i]);
}
