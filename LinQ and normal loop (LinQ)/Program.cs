using System;
using System.Text;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //MƯỢN CODE CỦA AI, DO BÀI NÀY E CX K BT LÀM NỐT;;;-;;;
        Console.InputEncoding = Encoding.UTF8;//Giải mã input sang Tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;//Giải mã output sang Tiếng Việt
        Console.WriteLine("Nhập số lượng phần tử của mảng : ");
        int n = int.Parse(Console.ReadLine());
        int[] motMangGiDo = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập phần tử thứ {i + 1}");
            motMangGiDo[i] = int.Parse(Console.ReadLine());
        }
        //Nhập vào các giá trị phần tư mảng giống trong normal loop
        var khongTrungLap = motMangGiDo.Distinct().ToArray();//Sử dụng phương thức Distinct() của LinQ để loại bỏ các giá trị trùng lặp trong mảng motMangGiDo và lưu vào mảng KhongTrungLap
        int giaTriLonNhat = khongTrungLap.Max();//Sử dụng phương thức Max() trong LinQ để tìm ra giá trị lớn nhất và lưu vào giaTriLonNhat
        int indexCuaGTLN = Array.IndexOf(khongTrungLap, giaTriLonNhat);//Lấy vị trí của giá trị lớn nhất trong mảng không trùng lặp, IndexOf là một phương thức tìm kiếm dữ liệu trong Array
        int giaTriNhoNhat = khongTrungLap.Min();//Same
        int indexCuaGTNN = Array.IndexOf(khongTrungLap, giaTriNhoNhat);//Same    
        int[] mangMoi = khongTrungLap.Where((value, index) => index != indexCuaGTLN && index != indexCuaGTNN).ToArray();//Lọc bỏ các giá trị lớn nhất và nhỏ nhất và lưu kết quả vào mảng mới. 
        //Trong đó, value là giá trị của phần tử, index là chỉ số của phần tử. Dòng code này kiểm tra xem phần tử có chỉ số (vị trí i) trùng với chỉ số của giá trị lớn nhất và giá trị nhỏ nhất hay không.
        //Nếu không, giá trị của phần tử đó sẽ được chọn và đưa vào mảng mới. Do đó, sau khi kết thúc, mảng mới sẽ có các giá trị được loại bỏ giá trị lớn nhất và nhỏ nhất từ mảng không trùng lặp
        Array.Sort(mangMoi);//Tương tự với bên normal loop
        Console.WriteLine("Các phần tử của mảng sau khi làm gì đó là : ");
        foreach (var blahblah in mangMoi)
        {
            Console.WriteLine(blahblah);
        }

    }
}
