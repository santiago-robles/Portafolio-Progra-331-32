using System;
using System.ComponentModel;
// Espacio de nombres
namespace CS1
{
    //clase principal
    class Program
    {
        //Funcion principal
        static void Main(string[] args)
        {
            //1. p<royecto en C#
            //2. tipo de dato identificador
            bool a;
            int número;
            //3 interpolacion
            // Combinacion de datos dentro una cadena
            a = true;
            número = 10;
            Console.WriteLine($"booleano{a}");
            Console.WriteLine($"Número{número}");
            //4 incrementos y decrementos
            int m = 0;
            int n = -1;
            m += 1;
            n -= 3;
            m -= 5;
            n += 9;
            //5 operador resto (Módulo)
            int residuo = 40 % 16;
            Console.WriteLine($"Residuo: {residuo}");
            // 6 Escribir una expresion que de como resultado -18
            int operacion = 0;
            operacion = ((30 + 8 - 2) / 2) * -1;
            Console.WriteLine($"Operacion:{operacion}");


        }// termino de la funcion principal
    } // termino de la clase principal
} // termino del espacio de nombres