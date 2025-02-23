Action loggerAction = () =>
{
    Console.WriteLine("This is simple");
};

Func<int, int> loggerFunc = (int x) => 
{
    return x+2;
};

Console.WriteLine(loggerFunc(3));

var list = Enumerable.Range(1,10).Select(i => i*3).ToList();

var callCall = (Action func) =>
{
    func();
};

callCall(loggerAction);
