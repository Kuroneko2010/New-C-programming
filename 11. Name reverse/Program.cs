using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        string name = " ";
        Console.WriteLine("Hãy nhập vào họ tên nhân vật: ");

        name = Console.ReadLine();
        Console.WriteLine("Tên nhân vật đầy đủ ban đầu là: " + name);
        string []Tungphan = name.Split(" ");
        string Viettat = "";
      
        foreach (var Tungphan2 in Tungphan)
        {
            Viettat = Viettat + Tungphan2.Substring(0, 1);
        }

            
        string Viettatthuong = Viettat.ToLower();
        char[] chars1 = Viettatthuong.ToCharArray();
        Array.Reverse(chars1);
        string Xuat1 = new string(chars1);

        char[] chars = name.ToCharArray();
        Array.Reverse(chars);
        string strings = new string(chars);
        string Xuat2 = strings.Replace(" ", "");
            
        Console.Write($"Tên nhân vật bị đảo ngược và xóa khoảng trắng là:  {Xuat1} {Xuat2}" );
    }
}
