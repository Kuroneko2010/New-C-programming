using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        string name1;
        Console.WriteLine("Vui lòng hãy nhập vào họ tên bố: ");
        name1 = Console.ReadLine();

        string name2;
        Console.WriteLine("Vui lòng hãy nhập vào họ tên mẹ: ");
        name2 = Console.ReadLine();

        int tuoi1;
        Console.WriteLine("Hãy nhập vào tuổi bố: ");
        tuoi1 = int.Parse(Console.ReadLine());

        int tuoi2;
        Console.WriteLine("Hãy nhập vào tuổi mẹ: ");
        tuoi2 = int.Parse(Console.ReadLine());

        if (tuoi1 > tuoi2)
        {
            Console.WriteLine("Xin chao {0}", name1);
            Console.ReadLine();
        }
        else if (tuoi1 == tuoi2)
        {
            Console.WriteLine("Xin chào cả 2 người ! {0} và {1}", name1, name2);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Xin chào {1}", name2);
            Console.ReadLine();
        }
    }
}