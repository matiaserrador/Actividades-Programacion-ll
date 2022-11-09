using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListTablaHashSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region SortedList
            SortedList<string, string> diccionario = new SortedList<string, string>();
            diccionario.Add("hello", "hola");
            diccionario.Add("goodbye", "adios");
            diccionario.Add("how're", "como estas");
            diccionario.Add("you", "tu");
            diccionario.Add("im", "yo estoy");
            diccionario.Add("fine", "bien");
            diccionario.Add("and", "y");
            diccionario.Add("good", "bien");
            diccionario.Add("bad", "mal");
            diccionario.Add("why", "por que?");
            diccionario.Add("thanks", "gracias");
            diccionario.Add("for", "por");
            diccionario.Add("asking", "preguntar");
            diccionario.Add("had", "tuve");
            diccionario.Add("a", "un");
            diccionario.Add("day", "dia");

            string frase = Console.ReadLine();

            string[] subFrase = frase.Split(' ');

            foreach (string s in subFrase)
            {
                if (diccionario.ContainsKey(s))
                {
                    Console.Write(diccionario[s] + ' ');
                }
            }
            Console.WriteLine();

            #endregion

            #region HashTable
            Dictionary<string, string> diccionario1 = new Dictionary<string, string>();
            diccionario1.Add("hello", "hola");
            diccionario1.Add("goodbye", "adios");
            diccionario1.Add("how're", "como estas");
            diccionario1.Add("you", "tu");
            diccionario1.Add("im", "yo estoy");
            diccionario1.Add("fine", "bien");
            diccionario1.Add("and", "y");
            diccionario1.Add("good", "bien");
            diccionario1.Add("bad", "mal");
            diccionario1.Add("why", "por que?");
            diccionario1.Add("thanks", "gracias");
            diccionario1.Add("for", "por");
            diccionario1.Add("asking", "preguntar");
            diccionario1.Add("had", "tuve");
            diccionario1.Add("a", "un");
            diccionario1.Add("day", "dia");

            string frase1 = Console.ReadLine();

            string[] subFrase1 = frase.Split(' ');

            foreach (string s in subFrase1)
            {
                if (diccionario1.ContainsKey(s))
                {
                    Console.Write(diccionario1[s] + ' ');
                }
            }
            Console.WriteLine();

            #endregion

            #region HashSet/SortedSet
            SortedSet<string> SetPalabras3 = new SortedSet<string>();
            string palabraS = Console.ReadLine();

            while (palabraS != "")
            {
                if (SetPalabras3.Contains(palabraS))
                {
                    Console.WriteLine($"{palabraS} escribí otra palabra...");
                    palabraS = Console.ReadLine();
                }
                else
                {
                    SetPalabras3.Add(palabraS);
                    palabraS = Console.ReadLine();
                }
            }

            #endregion
        }
    }
}
