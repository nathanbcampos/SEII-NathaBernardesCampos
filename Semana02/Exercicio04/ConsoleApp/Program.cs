/*int? value = null;*/
string? value2 = null;

/*Console.WriteLine("value: " + value);*/

if ( value2 is not null)
{
	Console.WriteLine("value2 : " + value2?.Length);
}

Console.WriteLine(value2 ?? "No Value!");
Console.WriteLine(value2 is not null ? "Has value!" : "No value");
