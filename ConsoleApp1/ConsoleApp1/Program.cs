
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            MemoriaImp memoria = new MemoriaImp();
            ListaImp lista1 = new ListaImp(memoria);
            ListaImp lista2 = new ListaImp(memoria);

            lista1.insertar(0,"a");
            lista1.insertar(1,"b");
            lista1.insertar(0,"c");
            lista2.insertar(3, "1");
            lista2.insertar(3, "2");
            lista2.insertar(3, "3");
            memoria.NewEspacio(3);
            memoria.EspacioPalabra("diego");
            lista1.suprimir(0);
            lista2.suprimir(4);
            lista1.insertar(1, "d");
            lista1.insertar(1, "e");
            lista1.insertar(1, "f");

            Console.WriteLine(lista1.segundo());
            Console.WriteLine(lista1.mostrar_lista());






            /*ListaImp lista = new ListaImp(memoria);
            lista.insertar(0, "hola");
            lista.insertar(0, "mundo");
            lista.insertar(0, "erick");
            lista.insertar(2, "casa");
            lista.modificarDato(3, "eri2");*/

            //lista.suprimir();

            // memoria.espacio_palabra("erick");           
            //memoria.mostrar();
            /*Console.WriteLine("libre: " + memoria.EspacioLibre());
            Console.WriteLine("primer elemento: " + lista.primero());
            Console.WriteLine("ultimo elemento: " + lista.fin());
            Console.WriteLine("lista: " + lista.mostrar_lista());*/

            /*
            memoria.EspacioPalabra("viviana");
            memoria.mostrar();
            int res = lista.posterio(2);
            Console.WriteLine("el siguiente de 2 es: " + res);
            */

            /*
            memoria.NewEspacio(3);
            memoria.NewEspacio(6);

            memoria.PonerDato(3, 2, "hola");

            //memoria.DeleteEspacio(0);

            int disponible = memoria.EspacioDisponible();
            Console.WriteLine("Espacio disponible: " + disponible);

            int ocupado = memoria.EspacioOcupado();
            Console.WriteLine("Espacio ocupado: " + ocupado);

            bool direccion = memoria.DireccionLibre(3);
            Console.WriteLine("La direccion esta libre: " + direccion);

            string obtener = memoria.ObtenerDato(4, 2);
            Console.WriteLine("Dato obtenido: " + obtener);
            */

            memoria.mostrar();
        }
    }
}