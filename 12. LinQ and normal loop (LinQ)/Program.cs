using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        //MƯỢN CODE CỦA KIẾN NGUYÊN (DO BÀI NÀY E K BT LÀM) 
        Console.InputEncoding = Encoding.UTF8;//Giải input sang Tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;//Giải output sang Tiếng Việt
        Console.WriteLine("Nhập số lượng phần tử của mảng : ");
        int n = int.Parse(Console.ReadLine());//Khai báo số lượng phần tử (n) của mảng
        int[] motMangGiDo = new int[n];//Khai báo mảng với n phần tử
        for (int i = 0; i < n; i++)//Vòng lặp với biến i, sau mỗi vòng lặp, tăng giá trị của biến i lên 1 đơn vị cho đến ít hơn giá trị n 1 đơn vị
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}");//Nhập phần tử thứ i+1 có nghĩa là phần tử thứ nhất sẽ bằng 0+1 = 1 => Nhập phần tử thứ 1, tương tự cho đến phần tử cuối cùng (n)
            motMangGiDo[i] = int.Parse(Console.ReadLine());//Nhập giá trị phần tử
        }

        HashSet<int> khongTrungLap = new HashSet<int>(motMangGiDo);//Tạo một mảng mới 1 với các giá trị từ mảng cũ, tuy nhiên loại bảo các giá trị bị trùng lặp
        int[] mangKhongTrungLap = new int[khongTrungLap.Count];//Tạo một mảng mới 2 với số lượng phần tử từ mảng cũ
        khongTrungLap.CopyTo(mangKhongTrungLap);//Copy mảng 1 và cho vào mảng 2
        int m = khongTrungLap.Count;//Tạo biến m bằng với số lượng phần tử của mảng 1
        int giaTriLonNhat = int.MinValue;//Tạo biến giá trị lớn nhất với giá trị bằng giá trị nhỏ nhất trong mảng
        int indexCuaGTLN = -999999999;//Tạo index của giá trị lớn bằng một giá trị bé hơn 0 (tùy chọn)
        int giaTriNhoNhat = int.MaxValue;//Tạo biến giá trị nhỏ nhất với giá trị bằng giá trị lớn nhất trong mảng
        int indexCuaGTNN = -999999999;//Tạo index của giá trị nhỏ nhất bằng một giá trị bé hơn 0 (tùy chọn)
        
        for (int i = 0; i < m; i++)
        {
            if (mangKhongTrungLap[i] > giaTriLonNhat)//Kiểm tra nếu phần tử ở vị trị thứ i ở mảng không trùng lặp lớn hơn giá trị lớn nhất
            {
                giaTriLonNhat = mangKhongTrungLap[i];//Gán giá trị lớn nhất bằng bới phần tử ở vị trí thứ i (Qua mỗi vòng lặp, nếu có giá trị lớn hơn thì giá trị lớn nhất sẽ lớn hơn nữa cho đến cuối vòng lặp
                indexCuaGTLN = i;//Gán index của giá trị lớn nhất bằng i. Do index bé hơn 0 mà i lại từ 0 trở lên nên index sẽ cứ thay đổi từ từ nếu đúng điều kiện lặp if

            }
        }
        
        for (int i = 0; i < m; i++)
        {
            if (mangKhongTrungLap[i] < giaTriNhoNhat)//Same
            {
                giaTriNhoNhat = mangKhongTrungLap[i];//Same
                indexCuaGTNN = i;//Same
            }
        }

        int a = m - 2;//Khai báo biến a bằng m - 2. Nên nhớ m lúc này bằng số lượng phần tử, a=m-2 có nghĩa là số lượng phần tử trong mảng sẽ bớt đi 2 phần tử là giá trị lớn nhất và giá trị nhỏ nhất ở 2 vòng lặp if phía trên
        int[] mangMoi = new int[a];//Khai báo mảng mới với a phần tử
        int indexCuaMangMoi = 0;//Khai báo index của mảng mới bằng 0, không thể gán là giá trị âm tùy chọn do sau đó index của mảng mới ++ sẽ là sai

        for (int i = 0; i < m; i++)
        {
            if (i != indexCuaGTLN && i != indexCuaGTNN)//Nếu biến i khác với 2 index lớn nhất và nhỏ nhất
            {
                mangMoi[indexCuaMangMoi] = mangKhongTrungLap[i];//Giá trị của phàn tử tại vị trí index của mảng mới sẽ bằng giá trị của mảng không trùng lặp tại vị trí i
                indexCuaMangMoi++;//Index của mảng mới tăng thêm 1 đơn vị sau mỗi lần lặp, cứ như vậy sẽ dần dần loại bỏ được 2 giá trị lớn nhất và nhỏ nhất
            }
        }
        
        Array.Sort(mangMoi);//Sắp xếp lại các phần tử trong mảng mới theo giá trị tăng dần 
        Console.WriteLine("Các phần tử của mảng sau khi làm gì đó là : ");
        
        foreach (var cringe in mangMoi)//Duyệt tất cả các phần tử trong mảng mới và xuất ra
        {
            Console.WriteLine(cringe);
        }

    }
}