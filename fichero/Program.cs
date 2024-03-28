using System;

namespace archivos
{
    class Archivos
    {
        static void Main (string[] args)
        {   

            //leerArchivo();
            //datosAlFinal();
            //guardarDatosCompletos();
            //creararchivo();
            //verificarParImpar();
            


        }

        static void creararchivo(){
            string ruta = "archivo_entrada1.txt";
            FileStream archivo2 = File.Create(ruta);
        }

        static void verificarParImpar()
    {
        string archivoEntrada = "archivo_entrada.txt";
        string archivoSalida = "archivo_salida.txt";

        try
        {
            using (StreamReader reader = new StreamReader(archivoEntrada))
            using (StreamWriter writer = File.AppendText(archivoSalida))
            {
                string linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    // Convertir la línea a un número entero
                    if (int.TryParse(linea, out int numero))
                    {
                        // Verificar si el número es par o impar
                        string paridad;
                        if(numero % 2 == 0){
                            paridad = "par";
                        }else{
                            paridad = "impar";
                        } 
                        string salida = "D=> " + linea + " ; R=> " + paridad + "";

                        // Escribir la salida en el archivo de salida
                        writer.WriteLine(salida);
                    }
                    else
                    {
                        Console.WriteLine($"Advertencia: No se pudo convertir '{linea}' a un número entero.");
                    }
                }
            }

            Console.WriteLine("Proceso completado. Se han agregado los resultados en el archivo de salida.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    
        static void guardarDatosCompletos()
    {
        string archivoEntrada = "archivo_entrada.txt";
        string archivoSalida = "archivo_salida.txt";

        try
        {
            using (StreamReader reader = new StreamReader(archivoEntrada))
            using (StreamWriter writer = File.AppendText(archivoSalida))
            {
                string linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    int contadorVocales = ContarVocales(linea);

                    // Formatear la salida según el formato requerido
                    string salida = "D=> " + linea + " ; R=> " + contadorVocales + "";

                    // Escribir la salida en el archivo de salida
                    writer.WriteLine(salida);
                }
            }

            Console.WriteLine("Proceso completado. Se ha creado el archivo de salida.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

         static int ContarVocales(string cadena)
    {
        int contador = 0;

        // Convertir la cadena a minúsculas para hacer el conteo de manera insensible a mayúsculas/minúsculas
        cadena = cadena.ToLower();

        // Contar las vocales (a, e, i, o, u) en la cadena
        foreach (char caracter in cadena)
        {
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contador++;
            }
        }

        return contador;
    }



        static void definirRuta()
        {
            // Definir la ruta del archivo en el bin autmaticamente
            string rutaArchivoMismo = @"diego.txt";

            // Definir la ruta del archivo
            string rutaArchivo = @"C:/Users/PC/Documents/fichero/diego.txt";


            FileStream archivo = null;
            //Declarar un objeto de tipo FileStream para el manejo del archivo
            archivo = File.Open(rutaArchivo, FileMode.OpenOrCreate);


            //Crear un nuevo archivo o sobrescribir el archivo existente
           FileStream archivo2 = File.Create(rutaArchivo);


            //Abrir el archivo para lectura y escritura
            FileStream archivo3 = File.Open(rutaArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        static void leerArchivo()
        {
            try
            {

                // Definir la ruta del archivo
                string rutaArchivo = @"diego.txt";

                // Abrir el archivo para lectura
                StreamReader reader = new StreamReader(rutaArchivo);
                string linea;

                // Leer y mostrar cada línea del archivo
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
        }

        static void datosAlInicio()
        {
            // Definir la ruta del archivo
            string rutaArchivo = @"C:/Users/PC/Documents/fichero/diego.txt";
            string contenidoOriginal;
            using (StreamReader reader = new StreamReader(rutaArchivo))
            {
                contenidoOriginal = reader.ReadToEnd();
            }

            // Escribir los nuevos datos al principio del contenido leído
            string nuevoContenido = "Nuevos datos al inicio del archivo.\n" + contenidoOriginal;

            // Escribir el contenido modificado de vuelta al archivo
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.Write(nuevoContenido);
            }
        }

        static void datosAlFinal()
        {
            // Definir la ruta del archivo
            string rutaArchivo = @"C:/Users/PC/Documents/fichero/diego.txt";

            StreamWriter writer = File.AppendText(rutaArchivo);

            // Escribir datos adicionales en el archivo
            writer.WriteLine("Nuevo dato agregado al final del archivo");
            Console.WriteLine("Datos agregados al final del archivo con éxito.");


            // Cerrar el archivo explícitamente
            writer.Close();


            // Borrar el archivo
            //File.Delete(rutaArchivo);
        }

        static void trycatch()
        {
            try
            {
                // Código que podría lanzar una excepción
                int resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("el numero es: " + resultado);
            }
            catch (Exception ex)
            {
                // Captura y manejo de la excepción
                Console.WriteLine("¡Se ha producido una excepción!");
                Console.WriteLine("Mensaje de la excepción: " + ex.Message);
            }
        }
    }

    public class ExcepcionPar : Exception
    {
        // Constructor que llama al constructor base con un mensaje personalizado
        public ExcepcionPar(string mensaje) : base(mensaje)
        {
        }
    }

    public class ExcepcionImpar : Exception
    {
        // Constructor que llama al constructor base con un mensaje predeterminado
        public ExcepcionImpar() : base("El numero ingresado es par")
        {
        }
    }

}