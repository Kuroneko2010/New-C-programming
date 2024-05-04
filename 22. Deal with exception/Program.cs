


internal class Program
{
    static int and(int x, int y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException();
        }
        return x / y;
    }
    public static void Main(string[] args)
    {
        int a = 99;
        int b = 0;
        int result;
        try
        {
            result = and (a, b);
            Console.WriteLine("{0} / {1} = {2}", a, b, result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Divide by 0 = Skill issue");
        }
    }
}