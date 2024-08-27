using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PolinomiosImp : PolinomiosAbs
    {
        public PolinomiosImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int anterior(int dir)
        {
            if (esCero())
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

        public override int coeficiente(int exponente)
        {
           if(exponente < 0 || exponente <= grado())
            {
                int dir = inicio;
                while(dir != -1)
                {
                    dir = posterior(dir);
                    int exponente_actual = int.Parse(m.obtener_dato(0, dir));
                    if (exponente_actual == exponente)
                    {
                        int coeficiente = int.Parse(m.obtener_dato(anterior(dir) , 0));
                        return coeficiente;
                    }

                    dir = posterior(dir);
                }
            }
            return 0;
        }

        public override int derivado()
        {
            throw new NotImplementedException();
        }

        public override bool esCero()
        {
            if (cantidad == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int grado()
        {
            if (esCero())
            {
                return -1;
            }
            int dir = inicio;
            dir = posterior(inicio);
            m.obtener_dato(dir, 0);
           int resultado = int.Parse(m.obtener_dato(dir, 0));
            return resultado;
        }

        

        public override string mostrar_polinomios()
        {
            int i = grado();
            string resultado = "";
            while (i > 0)
            {
                if (coeficiente(i) != 0 )
                {
                    resultado = resultado + coeficiente(i) + "X^" + i.ToString() + "+";
                }
                i--;
            }
            return resultado;
        }

        public override int numero_terminos()
        {
            throw new NotImplementedException();
        }

        public override int poner_termino(int coeficiente, int exponente)
        {
            if (exponente > grado())
            {
                int dir_coef = m.espacio_libre();
                m.new_espacio(1);
                m.poner_dato(dir_coef, 0, ToString());
                int dir_exp = m.espacio_libre();
            }
        }

        public override int posterior(int dir)
        {
            if (esCero())
            {
                return -1;
            }
            int actual = inicio;
            while (actual != dir)   
            {
                actual = m.MEM[actual].link;
            }
            return m.MEM[actual].link;
        }

        public override int suma(PolinomiosImp sumando)
        {
            throw new NotImplementedException();
        }

       
    }
}
