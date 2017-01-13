using System;

namespace IntegratieOpdrachtPolDeel3.Models
{
    public class Eigendom : IEigendom, IComparable
    {
        string eigenaar;
        double prijs;
        public string Eigenaar
        {
            get
            {
                return eigenaar;
            }
        }

        public double Prijs
        {
            get
            {
                return prijs;
            }
        }

        public Eigendom(string eigenaar, double prijs)
        {
            this.eigenaar = eigenaar;
            BepaalPrijs(prijs);
        }

        public void BepaalPrijs(double nieuwePrijs)
        {
            if (nieuwePrijs < 0)
            {
                prijs = 0;
            }
            else
            {
                prijs = nieuwePrijs;
            }
        }

        public void VerkoopAan(string nieuweNaam)
        {
            eigenaar = nieuweNaam;
        }

        public override string ToString()
        {
            return "Eigenaar: " + eigenaar + "\nPrijs: " + prijs;
        }

        public int CompareTo(object obj)
        {
            Eigendom teVergelijkenEigendom = obj as Eigendom;
            if (prijs > teVergelijkenEigendom.prijs)
            {
                return -1;
            }
            else if (prijs < teVergelijkenEigendom.prijs)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}