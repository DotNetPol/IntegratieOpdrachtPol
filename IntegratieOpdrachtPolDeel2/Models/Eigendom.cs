namespace IntegratieOpdrachtPolDeel2.Models
{
    public class Eigendom : IEigendom
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
            else if (nieuwePrijs > double.MaxValue)
            {
                this.prijs = double.MaxValue;
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
    }
}