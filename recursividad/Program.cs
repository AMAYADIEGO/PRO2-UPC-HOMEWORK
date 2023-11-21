namespace Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(suma(5));
            Console.ReadLine();
        }
    
        public static int suma(int n)
        {
            if(n == 1)
            {
                return n;
            }
            else
            {
                return n + suma (n - 1);
            }
        }
    }
}
