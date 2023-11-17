namespace Program
{
    public class Program
    {
       public static void Main(string[] args)
        {
            ArrayEnt A = new ArrayEnt(4);
            A.ArrayEnteros[0] = 3;
            A.ArrayEnteros[1] = 3;
            A.ArrayEnteros[2] = 2;
            A.ArrayEnteros[3] = 4;
            A.MostrarArray();
            Console.WriteLine("-------------------");
            ArrayEnt B = new ArrayEnt(3);
            B.ArrayEnteros[0] = 7;
            B.ArrayEnteros[1] = 1;
            B.ArrayEnteros[2] = 3;
            B.MostrarArray();

            A.MostraMaxMinArrayEnteros();
            Console.WriteLine("-------------------");

            Console.WriteLine("Mostrar la suma de los arrays: ");
            int sum = A.SumaArrayEnteros();
            Console.WriteLine(sum);
            Console.WriteLine("-------------------");  

            Console.WriteLine("Mostrar el promedio de array enteros: ");
            int prom = A.PromedioArrayEnteros();
            Console.WriteLine(prom);
            Console.WriteLine("-------------------");

            Console.WriteLine("Mostrar la frecuencia de un array: ");
            int frec = A.FrecuenciaArrayEnteros(num: 3);
            Console.WriteLine(frec);
            Console.WriteLine("-------------------");

        
            
            Console.WriteLine("Array Cadena:");
            ClaseArray A1 = new ClaseArray(5);
            A1.ArrayCadenas[0] = "juan";
            A1.ArrayCadenas[1] = "pedro";
            A1.ArrayCadenas[2] = "diego";
            A1.ArrayCadenas[3] = "juan";
            A1.ArrayCadenas[4] = "rufus";
            A1.MostrarArray();
            ClaseArray B1 = new ClaseArray(5);
            B1.ArrayCadenas[0] = "diego";
            B1.ArrayCadenas[1] = "jose";
            B1.ArrayCadenas[2] = "alan";
            B1.ArrayCadenas[3] = "rober";
            B1.ArrayCadenas[4] = "juan";
            B1.MostrarArray();

            Console.WriteLine("buscar el elemento en el array si existe TRUE:");
            string tru = A1.BuscarElementoArrayCadenas(elem: "diego");
            Console.WriteLine(tru);
            Console.WriteLine("-------------------");

            Console.WriteLine("la frecuencia del nombre juan es: ");
            int frecu =  A1.FrecuenciaArrayCadenas(elemento:"juan");
            Console.WriteLine(frecu);
            Console.WriteLine("-------------------");

            Console.WriteLine("retornar el complemento del array A y B");
            A1.ComplementoArrayCadenasAyB(B1);
            Console.WriteLine("-------------------");

           // A1.ArrayCadenasToArrayEnteros();

            Console.WriteLine("Diferencia de Array A - B: ");
            A1.DiferenciaArrayCadenasAyB(B1);
            Console.WriteLine("-------------------");

            Console.WriteLine("inverir los valores de la Array: ");
            A1.InvertirArrayCadenas();
            Console.WriteLine("-------------------");

            Console.WriteLine("Diferencia de Array B - A: ");
            B1.DiferenciaArrayCadenasAyB(A1);
        }

    }
}
