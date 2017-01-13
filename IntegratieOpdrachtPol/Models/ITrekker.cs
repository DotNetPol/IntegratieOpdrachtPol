namespace IntegratieOpdrachtPol.Models
{
    public interface ITrekker
    {
        ITrekbaar Aanhangwagen { get; }
        double MaximaalTrekGewicht { get; }

        void KoppelAanhangwagen(ITrekbaar aanhangwagen);
    }
}