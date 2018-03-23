using System;

// Przykład 2 - klasy i metody częściowe

namespace Example._02
{
    partial class Osoba
    {
        public string Imie;
        public string Nazwisko;
        private int rokUrodzenia;
        private int iloscZapisow = 0;

        public Osoba()
        {
        }

        public void UstawRokUrodzenia(int rokUrodzenia)
        {
            if ((DateTime.Now.Year - rokUrodzenia) < 18)
            {
                throw new ArgumentException("Osoba musi być pełnoletnia!");
            }
            this.rokUrodzenia = rokUrodzenia;
        }

        public string PobierzInformacje()
        {
            string tytul = "";
            if (Imie != null)
            {
                if (czyKobieta())
                {
                    tytul = "Pani";
                }
                else
                {
                    tytul = "Pan";
                }
            }
            return string.Format("{0} {1} {2} ur. w {3} roku.",
                                 tytul, Imie, Nazwisko, rokUrodzenia);
        }

        public int PobierzIloscZapisow() {
            return iloscZapisow;
        }

        public void Zapisz() {
            zapisz(++iloscZapisow);
        }

        partial void zapisz(int licznik);

        private bool czyKobieta()
        {
            if (Imie.EndsWith("a"))
            {
                return true;
            }
            return false;
        }
    }
}
