using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    public class MemoriaImp : MemoriaAbs
    {
        public override void mostrar()
        {
            int dir = 0;
            Console.WriteLine("dir\t| dato\t| link");
            Console.WriteLine("---------------------");

            foreach (NodoM elemento in MEM)
            {
                int dato = elemento.dato;
                int link = elemento.link;

                Console.WriteLine("" + dir + "\t|" + dato + "\t|" + link);
                dir++;
            }
        }
        public override int new_espacio(int cantidad)
        {
            int dir = libre;
            int D = libre;
            int i = 1;
            while (i <= cantidad -1 )
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
            //while (MEM[x].link < - 1 || MEM[x].link > -1 )
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
                c = c + 1;
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
            while (x != -1 && !c)
            {
                if (x == dir)
                {
                    c = true;
                }
                x = MEM[x].link;
            }
            return c;
        }

        public override void PonerDato(int dir, int lugar, int valor)
        {
            int z = dir;
            int i = 0;
            while (i >= lugar - 1)
            {
                z = MEM[z].link;
                i++;
            }
            MEM[z].dato = valor;
            libre = MEM[z].link;//
            MEM[z].link = -1;//
        }
        /*int dir = libre;
            int D = libre;
            int i = 1;
            while (i <= cantidad - 1)
            {
                D = MEN[D].link;
                i++;
            }
            libre = MEM[D].link;
            MEM[D].link = -1;
            return dir;
        */
        public override int ObtenerDato(int dir, int lugar)
        {
            int z = dir;
            while (z <= lugar - 1)
            {
                z = MEM[z].link;
                z++;
            }
            return MEM[z].dato;
        }

    }
}