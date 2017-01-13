namespace IntegratieOpdrachtPol.Models
{
    public class Kasteel : Huis
    {
        public Kasteel(int aantalSlaapkamers, double bewoonbaarOppervlakte) : base(aantalSlaapkamers, bewoonbaarOppervlakte)
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