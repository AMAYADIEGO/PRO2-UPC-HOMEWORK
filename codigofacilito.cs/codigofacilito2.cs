using system; 

namespace Presentacion2
{
    class program   
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "hola mundo";
            bool bandera = false;
            Console.WriteLine("el valor de i es : {0}",i);
            Console.WriteLine("el valor de x es : {0:C}",x);
            Console.WriteLine("el valor de f es : {0:F2}",f);
            Console.WriteLine("el valor de d es : {0:F2}",d);
            Console.WriteLine("el valor de cadena es :" + cadena);
            Console.WriteLine("el valor de bandera es :" + bandera.ToString() );
            Console.WriteLine("el valor de x es : {0:C}",x);
            Console.WriteLine("el valor de fecha es :" + fecha.ToShortDateString());
            console.Readkey();    
            }
    }
}     