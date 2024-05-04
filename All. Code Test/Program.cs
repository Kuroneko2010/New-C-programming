using System;
using System.Text;
using System.Threading;

class Program
{
    static void Randomboys(string stt)
    {
        int[] boysnumbers = { 3, 6, 7, 9, 12, 13, 14, 15, 16, 17, 19, 26, 27, 30, 33, 38 };

        // Tạo một đối tượng Random
        Random random = new Random();
        string? a;
        Console.WriteLine("Bấm enter để bắt đầu random số của bạn nam : ");
        a = Console.ReadLine();

        if (a == "")
        {
            string stop = "";
            while (stop == "")
            {
                int randomNumberIndex = random.Next(0, boysnumbers.Length);
                int randomNumber = boysnumbers[randomNumberIndex];

                // Lưu vị trí hiện tại của con trỏ
                int currentLeft = Console.CursorLeft;
                int currentTop = Console.CursorTop;

                // In số random ra màn hình
                Console.Write("Số random: ");
                Console.WriteLine(randomNumber);

                // Đợi một khoảng thời gian trước khi tiếp tục
                Thread.Sleep(10); // Tăng thời gian chờ lên 100 milliseconds

                // Nếu có phím nào được nhấn, thoát khỏi vòng lặp
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    stop = "anything";
                }

                // Di chuyển con trỏ về vị trí ban đầu và xóa nội dung đã xuất
                Console.SetCursorPosition(currentLeft, currentTop);
                Console.Write(new string(' ', ("Số random: " + randomNumber).Length));
                Console.SetCursorPosition(currentLeft, currentTop);
            }

            // Xuất số đã chọn
            Console.WriteLine($"Số random : {stt}");
        }
    }
    static void Randomgirls(string stt)
    {
        int[] girlsnumbers = { 1, 2, 4, 5, 8, 10, 11, 18, 20, 21, 22, 23, 24, 25, 28, 29, 31, 32, 34, 35, 36, 37, 39, 40 };

        // Tạo một đối tượng Random
        Random random = new Random();
        string? a;
        Console.WriteLine("Bấm enter để bắt đầu random số của bạn nữ : ");
        a = Console.ReadLine();

        if (a == "")
        {
            string stop = "";
            while (stop == "")
            {
                int randomNumberIndex = random.Next(0, girlsnumbers.Length);
                int randomNumber = girlsnumbers[randomNumberIndex];

                // Lưu vị trí hiện tại của con trỏ
                int currentLeft = Console.CursorLeft;
                int currentTop = Console.CursorTop;

                // In số random ra màn hình
                Console.Write("Số random: ");
                Console.WriteLine(randomNumber);

                // Đợi một khoảng thời gian trước khi tiếp tục
                Thread.Sleep(10); // Tăng thời gian chờ lên 100 milliseconds
                                  // Nếu có phím nào được nhấn, thoát khỏi vòng lặp
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    stop = "anything";
                }
                Console.SetCursorPosition(currentLeft, currentTop);
                Console.Write(new string(' ', ("Số random: " + randomNumber).Length));
                Console.SetCursorPosition(currentLeft, currentTop);
            }

            // Xuất số đã chọn
            Console.WriteLine($"Số random : {stt}");
        }
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Random cặp đôi :");
        Randomboys("");
        Randomgirls("");

    }
}