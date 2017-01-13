namespace IntegratieOpdrachtPol.Models
{
    public class Aanhangwagen : ITrekbaar
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

        public Aanhangwagen() { }
        public Aanhangwagen(int aantalbanden, double gewicht)
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
            return "Aantal banden: " + AantalBanden + "\nGewicht: " + Gewicht;
        }
    }
}