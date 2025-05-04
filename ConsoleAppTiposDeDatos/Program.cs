using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 1
            // Aquí estamos declarando varias variables con distintos tipos de datos
            int entero = 10;                  // Un número entero cualquiera
            double flotante = 20.5;           // Número decimal
            bool booleano = true;             // Valor verdadero o falso
            char caracter = 'C';              // Un solo carácter, entre comillas simples
            string texto = "Ejemplo";         // Una cadena de texto (string)

            // Mostramos el contenido de cada variable por consola
            Console.WriteLine($"Entero: {entero}");
            Console.WriteLine($"Flotante: {flotante}");
            Console.WriteLine($"Booleano: {booleano}");
            Console.WriteLine($"Caracter: {caracter}");
            Console.WriteLine($"Texto: {texto}");

            /////////////////////////////////////
            //EJERCICIO 2

            // Aquí estamos viendo cómo convertir entre tipos de datos
            double valorDouble = 12.78;         // Un número decimal
            int valorEntero = (int)valorDouble; // Lo convertimos a entero (pierde los decimales)

            string numeroTexto = "50";                         // Número guardado como texto
            int numeroEntero = Convert.ToInt32(numeroTexto);   // Convertimos ese texto a entero

            // Mostramos los resultados de las conversiones
            Console.WriteLine($"Valor entero (casting): {valorEntero}");
            Console.WriteLine($"Número convertido: {numeroEntero}");

            //////////////////////////
            //EJERCICIO 3

             // Estructura condicional: if - else

            int edad = 22; // Edad de una persona

            // Verificamos si es mayor de edad o no
            if (edad >= 18)
                Console.WriteLine("Es adulto");    // Si tiene 18 o más, es adulto
            else
                Console.WriteLine("Es menor");     // Si tiene menos de 18, es menor de edad


            ///////////////////////
            //EJERCICIO 4

             int opcion = 2; // Supongamos que el usuario eligió la opción 2

            // Evaluamos la opción usando switch
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Opción 1"); // Si elige 1, se muestra este mensaje
                    break;

                case 2:
                    Console.WriteLine("Opción 2"); // Si elige 2, mostramos este
                    break;

                default:
                    Console.WriteLine("Otra opción"); // Para cualquier otra opción diferente
                    break;
            }

            ////////////////////////////
            //EJERCICIO 5

            // Estructura de repetición: for
            // Este bucle se ejecuta 3 veces, desde i = 0 hasta i < 3
            for (int i = 0; i < 3; i++)
                Console.WriteLine($"Iteración {i}"); // Muestra el número de iteración

            ///////////////////////////
            // Estructura de repetición: while

            int contador = 0; // Iniciamos un contador en 0

            // Mientras el contador sea menor que 3, seguimos repitiendo
            while (contador < 3)
            {
                Console.WriteLine($"Contador: {contador}"); // Mostramos el valor actual del contador
                contador++; // Aumentamos el valor del contador en 1
            }
            */


            ////////////////////////
            
            //EJERCICIO 5
            // Estructura de repetición: do-while

            // Aquí el bucle se ejecuta al menos una vez, sin importar la condición inicial

            int contador = 0;
            do
            {
                Console.WriteLine($"Contador: {contador}"); // Mostramos el valor actual del contador
                contador++; // Incrementamos el contador
            } while (contador < 3); // Repetimos mientras el contador sea menor que 3

            // Esto es solo para que la consola no se cierre automáticamente al terminar
            Console.ReadKey(); // Espera a que el usuario presione una tecla
        }

    }
}
