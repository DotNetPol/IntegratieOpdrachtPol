namespace IntegratieOpdrachtPolDeel3.Models
{
    public class Huis : Eigendom, IBewoonbaar
    {
        protected int aantalSlaapkamers;
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

        public Huis(int aantalSlaapkamers, double bewoonbaarOppervlakte, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            if (aantalSlaapkamers < 0)
            {
                this.aantalSlaapkamers = 0;
            }
            else if (aantalSlaapkamers > int.MaxValue)
            {
                this.aantalSlaapkamers = int.MaxValue;
            }
            else
            {
                this.aantalSlaapkamers = aantalSlaapkamers;
            }

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
            return base.ToString() + "\nAantal slaapkamers: " + aantalSlaapkamers + "\nBewoonbaar oppervlakte: " + bewoonbaarOppervlakte;
        }
    }
}