using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaWords
{
    public abstract class ListaAbs
    {
        protected int longitud;
        protected MemoriaImp m;
        protected int inicio;
        protected int final;


        public ListaAbs(MemoriaImp mem)
        {
            longitud = 0;
            inicio = -1;
            final = -1;
            m = mem;
        }

        public abstract bool vacia();//devuele true si la lista esta vacia
        public abstract int primero();//devuelve la direccion del primer elemento
        public abstract int fin();//devuelve la direccion del ultimo
        public abstract int anterior(int dir);//devuelve la direccion del elemento anterior del enviado
        public abstract void insertar(int dir, string dato);// inserta un nuevo elemento en la direccion
        public abstract void suprimir(int dir);// elimina el elemento de la direccion
        public abstract void modificarDato(int pos, string dato);// modifica el "lug" dato de la lista
        public abstract int posterior(int dir);// 
        public abstract string mostrar_lista();
        public abstract int segundo();

    }
}