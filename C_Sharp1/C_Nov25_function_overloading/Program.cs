using System;

namespace C_Nov25_function_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the values");
              int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
             Sum(a,b,c);
            Sum(12, 15, 14);
            Sum(12, 24);
        }
        public static void Sum(int a,int b,int c)
        {
            int S= a + b + c;
            Console.WriteLine("sum of three number"+S);
        }
        public static void Sum(int a, int b)
        {
            int S = a + b ;
            Console.WriteLine("sum of two number" + S);
        }
    }
}
