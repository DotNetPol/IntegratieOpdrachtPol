namespace IntegratieOpdrachtPolDeel2.Models
{
    public interface IVoertuig
    {
        int MaximumSnelheid { get; }
        string Merk { get; }
        int Snelheid { get; }

        void Versnel(int versnelling);
        void Vertraag(int vertraging);
    }
}