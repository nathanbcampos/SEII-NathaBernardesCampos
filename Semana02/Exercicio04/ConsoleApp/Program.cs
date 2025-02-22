using ConsoleApp; 

Rat wolfRat = new Rat();
wolfRat.Name = "Mestre Splinter";
wolfRat.Number = 30;
wolfRat.IsRadioactive = true;


Console.WriteLine(wolfRat.Name);
Console.WriteLine(wolfRat.Number);
Console.WriteLine(wolfRat.IsRadioactive);

Console.WriteLine("---------------------");

Rat fancyRat = new Rat();
fancyRat.Name = "Leoncio";
fancyRat.Number = 10;
fancyRat.IsRadioactive = false;

Console.WriteLine(fancyRat.Name);
Console.WriteLine(fancyRat.Number);
Console.WriteLine(fancyRat.IsRadioactive);

Console.WriteLine("---------------------");

//Update
wolfRat.Name = "Wolf Rat";
Console.WriteLine(wolfRat.Name);

//Delete
wolfRat.Name = "";
Console.WriteLine(wolfRat.Name);
