using AlgorithmsDataStructure.Stack;

Stack stack = new Stack(10);


for(int i = 0; i < 3; i++)
{
	stack.Push("Squirtle");
	stack.Push("Pikachu");
	stack.Push("Charmander");
}

stack.Pop();
stack.Peek();

while(!stack.isEmpty())
{
	var var = stack.Pop();
	Console.WriteLine(var);
}
