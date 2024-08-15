using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoriaWords
{
    public class MemoriaImp : MemoriaAbs
    {
        public override void delete_dir(int dir)
        {
            int x = dir;
            MEM[x].link = libre;
            libre = dir;

        }
        public override int NewEspacio(int cantidad)
        {
            int dir = libre;
            int D = libre;
            int i = 1;
            while (i <= cantidad - 1)
            {
                D = MEM[D].link;
                i++;
            }
            libre = MEM[D].link;
            MEM[D].link = -1;
            return dir;
        }

        public override void DeleteEspacio(int dir)
        {
            int x = dir;
            while (MEM[x].link != -1)
            //while (MEN[x].link < - 1 || MEN[x].link > -1 )
            {
                x = MEM[x].link;
            }
            MEM[x].link = libre;
            libre = dir;
        }
        public override int EspacioDisponible()
        {
            int x = libre;
            int c = 0;
            while (x != -1)
            {
                c++;
                x = MEM[x].link;
            }
            return c;
        }

        public override int EspacioOcupado()
        {
            int c = MAX - EspacioDisponible();
            return c;
        }

        public override bool DireccionLibre(int dir)
        {
            int x = libre;
            bool c = false;
            while (x != -1 && c == false)
            {
                if (x == dir)
                {
                    c = true;
                }
                x = MEM[x].link;
            }
            return c;
        }

        public override void PonerDato(int dir, int lugar, string valor)
        {
            int z = dir;
            int i = 0;
            while (i < lugar - 1)
            {
                z = MEM[z].link;
                i++;
            }
            MEM[z].dato = valor;
        }
        public override string ObtenerDato(int dir, int lugar)
        {
            int z = dir;
            int i = 0;
            while (i < lugar - 1)
            {
                z = MEM[z].link;
                i++;
            }
            return MEM[z].dato;
        }

        public override void EspacioPalabra(string cadena)
        {
            int d = libre;
            for (int i = 0; i < cadena.Length; i++)
            {
                MEM[d].dato = cadena[i].ToString();
                d = MEM[d].link;
            }
            libre = MEM[d - 1].link;
            MEM[d - 1].link = -1;
        }

        public override void Vocales(string cadena)
        {
            int d = libre;
            for (int i = 0; i < cadena.Length; i++)
            {
                string vocales = "aeiouAEIOU";
                string letra = cadena[i].ToString();
                if (vocales.Contains(letra))
                {
                    MEM[d].dato = letra;
                    d = MEM[d].link;
                }
                /*
                string vocal = cadena[i].ToString();
                
                if (vocal == "a" || vocal == "e" || vocal == "i" || vocal == "o" || vocal == "u")
                {
                    MEM[d].dato = vocal;
                    d = MEM[d].link;
                }
                */
            }
            libre = MEM[d - 1].link;
            MEM[d - 1].link = -1;

        }

        public override void mostrar()
        {
            int dir = 0;

            Console.WriteLine("Dir\t| Dato\t| Link");
            Console.WriteLine("_________");

            foreach (NodoM elemento in MEM)
            {
                int link = elemento.link;
                string dato = elemento.dato;



                Console.WriteLine(" " + dir + "\t|" + dato + "\t|" + link);
                dir++;
            }
        }

        public override void modificarLink(int dir, int nuevoLink)
        {
            MEM[dir].link = nuevoLink;
        }

        public override int EspacioLibre()
        {
            return libre;
        }
    }
}