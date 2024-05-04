using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        int? number = null;
        if (number == null)
        {
            number = 2;
        }   
        if (number ==2)
        {
            Console.WriteLine("Number không hề có giá trị!");
        }
    }
}