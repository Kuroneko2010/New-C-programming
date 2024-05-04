class shape
{
    public virtual void speak ()
    {
        Console.WriteLine("I'm a shape");
    }
}

class circle : shape
{
    public override void speak()
    {
        Console.WriteLine("Circle is a shape");
    }
}

class square : shape
{
    public override void speak()
    {
        Console.WriteLine("Square is a shape");
       
    }
}

    internal class Program
{
    private static void Main(string[] args)
    {
        shape circle = new circle();
        shape square = new square();
        circle.speak();
        square.speak();
    }
}