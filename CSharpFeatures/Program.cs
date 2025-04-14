namespace CSharpFeatures;

class Program
{
    static void Main(string[] args)
    {
       Action action = () => Console.WriteLine("Hello World!");
       action();
       Func<int, int,int> add = (x, y) => x + y;
       Console.WriteLine(add(2, 3));
       Predicate<int> isEven = x => x % 2 == 0;
       Console.WriteLine(isEven(3));
       CustomDelegate add2 = Add;
       Console.WriteLine(add2(2, 3));
    }

    public delegate int CustomDelegate(int x, int y);

    public static int Add(int x, int y)
    {
        return x + y;
    }
}