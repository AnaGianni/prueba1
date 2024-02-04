using System;
using System.Collections.Generic;
using System.Text;

namespace Pato4
{
    public class Pato
    {
        public int pico { get; set; }

        public string habitat { get; set; }

        public Pato()
        {

        }

        public void MostrarPato()
        {
            Console.WriteLine($"El pato tiene {pico} pico" +
                $" y su habitat es el {habitat}");
        }
    }
}
