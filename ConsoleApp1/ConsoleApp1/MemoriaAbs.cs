using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaWords
{
    public abstract class MemoriaAbs
    {
        protected const int MAX = 20;
        protected const int NULO = -1;

        public struct NodoM
        {
            public string dato;
            public int link;
            public int id;
        }

        public NodoM[] MEM = new NodoM[MAX];
        public int libre;

        public MemoriaAbs()
        {
            int i = 0;
            while (i < MEM.Length)
            {
                MEM[i].dato = "";
                MEM[i].id = i;
                MEM[i].link = i + 1;
                i++;
            }
            MEM[MAX - 1].link = -1;
            libre = 0;

        }

        public abstract void mostrar();
        public abstract int NewEspacio(int cantidad);
        public abstract void DeleteEspacio(int dir);
        public abstract int EspacioDisponible();
        public abstract int EspacioOcupado();
        public abstract bool DireccionLibre(int dir);
        public abstract void PonerDato(int dir, int lugar, string valor);
        public abstract string ObtenerDato(int dir, int lugar);
        public abstract void EspacioPalabra(string cadena);
        public abstract void Vocales(string cadena);
        public abstract void modificarLink(int dir, int nuevoLink);
        public abstract int EspacioLibre();
        public abstract void delete_dir(int dir);
    }
}