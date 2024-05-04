using System.IO;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        /*Viết hàm đọc vào một file .txt, sau đó ghi nội dung đọc được vào một file .txt khác với 
         nội dung đã được loại bỏ tất cả chữ số và được viết ngược lại ở dạng in hoa.
        Nội dung file: aBcdEfG123Hi
        Kết quả: IHGFEDCBA
        */

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        string content = "aBc7834DeFGh902384IkLMnOP";
        File.WriteAllText("inputfile.txt", content);
        string input = "inputfile.txt";
        string filecontent = File.ReadAllText(input);
        string uppercontent = filecontent.ToUpper();
       
        char[] reversedcontent = uppercontent.ToCharArray();
        Array.Reverse(reversedcontent);
        string newcontent = new string (reversedcontent);

        string print = new string (newcontent.Where(n => !char.IsDigit(n)).ToArray());
        File.WriteAllText("test.txt", print);
        Console.WriteLine("Kết quả: ");
        string a = File.ReadAllText("test.txt");
        Console.WriteLine(a);
        Console.ReadLine();
    }
}