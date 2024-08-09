using System;
namespace Memoria
{
    public abstract class MemoriaAbs
    {
        protected const int MAX = 20;
        protected const int NULO = -1;

        protected struct NodoM
        {
            public int dato;
            public int link;
        }
        protected NodoM[] MEM = new NodoM[MAX];
        protected int libre;

        public MemoriaAbs()
        {
            int i = 0;
            while (i < MEM.Length)
            {
              MEM[i].link = i + 1;

                i++;
            }
            MEM[MAX - 1].link = -1;
            libre = 0;
        }

        public abstract void mostrar();
        public abstract void new_espacio(int cantidad);
    }
}