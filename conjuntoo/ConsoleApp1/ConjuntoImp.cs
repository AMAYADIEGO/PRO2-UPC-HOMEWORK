using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConjuntoImp : ConjuntoAbs
    {
        public ConjuntoImp(MemoriaImp mem) : base(mem) 
        {
        }

        public override int anterior(int dir)
        {
            if (vacio())
            {
                return -1;
            }

            if (dir == inicio)
            {
                return -1;
            }

            int actual = inicio;
            while (m.MEM[actual].link != dir)
            {
                actual = m.MEM[actual].link;
            }
            return actual;
        }

        public override int cardinal()
        {
            return cantidad;
        }

        public override void insertar(string elemento)
        {
            int libre = m.espacio_libre();
            m.new_espacio(1);
            m.poner_dato(libre, 0, elemento);
            if(vacio())
            {
                inicio = libre;
                final = libre;
                cantidad++;
            }
            else
            {
                m.modificar_link(final, libre);
                final = libre;
                cantidad++;
            }
        }

        public override string muestrea()
        {
            Random r = new Random();
            int aleatorio = r.Next(1, cantidad + 1);

            return m.obtener_dato(inicio, aleatorio);
        }

        public override int ordinal(string elemento)
        {
            int dir = inicio;
            int posicion = 0;
            while (dir != -1)
            {
                string dato_actual = m.obtener_dato(dir, 0);
                posicion++;
                if (dato_actual == elemento)
                {
                    return posicion;
                }
                dir = m.MEM[dir].link; posicion++;
            }
            return 0;           
        }

        public override bool pertenece(string elemento)
        {

            if(ordinal(elemento) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void suprimir(string elemento)
        {
            int dir = inicio;
            while(dir != -1)
            {
                if (m.obtener_dato(dir, 0) == elemento)
                {
                    if (dir == inicio)
                    {
                        inicio = m.MEM[dir].link;
                        m.delete_dir(dir);

                    }else if(dir == final)
                    {
                        final = anterior(dir);
                        m.modificar_link(final, -1);
                        m.delete_dir(dir);
                    }
                    else
                    {
                        m.modificar_link(anterior(dir), m.MEM[dir].link);
                        m.delete_dir(dir);
                    }
                    cantidad--;
                }
                dir = m.MEM[dir].link;
            }
        }

        public override bool vacio()
        {
            return cantidad == 0;
        }
    }
}
