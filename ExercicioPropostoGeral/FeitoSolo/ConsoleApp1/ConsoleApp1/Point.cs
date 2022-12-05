using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Point
    {
        public char X;
        public char  Y;

        public override string ToString()
        {
            return "( " + X + ", " + Y + ")";
        }
    }


}
