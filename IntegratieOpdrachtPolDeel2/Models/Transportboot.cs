using System;

namespace IntegratieOpdrachtPolDeel2.Models
{
    public class Transportboot : Boot, IBelaadbaar
    {
        double huidigeBelading;
        double maximumLaadGewicht;
        bool gezonken;

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

        public Transportboot(double huidigeBelading, double maximumLaadGewicht, int maximumSnelheid, string merk, int snelheid, string eigenaar, double prijs) : base(maximumSnelheid, merk, snelheid, eigenaar, prijs)
        {
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
            Laden(huidigeBelading);
            gezonken = false;
        }

        public void Laden(double gewicht)
        {
            if (gezonken)
            {
                throw new InvalidOperationException("De boot is reeds gezonken. Deze functie kan niet worden uitgevoerd.");
            }
            if ((double.MaxValue - huidigeBelading) < gewicht)
            {
                huidigeBelading = double.MaxValue;
            }
            else
            {
                huidigeBelading += gewicht;
            }
            if (huidigeBelading > maximumLaadGewicht)
            {
                snelheid = 0;
                gezonken = true;
                throw new InvalidOperationException("Het maximum laad gewicht van de boot is overschreden. De boot is gezonken.");
            }
        }
        public void Lossen(double gewicht)
        {
            if (gezonken)
            {
                throw new InvalidOperationException("De boot is reeds gezonken. Deze functie kan niet worden uitgevoerd.");
            }
            huidigeBelading -= gewicht;
            if (huidigeBelading < 0)
            {
                huidigeBelading = 0;
            }
        }
        public override void Versnel(int versnelling)
        {
            if (gezonken)
            {
                throw new InvalidOperationException("De boot is reeds gezonken. Deze functie kan niet worden uitgevoerd.");
            }
            base.Versnel(versnelling);
        }
        public override void Vertraag(int vertraging)
        {
            if (gezonken)
            {
                throw new InvalidOperationException("De boot is reeds gezonken. Deze functie kan niet worden uitgevoerd.");
            }
            base.Vertraag(vertraging);
        }
        public override string ToString()
        {
            return base.ToString() + "\nHuidige belading: " + huidigeBelading + "\nMaximum laad gewicht: " + maximumLaadGewicht + "\nGezonken: " + gezonken;
        }
    }
}