//CRUD
//Create
List<int> numNums = [1, 2, 3, 4, 5];

//READ
/*foreach(var num in numNums)*/
/*{*/
/*    Console.WriteLine(num);*/
/*}*/

//Update
numNums.Add(6);

//Insert
numNums.Insert(0,0);

//Delete
/*var newNum = numNums.Where((i) => i != 2);*/
/*numNums.Remove(3);*/
numNums.RemoveAt(0);
foreach(var num in numNums)
{
    Console.WriteLine(num);
}

