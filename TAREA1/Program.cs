namespace tarea1
{
    class program 
    {
    static void  Main(string[] args)
    {
        Console.WriteLine("hello world");
        int resp = CalcularAreaCuadrado(10);
        Console.WriteLine(resp);
    }

    static int CalcularAreaCuadrado(int L){
        int resultado = L*L;
        return resultado;
    }
    }
}