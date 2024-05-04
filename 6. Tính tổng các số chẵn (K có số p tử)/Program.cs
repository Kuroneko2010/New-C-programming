using System.Text;

internal class Program
{
    private static void Main(string[] args)
    { 
    int sum = 0; 
    int number;
    do
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số (nhập 0 để kết thúc): ");
        number = int.Parse (Console.ReadLine());   
        if (number % 2 == 0)
        {
                sum = sum + number;
        }
    }
    while (number != 0) ;
    Console.WriteLine("Tổng của tất cả các số chẵn là: " + sum);
    }
}