using System;

namespace C_NOV21_MYCONSOL
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello World!");
            int x = 10, y = 5;
            double pi = 3.14;
            char color = 'r';
            decimal price = 45.50m;
            string name = "Hritvik";
            // Console.WriteLine("pi =" + pi + "price= " + price);
            //  Console.WriteLine("my name is " + name);
            //  Console.WriteLine("x={0} y={1} pi={2:F2} price ={3:c}", x, y, pi, price);
            string Name ;
            Console.WriteLine("enter your Name :");
            Name = Console.ReadLine();
            Console.WriteLine("my name is " + Name);
            Console.WriteLine("enter value of x");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter value of y");

            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x + y" + (x + y));

            Console.ReadKey();
        }
    }
}