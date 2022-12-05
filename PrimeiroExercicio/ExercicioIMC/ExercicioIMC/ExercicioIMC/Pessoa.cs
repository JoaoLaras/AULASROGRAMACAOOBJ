using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioIMC
{
    internal class Pessoa
    {
        public double peso, altura;

        //CALCULO IMC
        public double calculoImc()
        {
            return peso / (altura * altura);
            


        }

        // SITUACAO
        public string situacao(double imc)
        {
            //Variável
            string retorno;

            // Condicional

            if (imc < 18.5)
            {
                retorno = "Abaixo do Peso";
            }

            else if (imc < 25)
            {
                retorno = "Peso normal";
            }

            else if (imc < 30)
            {
                retorno = "Acima do Peso";
            }

            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }

            else if (imc < 40)
            {
               retorno = "Obesidade II";
            }

            else
            {
                retorno = "Obesidade III";

            }

            //retorno
            return retorno;


        }
        public void mensagem()
        {
            // obter o calculo

            double imc = calculoImc();

            // Obter situacao

            string msgImc = situacao(imc);

            

            // Exibir Mensagem 

            Console.Write("Seu IMC é de "+ imc );
            Console.WriteLine(" e sua situacão é "+ msgImc);
            


        }




    }



}
