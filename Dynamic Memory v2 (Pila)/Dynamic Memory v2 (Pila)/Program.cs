using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dynamic_Memory_v2__Pila_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Cola = estructura LIFO.
            Stack pilaDeNombres = new Stack();
            string INFORMACION;
            pilaDeNombres.Push("1 - Matias");
            pilaDeNombres.Push("2 - Rodrigo");
            pilaDeNombres.Push("3 - Errador");

            for (int i = 0; i < 3; i++)
            {
                Console.ReadKey();
                INFORMACION = (string)pilaDeNombres.Pop();
                Console.WriteLine(INFORMACION);
            }
            Console.ReadKey();
        }
    }
}
