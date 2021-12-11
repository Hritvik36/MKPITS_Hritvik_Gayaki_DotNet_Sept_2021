using System;

namespace C_NOV25_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = new string[5];
            //// datatype [] name of array= new datatype[size];
            ////int myarray[6]; in c langugae
            //Console.WriteLine("enter names of fruits ");
            //for (int i = 0; i < 5; i++)
            //{
            //    fruits[i] = Console.ReadLine();
            //}
            //Console.WriteLine("following are the fruits u entered");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(fruits[i]); //output loop
            //}
            //int[] marks = new int[5];
            //Console.WriteLine("enter five numbers");
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("given marks are");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(marks[i]);
            //    sum += marks[i];
            //}
            //Console.WriteLine("sum of marks= " +sum);
            //Console.ReadKey();
            string[] fruits = { "Apple", "Banana", "Orange", "Mango", "Grapes" };
            Console.Write("Fruit names ");
            foreach (string f in fruits)
            {

                Console.Write(f + " ");
            }
            Console.WriteLine("size of array fruit is"+fruits.Length);

            Array.Sort(fruits);
            Console.WriteLine("sorted array of fruits is");
            foreach (string f in fruits)
            {

                Console.Write(f + " ");
            }
            Array.Reverse(fruits);
            Console.WriteLine("sorted array of fruits in descending order ");
            foreach (string f in fruits)
            {
                Console.Write(f + " ");
            }
            Console.ReadLine();

            
        }
    }
}
