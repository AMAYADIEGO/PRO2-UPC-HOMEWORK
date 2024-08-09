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
        public override void new_espacio(int cantidad)
        {
            int dir = libre;
            int D = libre;
            int i = 1;
            while (i < cantidad -1 )
            {
                D = MEM[D].link;
                libre = MEM[D].link;
                MEM[D].link = -1;
                
            }
            
        }
    }
}