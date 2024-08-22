using System;
namespace Memoria
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            MemoriaImp memoria = new MemoriaImp();
            ListaImp lista = new ListaImp(memoria);
            PilaImp pila = new PilaImp(memoria);
            ColaImp cola = new ColaImp(memoria);

            int teclado = 0;
            while (teclado != -1)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("--------------MONEDERO-------------");
                Console.WriteLine("1.- Ingresar dinero");
                Console.WriteLine("2.- Sacar cambio");
                Console.WriteLine("3.- Verificar ganancia");
                Console.WriteLine("4.- Mostrar memoria");
                Console.WriteLine("-----------------------------------");
                teclado = int.Parse(Console.ReadLine()); //el 'Console.ReadLine' siempre devuelve un string y el 'int.Parse' lo convierte en int(numero entero)

                if (teclado == 1)
                {
                    Console.WriteLine("Ingrese la moneda");
                    string moneda = Console.ReadLine();
                    pila.meter(moneda);
                }
                else if (teclado == 2)
                {
                    PilaImp aux = new PilaImp(memoria);
                    int ordenado = 0;
                    int contador = 0;

                    while (!pila.vacia())
                    {
                        contador++;
                        string dato = pila.sacar();
                        aux.meter(dato);
                        ordenado = (ordenado + int.Parse(dato));
                    }
                    ordenado = ordenado / contador;
                    while (!aux.vacia())
                    {
                        string dato = aux.sacar();
                        pila.meter(dato);
                    }
                    Console.WriteLine("El cambio es: " + pila.sacar());

                }
                else if (teclado == 3)
                {
                    Console.WriteLine("Lista de pacientes es: " + pila.mostrar_pila());
                }
                else if (teclado == 4)
                {
                    PilaImp aux = new PilaImp(memoria);
                    int ordenado = 0;
                    int contador = 0;

                    while (!pila.vacia())
                    {
                        contador++;
                        string dato = pila.sacar();
                        aux.meter(dato);
                        ordenado = (ordenado + int.Parse(dato));
                    }
                    ordenado = ordenado / contador;
                    while (!aux.vacia())
                    {
                        string dato = aux.sacar();
                        pila.meter(dato);
                    }
                    Console.WriteLine("El promedio de la edad de la cola es: " + ordenado);
                }





                /* cola.poner("1");
                 cola.poner("2");
                 cola.poner("3");

                 Console.WriteLine("mostrar: " + cola.sacar());
                 memoria.mostrar();

                 Console.WriteLine("libre: " + memoria.espacio_libre() + "inicio: " + cola.inicio + " final: " + cola.final);*/




                //PILA------------------------

                //pila.meter("hola");
                //pila.meter("2");
                //pila.meter("3");
                //pila.meter("4");


                //Console.WriteLine("mostrar: " + pila.sacar());
                //memoria.mostrar();
                //Console.WriteLine("mostrar: " + pila.cima());
                //Console.WriteLine("libre: " + memoria.espacio_libre());




                /////lista------------------------
                //lista.insertar(0, "hola");
                //lista.insertar(0, "mundo");
                //lista.insertar(0, "erick");
                //lista.insertar(2, "casa");
                //lista.modificarDato(3, "eri2");

                //lista.suprimir(2);

                //// memoria.espacio_palabra("erick");           
                //memoria.mostrar();

                //Console.WriteLine("primer elemento: " + lista.primero());
                //Console.WriteLine("ultimo elemento: " + lista.fin());
                //Console.WriteLine("lista: " + lista.mostrar_lista());


                //memoria.mostrar();
                //memoria.espacio_palabra("er");
                //memoria.new_espacio(2);
                //memoria.mostrar();
                //lista.insertar(4, "rene");
                //memoria.mostrar();





                //memoria.delete_espacio(0);           

                //memoria.mostrar();
                //int resp = memoria.espacio_disponible();
                //Console.WriteLine("espacio libre " + resp);
                //resp = memoria.espacio_ocupado();
                //Console.WriteLine("espacio ocupado " + resp);

                //bool resp2 = memoria.dir_libre(2);
                //Console.WriteLine("espacio libre? " + resp2);

            }

        }
    }
}

