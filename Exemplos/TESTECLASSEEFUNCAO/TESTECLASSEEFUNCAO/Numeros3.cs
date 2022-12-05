using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTECLASSEEFUNCAO
{
    internal class Numeros3
    {
        public int N1;
        public int N2;
        public int N3;

        public
            static int Maior(int A, int B, int C)
        {
            int m;
            if (A > B && A > C)
            {
                m = A;
            }
            else if (B > C)
            {
                m = B;
            }
            else
            {
                m = C;
            }
            return m;
        }
    }
}
