using System;

// Przykład 2 - klasy i metody częściowe

namespace Example._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba m = new Osoba();
            Osoba k = new Osoba();

            m.Nazwisko = "Kowalski";
            m.Imie = "Jan";

            k.Imie = "Anna";
            k.Nazwisko = "Nowak";

            m.UstawRokUrodzenia(1985);
            k.UstawRokUrodzenia(1989);

            Console.WriteLine("k - {0}", k.PobierzInformacje());
            Console.WriteLine("m - {0}", m.PobierzInformacje());

            Console.ReadKey();

            //Osoba dziecko = new Osoba();
            //dziecko.UstawRokUrodzenia(DateTime.Now.Year - 16); // <- osoba niepełnoletnia

            m.Zapisz();
            m.Zapisz();
            Console.WriteLine("Ilość zapisów do pliku: {0}", m.PobierzIloscZapisow());
        }
    }
}
