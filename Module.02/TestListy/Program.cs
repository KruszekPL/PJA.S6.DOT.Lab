using System;

namespace TestListy
{
    class Program
    {
        static void Main(string[] args)
        {
            List orygianal = new List();
            orygianal.AddToHead("Ania");
            orygianal.AddToHead("Agnieszka");
            orygianal.AddToHead("Wiktoria");
            orygianal.AddToHead("Kasia");

            List kopiaR = orygianal.KlonujRekurencyjnie();
            List kopiaI = orygianal.KlonujIteracyjnie();

            Console.WriteLine("Wypisujemy przed modyfikacjami: ");
            Console.WriteLine("\n***Oryginał: ");
            orygianal.PrintAll();
            Console.WriteLine("\n***Kopia R: ");
            kopiaR.PrintAll();
            Console.WriteLine("\n***Kopia I: ");
            kopiaI.PrintAll();
            
            Console.WriteLine("\nModyfikujemy:");
            Console.ReadKey();
            kopiaR.AddToHead("Zosia");
            kopiaR.AddToHead("Jola");
            kopiaI.DeleteFromHead();
            kopiaI.DeleteFromHead();
            
            Console.WriteLine("\n***Oryginał: ");
            orygianal.PrintAll();
            Console.WriteLine("\n***Kopia R: ");
            kopiaR.PrintAll();
            Console.WriteLine("\n***Kopia I: ");
            kopiaI.PrintAll();
            Console.ReadKey();
        }
    }
}