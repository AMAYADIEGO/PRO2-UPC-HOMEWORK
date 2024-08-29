using System;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MemoriaImp memoria = new MemoriaImp();
            ConjuntoImp conjunto = new ConjuntoImp(memoria);

            conjunto.insertar("a");
            conjunto.insertar("b");
            conjunto.insertar("c");

            conjunto.suprimir("a");
            conjunto.insertar("d");
            conjunto.suprimir("c");
            conjunto.insertar("e");

            memoria.mostrar();


        }
    }
}