class car //Tạo class car
{
    public int star; //Class car có 2 dữ liệu là star và speed
    public int speed;
     public void CarInfo ()//Tạo hàm car infomation
    {
        Console.WriteLine("Car information: Car star: " + star + "star(s) " + "car speed: " + speed + "km/h");
    }
}
internal class Program
{
    public static void Main(string[] args)//Hàm main
    {
        car car1 = new car();//Khai báo car1 là 1 car mới nên sẽ có star và speed
        car1.star = 5;//Gán dữ liệu cho car1, tương tự với những cái còn lại
        car1.speed = 999999;

        car car2 = new car();
        car2.star = 1;
        car2.speed = 20;
        car1.CarInfo();//Gọi hàm carinfo ra với car1
        car2.CarInfo();//Gọi hàm carinfo ra với car2
    }
}