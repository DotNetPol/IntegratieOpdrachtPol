using System;

namespace IntegratieOpdrachtPolDeel3.Models
{
    public class Auto : Eigendom, IVoertuig, ITrekker
    {
        ITrekbaar aanhangwagen;
        double maximaalTrekGewicht;
        int maximumSnelheid;
        string merk;
        int snelheid;
        public ITrekbaar Aanhangwagen
        {
            get
            {
                return aanhangwagen;
            }
        }

        public double MaximaalTrekGewicht
        {
            get
            {
                return maximaalTrekGewicht;
            }
        }

        public int MaximumSnelheid
        {
            get
            {
                return maximumSnelheid;
            }
        }

        public string Merk
        {
            get
            {
                return merk;
            }
        }

        public int Snelheid
        {
            get
            {
                return snelheid;
            }
        }

        public Auto(double maximaalTrekGewicht, int maximumSnelheid, string merk, int snelheid, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            aanhangwagen = new Aanhangwagen();
            if (maximaalTrekGewicht < 0)
            {
                maximaalTrekGewicht = 0;
            }
            else if (maximaalTrekGewicht > double.MaxValue)
            {
                this.maximaalTrekGewicht = double.MaxValue;
            }
            else
            {
                this.maximaalTrekGewicht = maximaalTrekGewicht;
            }

            if (maximumSnelheid < 0)
            {
                this.maximumSnelheid = 0;
            }
            else if (maximumSnelheid > int.MaxValue)
            {
                this.maximumSnelheid = int.MaxValue;
            }
            else
            {
                this.maximumSnelheid = maximumSnelheid;
            }

            this.merk = merk;
            if (snelheid < 0)
            {
                this.snelheid = 0;
            }
            else if (snelheid > int.MaxValue)
            {
                snelheid = int.MaxValue;
            }
            else
            {
                this.snelheid = snelheid;
            }
        }

        public void KoppelAanhangwagen(ITrekbaar aanhangwagen)
        {
            if (snelheid > 0)
            {
                throw new KoppelException("Er kan geen aanhangwagen gekoppeld worden terwijl de auto rijdt!", snelheid);
            }
            else if (aanhangwagen.Gewicht > maximaalTrekGewicht)
            {
                throw new ArgumentException("Het gewicht van de aanhangwagen is te zwaar.");
            }
            else
            {
                this.aanhangwagen = aanhangwagen;
            }
        }

        public void Versnel(int versnelling)
        {
            if (aanhangwagen.Gewicht > maximaalTrekGewicht)
            {
                throw new OverBeladenException("De aanhangwagen is te zwaar. De auto kan niet sneller rijden.", maximaalTrekGewicht, aanhangwagen.Gewicht);
            }
            snelheid += versnelling;
            if (snelheid > maximumSnelheid)
            {
                snelheid = maximumSnelheid;
            }
        }
        public void Vertraag(int vertraging)
        {
            snelheid -= vertraging;
            if (snelheid < 0)
            {
                snelheid = 0;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + aanhangwagen.ToString() + "\nMaximaal trek gewicht: " + maximaalTrekGewicht + "\nMaximum snelheid: " + maximumSnelheid + "\nMerk: " + merk + "\nSnelheid: " + snelheid;
        }
    }
}