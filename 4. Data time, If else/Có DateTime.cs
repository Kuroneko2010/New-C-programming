using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Mời nhập vào ngày tháng năm của bạn: ");
        
        Console.Write("Ngày: ");
        int day = Int32.Parse(Console.ReadLine());
        
        Console.Write("Tháng: ");
        int month = Int32.Parse(Console.ReadLine());
       
        Console.Write("Năm: ");
        int year = Int32.Parse(Console.ReadLine());

        if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1)
        {
            Console.WriteLine("Invalid");
            Console.ReadLine();
        }
        else if (month==2 && day>28 && year%4!=0)
        {
            Console.WriteLine("Invalid");
            Console.ReadLine();
        }
        else if (month==4 || month==6|| month==9|| month==8|| month== 11 && day>30 )
        {
            Console.WriteLine("Invalid");
            Console.ReadLine();
        }
        else
        {
            DateTime aDateTime = new DateTime(year, month, day);
            DateTime NextDays = aDateTime.AddDays(1);
            Console.WriteLine("Ngày tháng năm tiếp theo sẽ là {0}", NextDays.ToString("dd/MM/yyyy"));
        }
    }
}