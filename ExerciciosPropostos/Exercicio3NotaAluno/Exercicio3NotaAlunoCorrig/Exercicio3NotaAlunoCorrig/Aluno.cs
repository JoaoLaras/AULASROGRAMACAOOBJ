using System;
using System.Runtime.CompilerServices;

namespace Course
{
    class Aluno

    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }
            else
            {
                return 60.00 - NotaFinal();
            }

        }
    }
}