using system; 

namespace Presentacion3
{
    class program   
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = "12344";
            DateTime fecha = DateTime.MinValue;
            i = convert.ToInt32(cadena);
            Console.WriteLine("el valor de i es : {0}",i);
            Console.WriteLine("el valor de x es : {0:C}",x);
            Console.WriteLine("el valor de bandera:" + bandera.ToString() );
            Console.WriteLine("el valor de cadena es :" + cadena);
            Console.WriteLine("el valor de fecha :" + fecha.ToShortDateString());
            console.Readkey();
        }
    }
}     