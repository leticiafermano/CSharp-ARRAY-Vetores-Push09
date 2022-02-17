using System;

namespace LogicaDeProgramacao_P6_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Vetores (ARRAYS)
            É uma estrutura que permite armazenar informações de forma sequenciada.
             */

            string[] nomes = { "Letícia", "Célio", "Luana", "Vanda", "Vanderlei" };
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            double[] valores = { 145, 10, 20, 50, 26 };
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
