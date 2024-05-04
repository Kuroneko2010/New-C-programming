internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Hay nhap vao 1 so");
        number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("So {0} ma ban vua nhap la so chan", number);
            Console.ReadLine();
        }    
        else 
        {
            Console.WriteLine("So {0} ma ban vua nhap la so le", number);
            Console.ReadLine();
        }
    }
}