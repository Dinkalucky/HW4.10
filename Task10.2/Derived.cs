using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    class Derived : Base
    {
        protected new void MethodFirst()
        {
            Console.WriteLine("DerivedMethodFirst");
        }
        protected override void MethodSecond()
        {
            Console.WriteLine("DerivedMethodSecond");
        }
    }
}
