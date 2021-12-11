using System;

namespace C_DEC1_Count_product_with_string_aaray
{
    class Program
    {
        static void Main(string[] args)
        {
            CountProduct("soap", "Facewash", "sugar");
            Console.WriteLine("Following Fruits are:");
            CountProduct("Mango", "Apple", "Orange");
        }
        public static void CountProduct(params string[] product)
        {
            foreach(string p in product)
            {
                Console.WriteLine(p + " ");
            }
            Console.WriteLine("count ="+product .Length);
        }
        public static void GetDetails(int id,string name,string desigination)
        {
            Console.WriteLine("id : "+id+"name:"+name+"desigination"+desigination);
        }
    }
}
