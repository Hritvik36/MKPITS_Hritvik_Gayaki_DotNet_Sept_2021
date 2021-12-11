using System;

namespace C_DEC1_Var_ref_out_parparmeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 10; // interference as x is int 
            //var price = 80.50m; //money is used for decimal type
            //var r = 5.689;
            //var name = "Hritvik";
            //Console.WriteLine("x="+x+"price="+price+" r= "+r+" name ="+name);


            //int a = 200, b = 100;
            //Console.WriteLine("A ="+a+"B ="+b+ "before calling swap function");
            // swap(ref a, ref b
            //    Swap(a, b);
            //    Console.WriteLine("A = "+a+"B = "+b+ "after calling swap function");
          //  int radius = 7;
            // double ar;
             // Area(ref radius, out ar);
            // Console.WriteLine("radius = "+ radius+ "Area of circle ="+ar);
            viewname('b', 4, "Hritvik", "Akash", "Nilesh", "Roshan");
            viewname('g', 3, "pooja", "kajal", "Nikita");
        }
        public static void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }
        //public static void Swap(int x,int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        // }
        public static void Area(ref int r, out double a)
        {
            a = Math.PI * r * r;

        }
        // params=parameters
        static void viewname(char x,int n,params string[]names)
        {
            if (x == 'b')
            {
                Console.WriteLine("Boys present in my class are");
                for (int i =0;i< n; i++)
                    Console.WriteLine(names[i]);
            }
            else if(x=='g')
            {
                Console.WriteLine("Girls present in my class are");
                for (int i=0;i<n;i++)
                    Console.WriteLine(names[i]);
            }

        }
    }
}
