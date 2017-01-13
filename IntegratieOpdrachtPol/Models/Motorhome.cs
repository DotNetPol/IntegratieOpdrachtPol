using System;

namespace IntegratieOpdrachtPol.Models
{
    public class Motorhome : Auto, IBewoonbaar
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

        public Motorhome(int maximaalTrekGewicht, int maximumSnelheid, string merk, int snelheid, double bewoonbaarOppervlakte) : base(maximaalTrekGewicht, maximumSnelheid, merk, snelheid)
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
            return base.ToString() + "\nAantal slaapkamers: " + aantalSlaapkamers + "\nBewoonbaar oppervlakte: " + bewoonbaarOppervlakte;
        }
    }
}