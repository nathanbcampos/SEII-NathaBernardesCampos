
bool Estudou = false;
bool notaBoa = false;
if ((Estudou) && (notaBoa))
{
	Console.WriteLine("Parabens voce estudou, e foi recompensado por isso");
}
else if((Estudou) && (!notaBoa)) {
	Console.WriteLine("Voce estudou mas não foi suficiente para sair bem na prova");
}
else if((!Estudou) && (!notaBoa)){
	Console.WriteLine("Teve o que merece");
}

