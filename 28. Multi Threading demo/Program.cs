using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        DemoThread();
        DemoThread();
        DemoThread();
    }
    private static void DemoThread()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine(i);

        }
    }
}