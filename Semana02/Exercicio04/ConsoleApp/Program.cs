
Person person1 = new("Marco", "Silva", 30, new string[1]  {"9022-3842"});
Person person2 = new("Marco", "Silva", 30, new string[1]  {"9022-3842"});
/*Person person2 = new("Pedro", "Oliveira", 23,new string[1]  {"3234-4234"});*/

//Immutability 
/*person1.LastName = "silva";*/
/*person2.PhoneNumber[0] = "0000-4230";*/

//Equality
//value
//Referential
Console.WriteLine(person1 == person2);

//Non-destructive (copy)
Person person3 = person2 with {LastName = "Brewski"};
Console.WriteLine(person3.ToString());

public record Person(string FirstName, string LastName, int Age, string[] PhoneNumber);


