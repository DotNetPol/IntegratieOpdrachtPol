namespace IntegratieOpdrachtPolDeel3.Models
{
    public class Woonboot : Boot, IBewoonbaar
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
        
        public Woonboot(int maximumSnelheid, string merk, int snelheid, int aantalSlaapkamers, double bewoonbaarOppervlakte, string eigenaar, double prijs) : base(maximumSnelheid, merk, snelheid, eigenaar, prijs)
        {
            if (aantalSlaapkamers < 0)
            {
                this.aantalSlaapkamers = 0;
            }
            else if (aantalSlaapkamers > 2)
            {
                this.aantalSlaapkamers = 2;
            }
            else
            {
                this.aantalSlaapkamers = aantalSlaapkamers;
            }

            if (bewoonbaarOppervlakte <= 0)
            {
                this.bewoonbaarOppervlakte = 1;
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