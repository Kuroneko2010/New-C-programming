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
        else if (month == 2 && day > 28 && year % 4 != 0)
        {
            Console.WriteLine("Invalid");
            Console.ReadLine();
        }
        else if (month == 4 || month == 6 || month == 9 || month == 8 || month == 11 && day > 30)
        {
            Console.WriteLine("Invalid");
            Console.ReadLine();
        }
        else
        {
            DateTime aDateTime = new DateTime(year, month, day);
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("February");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("March");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("April");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("May");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("June");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("July");
                    Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("August");
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("September");
                    Console.ReadLine();
                    break;
                case 10:
                    Console.WriteLine("October");
                    Console.ReadLine();
                    break;
                case 11:
                    Console.WriteLine("November");
                    Console.ReadLine();
                    break;
                case 12:
                    Console.WriteLine("December");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
