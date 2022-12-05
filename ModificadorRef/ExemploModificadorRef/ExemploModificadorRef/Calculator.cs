using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploModificadorRef
{
    internal class Calculator
    {
        public static void Triple (ref int x)
        {
            x = x * 3;
        }

        public static void Triple1(int x)
        {
            x = x * 3;
        }
    }
}
