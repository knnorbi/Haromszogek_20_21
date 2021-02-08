using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    class DHaromszog
    {
        double aOldal;
        double bOldal;
        double cOldal;
        
        public int SorSzama { get; set; }

        public double Kerulet
        {
            get
            {
                return a + b + c;
            }
        }

        public double Terulet
        {
            get
            {
                return (a + b) / 2;
            }
        }

        public DHaromszog(string sor, int sorSzam)
        {
            SorSzama = sorSzam;
            string[] adatok = sor.Split(' ');

            a = double.Parse(adatok[0]);
            b = double.Parse(adatok[1]);
            c = double.Parse(adatok[2]);

            if (!EllNovekvoSorrend)
            {
                throw new Exception("Az oldalak nincsenek novekvo sorrendben!");
            }

            if (!EllDerekszogu)
            {
                throw new Exception("A haromszog nem derekszogu!");
            }

            if (!EllMegszerkesztheto)
            {
                throw new Exception("A haromszoget nem lehet megszerkeszteni!");
            }

        }

        public double a
        {
            get { return aOldal; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A(z) ’a’ oldal nem lehet nulla vagy negatív!");
                }
                aOldal = value;
            }
        }

        public double b
        {
            get { return bOldal; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A(z) ’b’ oldal nem lehet nulla vagy negatív!");
                }
                bOldal = value;
            }
        }

        public double c
        {
            get { return cOldal; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A(z) ’c’ oldal nem lehet nulla vagy negatív!");
                }
                cOldal = value;
            }
        }

        bool EllDerekszogu
        {
            get
            {
                return Math.Pow(aOldal, 2) + Math.Pow(bOldal, 2) == Math.Pow(cOldal, 2);
            }
        }

        bool EllMegszerkesztheto
        {
            get
            {
                return aOldal + bOldal > cOldal;
            }
        }

        bool EllNovekvoSorrend
        {
            get
            {
                return aOldal <= bOldal && bOldal <= cOldal;
            }
        }
    }
}
