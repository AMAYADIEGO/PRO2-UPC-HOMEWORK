using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructura
{
    internal class NumeroI : Numeros
    {
        public override bool esPrimo(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public override int mayor(int num1, int num2)
        {
           if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public override int suma(int num1, int num2)
        {
            int suma = num1 + num2;
            return suma;
        }
    }
}
