using System;
using Bin2Dec.Entities.Exceptions;
using Bin2Dec.Entities;


namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número binário de até 8 dígitos:");

                int Numero = int.Parse(Console.ReadLine());

                Binario Bin = new Binario(Numero);

                Console.WriteLine(Bin);
            }
            catch(BinarioException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
