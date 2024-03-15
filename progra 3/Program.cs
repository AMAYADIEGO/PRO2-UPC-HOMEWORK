using Microsoft.Win32.SafeHandles;

namespace avance{
    public class progra3
    {
        public static void Main(string[] args)
        {
            int numero = 12345;
            int nuevoNumero = RotarDigito(numero);
            Console.WriteLine(nuevoNumero);
            int[] num = {1, 2, 3, 4, 5, 6,};
            Console.WriteLine(SumarElementosVector(num));
            
        }

        static int RotarDigito(int numero)
        {       // Convertimos el número a una cadena para manipular sus dígitos
        string numeroString = numero.ToString();
        // Tomamos el último dígito y lo movemos a la primera posición
        char ultimoDigito = numeroString[numeroString.Length - 1];
        string nuevoNumeroString = ultimoDigito + numeroString.Substring(0, numeroString.Length - 1);// Convertimos la cadena resultante de nuevo a un número
        int nuevoNumero = int.Parse(nuevoNumeroString);
        return nuevoNumero;
        }

        static int ContarPalabrasMasTresLetras(string oracion)
        {
        // Dividir la oración en palabras utilizando los espacios como delimitadores
        string[] palabras = oracion.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
        int contador = 0;
        // Contar las palabras que tienen más de tres letras
        foreach (string palabra in palabras)
        {
        if (palabra.Length > 3)
        {
        contador++;
        }
        }
            return contador;
        }

        static int SumarElementosVector(int[] vector)
        {
        int suma = 0;
       foreach (int elemento in vector)
        {
        suma += elemento; // Acumulamos la suma de cada elemento delvector
        }
        return suma;
        }


        static void imprimirVector<T>(T[] vector)
        {
            foreach (T elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

    }
}