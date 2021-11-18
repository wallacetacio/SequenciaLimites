using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        { 

            int inicio;

            int fim;

            Console.Write("Inicio: ");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fim: ");
            fim = Convert.ToInt32(Console.ReadLine());

            if(inicio > fim)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERRO! ");
                Console.ResetColor();
                Console.WriteLine("O número de inicio deve ser menor que o número de fim.");
            }else
            {
                while (inicio <= fim)
                {
                    Console.Write($" {inicio} ");
                    inicio = inicio + 1;
                }
            }
        }
    }
}
