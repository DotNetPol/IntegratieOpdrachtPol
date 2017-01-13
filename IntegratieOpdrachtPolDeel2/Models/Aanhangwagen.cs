namespace IntegratieOpdrachtPolDeel2.Models
{
    public class Aanhangwagen : Eigendom, ITrekbaar
    {
        int aantalbanden;
        double gewicht;

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
                return gewicht;
            }
        }

        public Aanhangwagen() : base("", 0) { }
        public Aanhangwagen(int aantalbanden, double gewicht, string eigenaar, double prijs) : base(eigenaar, prijs)
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
        }

        public override string ToString()
        {
            return base.ToString() + "\nAantal banden: " + AantalBanden + "\nGewicht: " + Gewicht;
        }
    }
}