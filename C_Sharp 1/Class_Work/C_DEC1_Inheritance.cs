using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DEC1_Inheritance
{
    class Daughter:Mother
    {
        public int D_age { get; set; }
        public string D_Name { get; set; }
        public Daughter():base()
        {
            D_age = 20;
            D_Name = "Prachi";
        }
        public Daughter(int dage,string dname,int mage,string mname):base(mage,mname)
        {
            D_age = dage;
            D_Name = dname;
            Console.WriteLine("Daughter object created");
        }
        public override string ToString()
        {
            return base.ToString()+  "Daughter's Name "  + D_Name +  "Daughter Age" + D_age;
        }
    }
    }

