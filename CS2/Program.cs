using System;
// Espacio de nombres
namespace CS1
{
    //clase principal
    class Program
    {

        //Funcion principal
        static void Main(string[] args)
        {
            // Sesion 5 tipos de datos
            // saintaxis para declarar variables
            // tipo_de_dato identificadro_variable
            //1. entereo
            int a;
            //2. cadena de texto
            string s;
            //3.1 flotante (precisión sencilla)
            float f;
            //3.2 flotante (precisión doble)
            double d;
            //4. booleano (lógico)
            bool b;
            //inicializaciones
            a = 5;
            s = "exactas";
            f = 8.5F;
            d = 9.5D;
            b = true;
            // palabra reservada: identificador especial preferido para el compliador
            //interpolación: combinacion de datos dentro de una cadena
            //impresiones
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"Flotante(precisión sencilla): {f}");
            Console.WriteLine($"Flotante(precisión doble): {d}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"booleano: {b}");
        }// termino de la funcion principal
    } // termino de la clase principal
} // termino del espacio de nombres