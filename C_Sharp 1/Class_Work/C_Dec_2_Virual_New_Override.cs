using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec_2_Virual_New_Override
{
    class Circle:shape
    {
        public int Radius { get; set; }
        public override void Area()
        {
            Console.WriteLine("Area of circle ="+Math.PI *Radius *Radius);
        }
         public Circle()
        {
            Radius = 3;
        }
    }
    
    }

