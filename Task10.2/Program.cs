using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public class Program
    {
        static void Main(string[] args)
        {
           Base @base = new Derived();

            @base.BaseMethod();
            Console.ReadLine();
        }
    }
}
