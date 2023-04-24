using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public class Base
    {
        public void BaseMethod()
        {
            MethodFirst();
            MethodSecond();
        }

        protected virtual void MethodFirst()
        {
            Console.WriteLine("BaseMethodFirst");
        }
        protected virtual void MethodSecond()
        {
            Console.WriteLine("BaseMethodSecond");
        }
    }
}
