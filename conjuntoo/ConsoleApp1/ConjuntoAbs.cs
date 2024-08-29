using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class ConjuntoAbs
    {
        protected int cantidad;
        protected int inicio;
        protected int final;
        protected  MemoriaImp m;

    
    public ConjuntoAbs(MemoriaImp mem)
    {
        cantidad = 0;
        inicio = -1;
        final = -1;
        m = mem;
    }

    public abstract bool vacio();
    public abstract int cardinal();
    public abstract int ordinal(string elemento);
    public abstract void insertar(string elemento);
    public abstract void  suprimir(string elemento);
    public abstract bool pertenece(string elemento);
    public abstract string muestrea();
    public abstract int anterior(int  dir);

    }
}

