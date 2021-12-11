using System;

namespace C_DEC1_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mother m1 = new Mother();
            Console.WriteLine(m1);
            Daughter d1 = new Daughter();
            Console.WriteLine(d1);

            Daughter d2 = new Daughter(15, "bina", 45, "Tina");
        }
    }
}
