using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaWords
{
    public class ListaImp : ListaAbs
    {
        public ListaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int anterior(int dir)
        {
            if (vacia())
            {
                return -1;
            }

            if (dir == primero())
            {
                return -1;
            }

            int actual = primero();
            while (m.MEM[actual].link != dir)
            {
                actual = m.MEM[actual].link;
            }
            return actual;

            //link == al elemento que estoy buscando.si la direccion tiene en el link la direccion que busco
        }
        /*
        public override void deleteDir(int dir)
        {
            int x = dir;
            m.MEM[x].link = libre;
            int libre = dir;
        }
        */
        public override int fin()
        {
            return final;
        }

        public override void insertar(int dir, string dato)
        {
            int libre = m.EspacioLibre();
            m.NewEspacio(1);
            m.PonerDato(libre, 0, dato);

            if (vacia())
            {
                inicio = libre;
                final = libre;
                longitud++;
            }

            else if (longitud == 1)
            {
                
                m.modificarLink(primero(), libre);
                final = libre;
                longitud++;
            }
            else if (dir == primero())
            {
                m.modificarLink(libre, posterior(primero()));
                m.modificarLink(primero(), libre);
                longitud++;
            }
            else
            {
                m.modificarLink(anterior(dir), libre);
                m.modificarLink(libre, dir);
                longitud++;
            }
        }

        public override void modificarDato(int pos, string dato)
        {
            m.PonerDato(primero(), pos, dato);

        }

        public override string mostrar_lista()
        {
            string ListaOrdena = "";
            int dir = primero();
            while (dir != -1)
            {
                ListaOrdena = ListaOrdena + ", " + m.MEM[dir].dato;
                dir = m.MEM[dir].link;
            }
            return ListaOrdena;
        }

        public override int posterior(int dir)
        {
            if (vacia())
            {
                return -1;
            }

            int actual = primero();
            while (actual != dir)
            {
                actual = m.MEM[actual].link;
            }
            return m.MEM[actual].link;
        }

        public override int primero()
        {
            return inicio;
        }

        public override int segundo()
        {
            return posterior(inicio); 
        }

        public override void suprimir(int dir)
        {
            if (vacia())
            {
                                                                                                
            }
            else if (dir == primero())
            {
                inicio = posterior(primero());
                m.delete_dir(dir);
                longitud--;

            }
            else if (dir == fin())
            {
                final = anterior(fin());
                m.modificarLink(final, -1);
                m.delete_dir(dir);
                longitud--;
            }
            else
            {
                m.modificarLink(anterior(dir), posterior(dir));
                m.delete_dir(dir);
            }
        }

        public override bool vacia()
        {
            if (longitud == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}