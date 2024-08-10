using System;
namespace Memoria
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            MemoriaImp memoria = new MemoriaImp();

            memoria.new_espacio(3);
             memoria.PonerDato(6, 15, 60);
            memoria.DeleteEspacio(0);    
            int disponible = memoria.EspacioDisponible();
            Console.WriteLine("Espacio disponible: " + disponible);
            int ocupado = memoria.EspacioOcupado();
            Console.WriteLine("Espacio ocupado: " + ocupado);
            bool direccion = memoria.DireccionLibre(6);
            Console.WriteLine("La direccion esta libre: " + direccion);
            int obtener = memoria.ObtenerDato(6, 0);
            Console.WriteLine("Dato obtenido: " + obtener);

            memoria.mostrar();
        }
    }


}   