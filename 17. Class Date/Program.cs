
using System.Text;
public class Date
{
    public string year; public string month; public string day;
    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && year % 100 != 0;
    }
    public int[] GetDate(string day, string month, string year)
    {
    
            Console.WriteLine("Nhập ngày: ");
            day = Console.ReadLine();
            Console.WriteLine("Nhập tháng: ");
            month = Console.ReadLine();
            Console.WriteLine("Nhập năm: ");
            year = Console.ReadLine();
            int intday; int intmonth; int intyear;
            while (!int.TryParse(day, out intday) || !int.TryParse(month, out intmonth) || !int.TryParse(year, out intyear) || !IsValidDate(intday, intmonth, intyear))
            {
                Console.WriteLine("Nhập ngày tháng năm đã bị lỗi! Vui lòng nhập lại");
                Console.WriteLine("Nhập ngày: ");
                day = Console.ReadLine();
                Console.WriteLine("Nhập tháng: ");
                month = Console.ReadLine();
                Console.WriteLine("Nhập năm: ");
                year = Console.ReadLine();
            }

        int[] intTime = { intday, intmonth, intyear };
            return intTime;
    }
    public bool IsValidDate(int day, int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (IsLeapYear(year))
        {
            daysInMonth[1] = 29;
        }
        if (day < 1 || month < 1 || month > 12 || year < 1 || day > daysInMonth[month - 1])
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public int[] NextDays(int[] Time)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (IsLeapYear(Time[2]))
        {
            daysInMonth[1] = 29;
        }
        Time[0]++;
        if (Time[0] > daysInMonth[Time[1] - 1]) 
        {
            Time[0] = 1;
            Time[1]++;
            if (Time[1] >12)
            {
                Time[1] = 1;
                Time[2]++;
            }
        }
        Time[0]++;
        if (Time[0] > daysInMonth[Time[1] - 1])
        {
            Time[0] = 1;
            Time[1]++;
            if (Time[1] > 12)
            {
                Time[1] = 1;
                Time[2]++;
            }
        }
        int[]Next2Days = {Time[0], Time[1], Time[2] };
        return Next2Days;

    }
    public void PrintScreen(int[]Time)
    {
        Console.WriteLine($"2 ngày tiếp theo tính từ ngày được nhập vào là: {Time[0]}/{Time[1]}/{Time[2]},  ");
    }
}

    internal class Program
    {
        public static void Main(string[] args)
        {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Date Time = new Date();
        string day = "";
        string month = "";
        string year = "";
        int[] TimeArray = Time.GetDate(day, month, year);
        Time.NextDays(TimeArray);
        Time.PrintScreen(TimeArray);
        }
    }

