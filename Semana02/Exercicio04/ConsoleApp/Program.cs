using System.Text;

//Create REad Update Delete
//CRUD
//Create

string petFish = "puffer fish";

//Concatenation
petFish = "porcupine " + petFish;

//Template Literal
/*Console.WriteLine($"I AM BUYING {petFish}. YOU CANNOT STOP ME!!!");*/

/*Console.WriteLine(petFish);*/

//Read
//Console.Writeline()

//Update
string newPetFish = petFish.Replace("porcupine", "bluer dot");
Console.WriteLine(newPetFish);

//DELETE
StringBuilder newCrustacen = new StringBuilder();
newCrustacen.Append("fiddler crab");
Console.WriteLine(newCrustacen);
newCrustacen.Remove(0, 8);
Console.WriteLine(newCrustacen);
