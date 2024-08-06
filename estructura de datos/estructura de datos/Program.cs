using System;

namespace estructura
{
    class Vectores
    {
        static void Main(string[] args)
        {
            int[] vect = { 1, 2, 3 };

            int variable = vect[1];

            int[] vect2 = new int[5];

            vect2[2] = 4;

            imprimirVector(vect2);
           
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
