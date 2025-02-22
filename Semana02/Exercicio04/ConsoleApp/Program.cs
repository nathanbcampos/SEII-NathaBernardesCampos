var values = ("t", 2, "p");

Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);
Console.WriteLine(values.Item3);

var valuesWithNmae = (First: "t", Second: 20, Third: "p");
Console.WriteLine(valuesWithNmae.Second);


(int a, string b, bool c) ReturnTheseValues()
{
	return (9, "u", true);
}

var tupleReturnValue = ReturnTheseValues();

Console.WriteLine(tupleReturnValue.a);
