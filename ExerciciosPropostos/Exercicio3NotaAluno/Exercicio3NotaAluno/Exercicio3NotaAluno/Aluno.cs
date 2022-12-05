using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Exercicio3NotaAluno
{
    internal class Aluno
    {
        private string Nome;
        public double Nota1, Nota2, Nota3;
        
        public Aluno(string nome, double Nota1, double Nota2, double Nota3)
        {
            this.Nome = nome;
            this.Nota1 = Nota1;
            this.Nota2 = Nota2;
            this.Nota3 = Nota3;
        }

        public string getNome()
        {
            return this.Nome;

        }
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public static double retornaNum(double num1, double num2, double num3 = 0.0)
        {   
            
            return num1 + num2 + num3;
            
        }

        public static double retornaNum1(double num1, double num2, double num3)
        {

            return num1 + num2 + num3;

        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }

            // return NotaFinal() >= 60

        }

        public double NotaRestante()
        {
            if (Aprovado() == true)
            {
                return 0.0;
            }

            else
            {
                return 60.0 - NotaFinal();
            }

        }

       

    }

}