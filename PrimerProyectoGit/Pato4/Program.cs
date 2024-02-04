using System;

namespace Pato4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato1 = new Pato();

            pato1.pico = 1;
            pato1.habitat = "lago";
            pato1.MostrarPato();
           
            
            Console.ReadKey();
        }
    }
}
