namespace IntegratieOpdrachtPol.Models
{
    public class Huis : IBewoonbaar
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

        public Huis(int aantalSlaapkamers, double bewoonbaarOppervlakte)
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
            return "Aantal slaapkamers: " + aantalSlaapkamers + "\nBewoonbaar oppervlakte: " + bewoonbaarOppervlakte;
        }
    }
}