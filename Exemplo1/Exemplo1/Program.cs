using System;

namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] valores = new int[10];
            double[] preco = new double[10];
            string[] nomepro = new string[10];

  
            for (int i = 0; i <= valores.Length; i++)
            {
                Console.WriteLine("Digite um Valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= valores.Length; i++) {
                Console.WriteLine("Valor: "+ valores[i]);
            }

            Console.ReadKey();

           
        }
    }
}