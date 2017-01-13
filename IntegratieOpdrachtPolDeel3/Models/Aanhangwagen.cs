namespace IntegratieOpdrachtPolDeel3.Models
{
    public class Aanhangwagen : Eigendom, ITrekbaar, IBelaadbaar
    {
        int aantalbanden;
        double gewicht;
        double huidigeBelading;
        double maximumLaadGewicht;

        public int AantalBanden
        {
            get
            {
                return aantalbanden;
            }
        }

        public double Gewicht
        {
            get
            {
                return gewicht + huidigeBelading;
            }
        }

        public double HuidigeBelading
        {
            get
            {
                return huidigeBelading;
            }
        }

        public double MaximumLaadGewicht
        {
            get
            {
                return maximumLaadGewicht;
            }
        }

        public Aanhangwagen() : base("", 0) { }
        public Aanhangwagen(int aantalbanden, double gewicht, string eigenaar, double prijs, double huidigeBelading, double maximumLaadGewicht) : base(eigenaar, prijs)
        {
            if (aantalbanden < 2)
            {
                this.aantalbanden = 2;
            }
            else if (aantalbanden > int.MaxValue)
            {
                this.aantalbanden = int.MaxValue;
            }
            else
            {
                this.aantalbanden = aantalbanden;
            }

            if (gewicht < 0)
            {
                this.gewicht = 0;
            }
            else if (gewicht > double.MaxValue)
            {
                this.gewicht = double.MaxValue;
            }
            else
            {
                this.gewicht = gewicht;
            }

            if (huidigeBelading < 0)
            {
                this.huidigeBelading = 0;
            }
            else if (huidigeBelading > double.MaxValue)
            {
                this.huidigeBelading = double.MaxValue;
            }
            else
            {
                this.huidigeBelading = huidigeBelading;
            }

            if (maximumLaadGewicht < 0)
            {
                this.maximumLaadGewicht = 0;
            }
            else if (maximumLaadGewicht > double.MaxValue)
            {
                this.maximumLaadGewicht = double.MaxValue;
            }
            else
            {
                this.maximumLaadGewicht = maximumLaadGewicht;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nAantal banden: " + AantalBanden + "\nGewicht: " + Gewicht;
        }

        public void Laden(double gewicht)
        {
            huidigeBelading += gewicht;
            if (huidigeBelading > maximumLaadGewicht)
            {
                huidigeBelading = maximumLaadGewicht;
            }
        }
        public void Lossen(double gewicht)
        {
            huidigeBelading -= gewicht;
            if (huidigeBelading < 0)
            {
                huidigeBelading = 0;
            }
        }
    }
}