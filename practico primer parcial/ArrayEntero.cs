public class ArrayEnt
{
    //Propiedades
    public int[] ArrayEnteros;

    public int N;

    //Constructor
    public ArrayEnt()
    {
        ArrayEnteros = new int[0];
    }

    public ArrayEnt(int cantidad)
    {
        ArrayEnteros = new int[cantidad];
    }

    

    //Metodos (Procedimientos/Funciones)
    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            resp += ArrayEnteros[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public void MostraMaxMinArrayEnteros()
    {
        int max = ArrayEnteros[0];
        int min = ArrayEnteros[0];

        for (int i = 1; i < ArrayEnteros.Length; i++)
        {
            if (ArrayEnteros[i] > max)
            {
                max = ArrayEnteros[i];
            }

            if (ArrayEnteros[i] < min)
            {
                min = ArrayEnteros[i];
            }
        }

        Console.WriteLine("El máximo es: " + max);
        Console.WriteLine("El mínimo es: " + min);
    }

    public int SumaArrayEnteros()
    {
        int suma = 0;
        int n = ArrayEnteros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            suma = suma + ArrayEnteros[i];
        }
        return suma;
    }

    public int PromedioArrayEnteros()
    {
        int sum = 0;
        for (int i = 0; i < ArrayEnteros.Length; i++)
        {
            sum += ArrayEnteros[i];
        }
        return sum / ArrayEnteros.Length;
    }

    public int  FrecuenciaArrayEnteros(int num)
    {
        int frecuencia = 0;
        for (int i = 0; i < ArrayEnteros.Length; i++)
    {
        if (ArrayEnteros[i] == num)
        {
            frecuencia++;
        }
    }
        return frecuencia;
    }

    
}