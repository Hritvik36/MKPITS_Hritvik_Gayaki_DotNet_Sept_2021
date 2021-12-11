using System;

namespace C_DEC1_Convert_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            char rainbowcolor;
            Console.WriteLine("enter color code");
            rainbowcolor = Convert.ToChar(Console.ReadLine());
            // "R"   and 'R' are not same
            Console.WriteLine("rain bow color is" + rainbowcolor);
            decimal price;
            Console.WriteLine("enter price");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("price ={0:c}",price);
            bool ans = true;
            Console.WriteLine("enter answer true/false");
            ans = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("yes I wnat to repeat" +ans);
            DateTime today;
            Console.WriteLine("enter date");
            today = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("today is " + today);
        }
    }
}
