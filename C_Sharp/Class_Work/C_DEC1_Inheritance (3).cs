using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DEC1_Inheritance
{
    class Mother
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Mother()
        {
            Age = 45;
            Name = "chanda";
        }
        public Mother(int age,string name)
        {
            Age = age;
            Name = name;
            Console.WriteLine("mother object created");
        }
        public override string ToString()
        {
            return "Mother's Name"  + Name +  "Age"  + Age;
        }

    }
}
