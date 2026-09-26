using System;

namespace CS3
{
    
    class Program
    {

        static void Main(string[] args)
        {
            // sesion 6: operadores
            // declaración e incialización 
            double a = 1;
            double b = 2;
            double resultado = 0;
            //1.operdadores aritmeticos
            resultado = a + b;
            Console.WriteLine($"suma: {resultado}");
            //a) suma: +
            //b) resta: -
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            //c) multiplicación: *
            resultado = a * b;
            Console.WriteLine($"Multiplicacion: {resultado}");
            //d) división: /
            resultado = a / b;
            Console.WriteLine($"Division: {resultado}");
            //e) resto(módulo): %
            resultado = a % b;
            Console.WriteLine($"Residuio: {resultado}");
            //incrementos e incrementos
            // resultado= resultado + 9
            resultado += 9;
            Console.WriteLine($"Resultado: {resultado}");
            /*
           
            2. Operadoles comparativos
            a) igualdad: ==
            b) diferencia: !=
            c) mayor que: >
            d) menor que: <
            e) mayor o igual que: <=
            f) menor que o igual que: >=
            */
            // Sesion 7: operadores comparativos
            bool m = false;
            m = 4 == 10;
            Console.WriteLine($"Igualadad: {m}");
            m = 5 != 5;
            Console.WriteLine($"diferencia: {m}");
            m = 5 > 4;
            Console.WriteLine($"Mayor que: {m}");
            m = 5 < 4;
            Console.WriteLine($"Menor que: {m}");
            //3. Operadores logicos
            //a. Y (and): &&
            //b. O (OR): ||
            bool e = false; // entrada 1
            bool f = true; // entrada 2
            bool d = false; // entrada 3
            d = e && f;
            Console.WriteLine($"Y:{d}");
            d = e || f;
            Console.WriteLine($"0: {d}");


        }
    } 
} 
