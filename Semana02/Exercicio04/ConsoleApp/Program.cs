//Array CRUD
//
//Create
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat", "wolf rat"];

//Read

//Update
/*favoriteRats[0] = "Fancy Rat"; */
// LINQ - "update array linq"


var newFavorieRats = favoriteRats.Where((e) => e.StartsWith("b"));

foreach(var rat in newFavorieRats)
{
	Console.WriteLine(rat);
};
