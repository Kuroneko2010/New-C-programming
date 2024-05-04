using System.Text;

class human
{
    public int height;
    private int weight;
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        human human = new human();
        //ENCAPSULATION TÍNH ĐÓNG GÓI
        human.height = 300;
        human.weight = 100;//Lỗi vì weight được set ở private, có nghĩa là chỉ có trong class mới có thể sử dụng được
    }
}