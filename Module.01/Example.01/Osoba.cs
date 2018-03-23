using System;

// Przykład 1 - tworzenie klasy

namespace Example
{
    public class Osoba
    {
        public string Imie;
        public string Nazwisko;
        private int rokUrodzenia;

        public Osoba()
        {
        }

        public void UstawRokUrodzenia(int rokUrodzenia) {
            if ((DateTime.Now.Year - rokUrodzenia) < 18) {
                throw new ArgumentException("Osoba musi być pełnoletnia!");
            }
            this.rokUrodzenia = rokUrodzenia;
        }

        public string PobierzInformacje() {
            string tytul = "";
            if (Imie != null) {
                if (czyKobieta()) {
                    tytul = "Pani";
                } else {
                    tytul = "Pan";
                }
            }
            return string.Format("{0} {1} {2} ur. w {3} roku.",
                                 tytul, Imie, Nazwisko, rokUrodzenia);
        }

        private bool czyKobieta() {
            if (Imie.EndsWith("a")) {
                return true;
            }
            return false;
        }
    }
}
