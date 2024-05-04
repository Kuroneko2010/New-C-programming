using System.Text;

internal class Program
{
    //Hàm chỉ có thể được tạo ra trong class
    //Public = Tất cả hàm đều được
    //Private = Hàm trong class thôi
    static void Main(string[] args) //Hàm main, máy tính sẽ CHỈ CHẠY code có trong hàm này từ dấu { -> }. Máy tính sẽ không quan tâm đến các code có trong nơi khác. Do đó phải gọi lại hàm tự viết trong hàm main để máy tính xử lí
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        XayDungHam();//Gọi lại hàm để máy tính xử lí code trong hàm
    }
    static void XayDungHam()//Tạo hàm, vì trong hàm main phải có từ khóa static nên muốn hàm chạy trong hàm main thi cũng phải có từ khóa static. Hàm void không cần phải có từ khóa return
    {
        Console.WriteLine("Nhập vào số để kiểm tra là số chẵn hay số lẽ: ");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Số điền vào là số chẵn");
        }
        else
        {
            Console.WriteLine("Số điền vào là số lẽ");
        }
        //Khi chạy code, màn hình vẫn chạy ra những dòng lệnh nhừng thật chất chúng được lấy ra từ hàm XayDungHam
    }
}