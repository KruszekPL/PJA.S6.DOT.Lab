using System;

namespace Bank
{

    public class Konto
    {
        public Osoba Wlasciciel;
        private decimal saldo = 0;
        private int pin = 0;

        public Konto()
        {
        }

        public void DokonajWplaty(decimal kwota) {
            if (kwota < 0) {
                throw new ArgumentException(
                    "Wpłacana kwota nie może być mniejsza od zera!");
            }
            saldo += kwota;
        }

        public string DokonajWyplaty(decimal kwota, int pin) {
            if (!SprawdzPin(pin)) {
                return "Operacja anulowana";
            }
            saldo -= kwota;
            return "Operacja zakończona pomyślnie";
        }

        public bool ZmienPin(int nowy, int stary) {
            if (SprawdzPin(stary)) {
                pin = nowy;
                return true;
            }
            return false;
        }

        public string PobierzInformacje(int pin) {
            if (SprawdzPin(pin)) {
                return string.Format("Pan(i) {0} {1} posiada na koncie: {2}",
                                     Wlasciciel.Imie, Wlasciciel.Nazwisko, saldo);
            }
            return "Brak dostępu!";
        }

        private bool SprawdzPin(int pin) {
            if (this.pin == pin) {
                return true;
            } else {
                return false;
            }
        }
    }
}