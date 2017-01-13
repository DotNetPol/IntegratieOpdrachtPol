using System;

namespace IntegratieOpdrachtPolDeel3.Models
{
    public class Beurs
    {
        Eigendom[] artikels;

        public Beurs()
        {
            artikels = new Eigendom[100];
        }

        public void Add(Eigendom eigendom)
        {
            bool eigendomToegevoegd = false;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] == null && !eigendomToegevoegd)
                {
                    artikels[i] = eigendom;
                    eigendomToegevoegd = true;
                }
            }
            if (!eigendomToegevoegd)
            {
                Console.WriteLine("Het element kon niet toegevoegd worden omdat de lijst vol zit.");
            }
            Array.Sort(artikels);
            Array.Reverse(artikels);
        }

        public IBelaadbaar[] GetBelaadbaarLijs()
        {
            IBelaadbaar[] belaadbaarLijst = new IBelaadbaar[artikels.Length];
            int aantalBelaadbareArtikels = 0;
            foreach (Eigendom eigendom in artikels)
            {
                if (eigendom != null)
                {
                    IBelaadbaar belaadbaarEigendom = eigendom as IBelaadbaar;
                    if (belaadbaarEigendom != null)
                    {
                        belaadbaarLijst[aantalBelaadbareArtikels] = belaadbaarEigendom;
                        aantalBelaadbareArtikels++;
                    }
                }
            }
            return belaadbaarLijst;
        }
        public IBewoonbaar[] GetBewoonbaar()
        {
            IBewoonbaar[] bewoonbaarLijst = new IBewoonbaar[artikels.Length];
            int aantalBewoonbareArtikels = 0;
            foreach (Eigendom eigendom in artikels)
            {
                if (eigendom != null)
                {
                    IBewoonbaar BewoonbaarEigendom = eigendom as IBewoonbaar;
                    if (BewoonbaarEigendom != null)
                    {
                        bewoonbaarLijst[aantalBewoonbareArtikels] = BewoonbaarEigendom;
                        aantalBewoonbareArtikels++;
                    }
                }
            }
            return bewoonbaarLijst;
        }
        public ITrekbaar[] GetTrekbaarLijst()
        {
            ITrekbaar[] trekbaarLijst = new ITrekbaar[artikels.Length];
            int aantaltrekbareArtikels = 0;
            foreach (Eigendom eigendom in artikels)
            {
                if (eigendom != null)
                {
                    ITrekbaar trekbaarEigendom = eigendom as ITrekbaar;
                    if (trekbaarEigendom != null)
                    {
                        trekbaarLijst[aantaltrekbareArtikels] = trekbaarEigendom;
                        aantaltrekbareArtikels++;
                    }
                }
            }
            return trekbaarLijst;
        }
        public ITrekker[] GetTrekkerLijst()
        {
            ITrekker[] trekkerLijst = new ITrekker[artikels.Length];
            int aantalTrekkers = 0;
            foreach (Eigendom eigendom in artikels)
            {
                if (eigendom != null)
                {
                    ITrekker trekker = eigendom as ITrekker;
                    if (trekker != null)
                    {
                        trekkerLijst[aantalTrekkers] = trekker;
                        aantalTrekkers++;
                    }
                }
            }
            return trekkerLijst;
        }
        public IVoertuig[] GetVoertuigLijst()
        {
            IVoertuig[] voertuigenLijst = new IVoertuig[artikels.Length];
            int aantalVoertuigen = 0;
            foreach (Eigendom eigendom in artikels)
            {
                if (eigendom != null)
                {
                    IVoertuig voertuig = eigendom as IVoertuig;
                    if (voertuig != null)
                    {
                        voertuigenLijst[aantalVoertuigen] = voertuig;
                        aantalVoertuigen++;
                    }
                }
            }
            return voertuigenLijst;
        }
    }
}