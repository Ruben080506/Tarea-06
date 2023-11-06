using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           2) Un bucle genera números aleatorios entre -12 y 12.
           El bucle es controlado por una variable booleana.
           El bucle termina su ejecución cuando esta variable booleana es falsa.
           La variable booleana es falsa cuando el número aleatorio es negativo o cero.
           El bucle debe imprimir el número aleatorio generado y su equivalente en mes.
           Por ejemplo: 1 es enero, 2 es febrero, etc.
           El cero y los negativos se imprimen como fuera de rango.
           */

            Random random = new Random();
            bool ejecutar = false;
            string mes;

            Console.WriteLine("Presione una tecla para comenzar.");
            Console.ReadKey();

            while (!ejecutar)
            {
                int aleatorio = random.Next(-12, 12);

                if (aleatorio > 0 && aleatorio <= 12)
                {
                    mes = nombremes(aleatorio);
                    ejecutar = true;
                }
                else
                {
                    mes = "Fuera de rango";
                    ejecutar = true;
                }

                Console.WriteLine($"{aleatorio} es {mes}");
            }
        }

        static string nombremes(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return "Fuera de rango";
                }
            }
        }
}
