namespace IntegratieOpdrachtPolDeel2.Models
{
    public interface IEigendom
    {
        string Eigenaar { get; }
        double Prijs { get; }

        void BepaalPrijs(double nieuwePrijs);
        void VerkoopAan(string nieuweNaam);
    }
}
