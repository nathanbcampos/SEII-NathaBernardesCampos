/*var janta = "peixe";*/
/**/
/*switch (janta){*/
/*	case "peixe":*/
/*		Console.WriteLine("peixe");*/
/*		break;*/
/*	case "frango":*/
/*		Console.WriteLine("frango");*/
/*		break;*/
/*	default:*/
/*		Console.WriteLine("Nao jantou");*/
/*	break;*/
/*}*/
/**/

var janta = "peixe";

var result = janta switch
{
	"torta de frango" => "torta de frango",
	"peixe" => "peixe",
	_ => "Não tem janta"
};

Console.WriteLine("A janta é " + result);
