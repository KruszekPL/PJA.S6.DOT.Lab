using System;

namespace Czolg {
    class Dzialo {
        private double kaliber;
        public Dzialo(double kaliber) {
            this.kaliber = kaliber;
        }

        public double PobierzKaliber() {
            return kaliber;
        }
        #region Zadanie 2
        public void ZmienKaliber(double nowyKaliber) {
            kaliber = nowyKaliber;
        }

        public Dzialo(Dzialo prototyp) {
            kaliber = prototyp.kaliber;
        }
        #endregion
    }
}