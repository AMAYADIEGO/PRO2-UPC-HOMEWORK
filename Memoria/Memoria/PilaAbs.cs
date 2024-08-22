using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public abstract class PilaAbs
    {

        protected int longitud;
        protected int inicio;
        protected int final;
        protected MemoriaImp m;

        public PilaAbs(MemoriaImp mem)
        {
            longitud = 0;
            inicio = -1;
            final = -1;
            m = mem;

        }

        public abstract bool vacia();
        public abstract string cima();
        public abstract void meter(string elemento);
        public abstract string sacar();
        public abstract string mostrar_pila();
        public abstract int anterior(int dir);
    }
}
