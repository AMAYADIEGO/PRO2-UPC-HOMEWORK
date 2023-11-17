public class ClaseArray
{
    public string[] ArrayCadenas;

    public ClaseArray()
    {
        ArrayCadenas = new string[0];
    }

    public ClaseArray(int cant)
    {
        ArrayCadenas = new string[cant];
    }

    public void MostrarArray()
    {
        string resp = "[";
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            resp += ArrayCadenas[i] + ", ";
        }
        Console.WriteLine(resp + "]");
    }

    public string BuscarElementoArrayCadenas(string elem)
    {
       for (int i = 0; i < ArrayCadenas.Length; i++)
       {
        if(ArrayCadenas[i] == elem)
        {
            return "TRUE";
        }
        }
        return "FALSE";
    }
        

      

    public int  FrecuenciaArrayCadenas(string elemento)
    {
        
        int frecuencia = 0;
        for (int i = 0; i < ArrayCadenas.Length; i++)
    {
        if (ArrayCadenas[i] == elemento)
        {
            frecuencia++;
        }
    }
        return frecuencia;
    }

    public void ComplementoArrayCadenasAyB(ClaseArray B)
    {
       B.DiferenciaArrayCadenasByA(this);
    }

    public void ArrayCadenasToArrayEnteros()
    {
        ClaseArray A1 = new ClaseArray();
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            int numero = i;
            char letra = (char)numero;
            Console.WriteLine(numero + ": " + letra);
        }
        A1.MostrarArray();
    }

    public void DiferenciaArrayCadenasAyB(ClaseArray B)
    {
        int indice = 0;
        ClaseArray C = new ClaseArray(ArrayCadenas.Length);
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            bool existe = false;
            string datoA = ArrayCadenas[i];
            for(int j = 0; j < B.ArrayCadenas.Length; j++)
            {
                if (datoA == B.ArrayCadenas[j])
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                C.ArrayCadenas[indice] = datoA;
                indice++;
            }
        }
        C.MostrarArray();
    }

    public void InvertirArrayCadenas()
    {
    
    List<string> result = new List<string>();

    for (int i = ArrayCadenas.Length - 1; i >= 0; i--)
    {
        string str = ArrayCadenas[i];
        result.Add(str);
    }

    Console.WriteLine(string.Join(", ", result));
    }
    public void DiferenciaArrayCadenasByA(ClaseArray A)
    {
        int indice = 0;
        ClaseArray C = new ClaseArray(ArrayCadenas.Length);
        for (int i = 0; i < ArrayCadenas.Length; i++)
        {
            bool existe = false;
            string datoB = ArrayCadenas[i];
            for(int j = 0; j < A.ArrayCadenas.Length; j++)
            {
                if (datoB == A.ArrayCadenas[j])
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                C.ArrayCadenas[indice] = datoB;
                indice++;
            }
        }
        C.MostrarArray();
    }

}

