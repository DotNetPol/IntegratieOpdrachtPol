namespace IntegratieOpdrachtPolDeel2.Models
{
    public class Kasteel : Huis
    {
        public Kasteel(int aantalSlaapkamers, double bewoonbaarOppervlakte, string eigenaar, double prijs) : base(aantalSlaapkamers, bewoonbaarOppervlakte, eigenaar, prijs)
        {
            if (aantalSlaapkamers < 3)
            {
                this.aantalSlaapkamers = 3;
            }
            else if (aantalSlaapkamers > int.MaxValue)
            {
                this.aantalSlaapkamers = int.MaxValue;
            }
            else
            {
                this.aantalSlaapkamers = aantalSlaapkamers;
            }
        }
    }
}