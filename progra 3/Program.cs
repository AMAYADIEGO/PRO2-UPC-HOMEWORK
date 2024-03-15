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
            string oracion = "hola como estas";
            int resultado = ContarPalabrasMasTresLetras(oracion);
            Console.WriteLine("El ultimo de palabras con mas de tres letras es:" + resultado);
            int[,] mat = LlenarMatrizSerpiente(4, 3);
            ImprimirMatriz(mat);
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

        static int[,] LlenarMatrizSerpiente(int filas, int columnas)
        {
        int[,] matriz = new int[filas, columnas]; // Crear una matrizvacía con las dimensiones especificadas
        int valor = 1;
        for (int fila = 0; fila < filas; fila++)
        {
        // Determinar la dirección de llenado de la fila (izquierdaa derecha o derecha a izquierda)
        bool derecha = fila % 2 == 0;
        // Llenar la fila en la dirección determinada
        if (derecha)
        {
        for (int columna = 0; columna < columnas; columna++)
        {
        matriz[fila, columna] = valor++;
        }
        }
        else
        {
        for (int columna = columnas - 1; columna >= 0; columna--)
        {
        matriz[fila, columna] = valor++;
        }
        }
        }
        return matriz;
        }

        static void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}