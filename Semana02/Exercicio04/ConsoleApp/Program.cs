using ConsoleApp;

RealState elmStreet = new("Elm Street");
Console.WriteLine(elmStreet.Address);
elmStreet.Address = "Main Street";
Console.WriteLine(elmStreet.Address);

