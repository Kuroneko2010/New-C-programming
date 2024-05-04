using System.ComponentModel;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8; //*Giải mã input sang tiếng Việt
        Console.OutputEncoding = Encoding.UTF8; //*Giải mã output sang tiếng Việt
        //Array
        int[]numbers = {1,2,3,4,5,6,7,8}; //Khai báo array cùng giá trị các phần tử trong array
        Console.WriteLine("Các số trong array numbers chia hết cho 2 là (dùng vòng lặp for): ");
        for (int i=0; i < numbers.Length; i++) //Vòng lặp for cho biến i chạy từ 0 đến trước độ dài của array, sau mỗi vòng lặp, i + 1
        {
            if (numbers[i]%2==0) //Kiểm tra xem giá trị của phần tử tại vị trí i có phải chẵn không?
            { 
                Console.WriteLine(numbers[i]);  //Xuất ra
            }    
        
        }
        Console.WriteLine("Các số trong array numbers chia hết cho 2 là (dùng vòng lặp foreach): "); //Same as for
        foreach (int i in numbers) //Tạo biến i trong array numbers
        {
            if (numbers[i]%2==0) //Same
            { 
                Console.WriteLine(numbers[i]); 
            } //Same

        }  
    }
}