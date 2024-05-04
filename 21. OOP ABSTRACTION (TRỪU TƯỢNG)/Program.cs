abstract class Shape
{
    public int x;
    public int y;
    public int z;
    public void shapespeak()
    {
        Console.WriteLine("I'm a shape with x= " + x + " y= " + y + " z= " + z);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Shape shape = new Shape();//Ra lỗi vì Shape là abstract class nên không thể lấy ra ngoài, nếu thay bằng class Shape thông thường thì sẽ không có gì xảy ra
        shape.x = 10; shape.y = 20; shape.z = 30;
        shape.shapespeak();
    }
}