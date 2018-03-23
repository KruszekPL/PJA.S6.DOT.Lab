﻿using System;

namespace Kadry
{
    class Adres
    {
        private string miejscowosc;
        private string kod;
        private string nazwaUlicy;
        private int numerDomu;
        private int? numerMieszkania;

        public Adres(int numerDomu, int? numerMieszkania, string nazwaUlicy, string kod, string miejscowosc)
        {
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
            this.nazwaUlicy = nazwaUlicy;
            this.kod = kod;
            this.miejscowosc = miejscowosc;
        }
        public Adres(int numerDomu, int? numerMieszkania, string nazwaUlicy)
            : this(numerDomu, numerMieszkania, nazwaUlicy, "02-222", "Warszawa")
        {
        }
        public Adres(int numerDomu, int? numerMieszkania)
            : this(numerDomu, numerMieszkania, "Aleje Jerozolimskie")
        {
        }
        public Adres(int numerDomu)
            : this(numerDomu, null)
        {
        }

        public Adres(Adres adres)
            : this(adres.numerDomu, adres.numerMieszkania, adres.nazwaUlicy, adres.kod, adres.miejscowosc)
        {
        }

        public string ZwrocInformacjeAdresowe()
        {
            return numerMieszkania != null ?
                string.Format("{0} {1} ul. {2} {3} m. {4}", kod, miejscowosc, nazwaUlicy, numerDomu, numerMieszkania) :
                string.Format("{0} {1} ul. {2} {3}", kod, miejscowosc, nazwaUlicy, numerDomu);
        }
        public string ZwrocMiejscowosc()
        {
            return miejscowosc;
        }
        public string ZwrocNazweUlicy()
        {
            return nazwaUlicy;
        }
        public string ZwrocKod()
        {
            return kod;
        }
        public int ZwrocNumerDomu()
        {
            return numerDomu;
        }
        public int? ZwrocNumerMieszkania()
        {
            return numerMieszkania;
        }
        public void ZmienAderes()
        {
            Console.Write("Podaj nazwę miejscowości: ");
            miejscowosc = Console.ReadLine();
            Console.Write("Podaj kod: ");
            kod = Console.ReadLine();
            Console.Write("Podaj nazwę ulicy: ");
            nazwaUlicy = Console.ReadLine();
            do
            {
                Console.Write("Podaj numer domu: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numerDomu));
            Console.Write("Czy jest numer mieszkania <t/n>: ");
            char c = Console.ReadKey().KeyChar;
            if (c == 't')
            {
                int i;
                Console.WriteLine();
                do
                {
                    Console.Write("Podaj numer mieszkania: ");
                }
                while (!int.TryParse(Console.ReadLine(), out i));
                numerMieszkania = i;
            }
            else
            {
                numerMieszkania = null;
            }
        }
    }
}