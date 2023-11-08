using system; 

namespace Presentacion5
{
   public class clsEmpleados   
    {
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }
        public string Nombre;
        public decimal SueldoDiario;
        public int Edad;

        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias
        }
    }
}     