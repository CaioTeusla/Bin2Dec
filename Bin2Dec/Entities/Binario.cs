using System;
using Bin2Dec.Entities.Exceptions;


namespace Bin2Dec
{
    class Binario
    {
        public int Bin { get; set; }
        private int Dec { get; set; }

        public Binario(int bin)
        {
            Bin = bin;
            Dec = Calc(Bin);
        }

        private int Calc(int Bin)
        {
            int i;
            Dec = 0;
            for(i = 0; Bin > 0.9; i++)
            {
                if(Bin % 10 > 1)
                {
                    throw new BinarioException("Esse não é um número binário");
                }
                if(i > 7)
                {
                    throw new BinarioException("Esse número apresenta mais de 8 dígitos");
                }
                Dec = (int)(Dec + Math.Pow(2, i) * (Bin % 10));
                Bin = Bin / 10;
            }
            return Dec;
        }

        public override string ToString()
        {
            return "O número binário " + Bin + " para decimal é: " + Dec;
        }
    }
}
