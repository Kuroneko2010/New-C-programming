using System.Text;

class triangle
{
    public int x; public int y; public int z;
    public void triangleinfo()
    {
      Console.WriteLine("X: " + x + " Y: " + y + " z: " + z);
    }
}

class spectriangle : triangle
{
    public spectriangle()
    {
        x = 30;
        y = 20; 
        z = 130;

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        spectriangle spectriangle = new spectriangle();
        spectriangle.triangleinfo();
    }
}