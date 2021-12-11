using System;

namespace C_NOV25_STATICFUNCTION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Area_circle(radius);
            Area_circle(7);
            Console.ReadLine();
        }
        public static void Area_circle(int r)
        {
            double a= Math.PI * r * r;
            Console.WriteLine("The area of circle is ={0:F3}", a);
            }
    }
}
