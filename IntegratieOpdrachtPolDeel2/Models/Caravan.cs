namespace IntegratieOpdrachtPolDeel2.Models
{
    public class Caravan : Aanhangwagen, IBewoonbaar
    {
        int aantalSlaapkamers;
        double bewoonbaarOppervlakte;
        public int AantalSlaapkamers
        {
            get
            {
                return aantalSlaapkamers;
            }
        }

        public double BewoonbaarOppervlakte
        {
            get
            {
                return bewoonbaarOppervlakte;
            }
        }

        public Caravan(int aantalbanden, int gewicht, double bewoonbaarOppervlakte, string eigenaar, double prijs) : base(aantalbanden, gewicht, eigenaar, prijs)
        {
            aantalSlaapkamers = 1;
            if (bewoonbaarOppervlakte < 0)
            {
                this.bewoonbaarOppervlakte = 0;
            }
            else if (bewoonbaarOppervlakte > double.MaxValue)
            {
                this.bewoonbaarOppervlakte = double.MaxValue;
            }
            else
            {
                this.bewoonbaarOppervlakte = bewoonbaarOppervlakte;
            }
        }

        public override string ToString()
        {
            return "Aantal slaapkamers: " + AantalSlaapkamers + "\nBewoonbaar oppervlakte: " + bewoonbaarOppervlakte + "\n" + base.ToString();
        }
    }
}