using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
                /*
                3) Genere 2 números aleatorios entre 1 y 6.
                Si la suma de los números generados es menor que 5 o si suman 11,
                se imprime un mensaje "Ganaste el premio sorpresa de la trivia",
                en caso contrario se imprime "Sigue intentando!!!".
                */

                int aleatorio1, aleatorio2;

                Random rnd = new Random(); //genera el aleatorio
                Console.WriteLine("Presione una tecla para Empezar.");
                Console.ReadKey(); //usamos esta opcion para hacer una pausa hatsa que el usuario preciona una tecla y el codigo continue

                aleatorio1 = rnd.Next(1, 6); //generamos el numero aleatorio
                aleatorio2 = rnd.Next(1, 6); //generamos el numero aleatorio

                if (aleatorio1 + aleatorio2 == 5 || aleatorio1 + aleatorio2 == 11)
                {
                    Console.WriteLine($"Tu primer numero fue. {aleatorio1}, tu segundo numero fue. {aleatorio2}, la suma es = {aleatorio1 + aleatorio2}. FELICIDADES HAS GANADO EL JUEGO");
                }
                else
                {
                    Console.WriteLine($"Tu primer numero fue. {aleatorio1}, tu segundo numero fue. {aleatorio2}, la suma es = {aleatorio1 + aleatorio2}. LO SIENTO SIGUE INTENTANDO!!!");
                
            }
        }
    }
}
    
