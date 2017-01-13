namespace IntegratieOpdrachtPolDeel2.Models
{
    public interface IBelaadbaar
    {
        double HuidigeBelading { get; }
        double MaximumLaadGewicht { get; }

        void Laden(double gewicht);
        void Lossen(double gewicht);
    }
}