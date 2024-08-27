using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class PolinomiosAbs
    {
        protected int cantidad;
        protected int inicio;
        protected int final;
        protected MemoriaImp m;

        public PolinomiosAbs(MemoriaImp mem)
        {
            cantidad = 0;
            inicio = -1;
            final = -1;
            m = mem;

        }

        public abstract bool esCero();
        public abstract int grado();
        public abstract int coeficiente(int exponente);
        public abstract int poner_termino(int coeficiente, int exponente);
        public abstract int numero_terminos();
        public abstract string mostrar_polinomios();
        public abstract int suma(PolinomiosImp sumando);
        public abstract int anterior(int dir);
        public abstract int posterior(int dir);
        public abstract int derivado();
        


    }
   
}
