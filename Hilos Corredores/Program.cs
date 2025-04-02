using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos_Corredores
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("¡Carrera de hilos!");

            // Crear dos corredores
            Thread corredorA = new Thread(Correr);
            Thread corredorB = new Thread(Correr);

            corredorA.Start("Corredor A");
            corredorB.Start("Corredor B");

            corredorA.Join();
            corredorB.Join();

            Console.WriteLine("¡Carrera terminada!");
        }

        static void Correr(object nombre)
        {
            Random rnd = new Random();
            for (int pasos = 1; pasos <= 10; pasos++)
            {
                Console.WriteLine($"{nombre} avanzó a la posición: {pasos}");
                Thread.Sleep(rnd.Next(100, 500)); // Velocidad aleatoria
            }
            Console.WriteLine($"🏁 {nombre} terminó la carrera!");
        }
    }

}
