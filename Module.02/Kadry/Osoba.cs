using System;

namespace Kadry
{
    class Osoba
    {
        private string nazwisko;
        private string imie;
        private int numerEwidencyjny;
        private Adres adresZamieszkania;

        public Osoba(int numerEwidencyjny, string imie, string nazwisko, int numerDomu, int? numerMieszkania, string nazwaUlicy, string kod, string miejscowosc)
        {
            this.numerEwidencyjny = numerEwidencyjny;
            this.imie = imie;
            this.nazwisko = nazwisko;
            adresZamieszkania = new Adres(numerDomu, numerMieszkania, nazwaUlicy, kod, miejscowosc);
        }

        public Osoba(int numerEwidencyjny, string imie, string nazwisko, Adres adres)
            : this(numerEwidencyjny, imie, nazwisko, adres.ZwrocNumerDomu(), adres.ZwrocNumerMieszkania(), adres.ZwrocNazweUlicy(),
            adres.ZwrocKod(), adres.ZwrocMiejscowosc())
        {
        }

        public Osoba(int numerEwidencyjny, string imie, int numerDomu)
            : this(numerEwidencyjny, imie, "Kowalski", numerDomu, null, "Aleje Jerozolimskie", "02-222", "Warszawa")
        {
        }
        public Osoba(Osoba osoba)
        {
            numerEwidencyjny = osoba.numerEwidencyjny;
            imie = osoba.imie;
            nazwisko = osoba.nazwisko;
            adresZamieszkania = new Adres(osoba.adresZamieszkania);            
        }

        public string ZwrocInnformacjeOsobowe()
        {
            return string.Format("Pan(i) {0} {1} o numerze ewidencyjnym {2} zamieszkały(a): {3}",
                imie, nazwisko, numerEwidencyjny, adresZamieszkania.ZwrocInformacjeAdresowe());
        }

        public Osoba Klonuj()
        {
            return (Osoba)this.MemberwiseClone();
        }
        public void ZmienDaneOsobowe()
        {
            Console.Write("Podaj imię: ");
            imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();
            do
            {
                Console.Write("Podaj numer ewidencyjny: ");
            }
            while(!int.TryParse(Console.ReadLine(), out numerEwidencyjny));
            adresZamieszkania.ZmienAderes();
        }
    }
}