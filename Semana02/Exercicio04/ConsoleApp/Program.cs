//Counter
//
/*for(var i = 0; i < 7; i++){*/
/*	Console.WriteLine(i);*/
/*}*/

string[] professores = ["Alberto", "Carlos", "Roberto"];

/*for(var i = 0; i < nomes.Length; i++){*/
/*	Console.WriteLine(nomes[i]);*/
/*}*/


foreach(var aulas in professores){
	Console.WriteLine(aulas);
}

professores.ToList().ForEach((i) => {
	Console.WriteLine("ForEach: " + i);
});
