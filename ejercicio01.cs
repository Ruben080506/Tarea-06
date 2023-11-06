using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Genere un número aleatorio entre 1 y 7.A continuación, 
imprima ese número con su equivalente nombre de día de la semana.
Ejemplo 1 es Lunes, 2 es Martes, etc.
*/
            int aleatorio;
            var seed = Environment.TickCount; //creamos una semilla
            Random rnd = new Random(seed); //genera el aleatorio
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey(); //usamos esta opcion para hacer una pausa hatsa que el usuario preciona una tecla y el codigo continue

            aleatorio = rnd.Next(1, 7); //generamos el numero aleatorio

            Console.WriteLine("su numero es. {0}", aleatorio); //imprimimos el numero que se genero aleatoriamente para llevar un control

            switch (aleatorio) //usamos switch por que es el condicional que mas no puede ayudar en este caso
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        }
    }
}
        

