using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Param
    {
        public float height { get; set; }
        public float width { get; set; }

        public override string ToString()
        {
            return "heigth=" + this.height + " width=" + this.width;
        }
    }
}
