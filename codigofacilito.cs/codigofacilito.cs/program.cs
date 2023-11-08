using system; 

namespace Presentacion5
{
    class program   
    {
        static void Main(string[] args)
        {
           clsEmpleados empleado;
            empleado = new clsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "Diego Amaya";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado" + empleado.Nombre);
            Console.WriteLine("es :" + total.ToString("C"));
            Console.Readkey();
        }
    }
}     