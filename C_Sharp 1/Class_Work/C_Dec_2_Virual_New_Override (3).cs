using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec_2_Virual_New_Override
{
    class shape
    {
        public string color;
        public virtual void Area()
        {
            Console.WriteLine("Area of Shape");
        }
        public shape()
        {
            color = "Blue";
        }
    }
}
