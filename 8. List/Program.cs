using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;  
        List<int> numberss = new List<int>(); //Tạo list với không phần tử
        numberss.Add(1); //Thêm các phần tử vào list
        numberss.Add(2);
        numberss.Add(3);
        numberss.Add(4);
        numberss.Add(5);
        numberss.Add(6);
        numberss.Add(7);
        numberss.Add(8);
        Console.WriteLine("Các số lẻ trong list là: ");
        
        foreach (int a in numberss) //Dùng vl foreach với biến a trong list
        {
            if (numberss[a] % 2 != 0) //Kiểm tra nếu phần tử lần lượt ở vị trí a chia 2 khác 0, hay là số lẻ
            {
                Console.WriteLine(numberss[a]);//Xuất ra 
               
            }
        }
    }
}