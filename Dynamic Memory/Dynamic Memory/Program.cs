using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dynamic_Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Frase;

            Queue<string> Frase2 = new Queue<string>();

            Console.WriteLine("Escribí acá");
            Frase = Console.ReadLine();

            while (Frase != "")
            {
                Frase2.Enqueue(Frase);
                Console.WriteLine("Escribí acá");
                Frase = Console.ReadLine();

            }
            while (Frase2.Count > 0)
            {
                Console.WriteLine(Frase2.Dequeue());
            }
        }

    }
}