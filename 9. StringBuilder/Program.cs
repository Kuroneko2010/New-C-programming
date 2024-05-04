using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        string Familyname; // Tạo biến họ
        Console.WriteLine("Please sign in your family name/ Vui lòng nhập vào họ: ");
        Familyname = Console.ReadLine(); // Nhập bào biến họ

        string Lastname; //Tạo biến tên
        Console.WriteLine("Please sign in your last name/ Vui lòng nhập vào tên: ");    
        Lastname = Console.ReadLine(); //Nhập vào biến tên

        Console.WriteLine($"Your fullname is/ Họ tên của bạn là: {Familyname} {Lastname}"); // Ghép cả tên và họ tạo thành họ tên đầy đủ
    }
}