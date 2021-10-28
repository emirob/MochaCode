using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Util
    {
        private readonly Param p = null;
        public Util(Param p)
        {
            this.p = p;
        }

        public void Print()
        {
            Console.WriteLine(p.ToString());
        }
    }
}
