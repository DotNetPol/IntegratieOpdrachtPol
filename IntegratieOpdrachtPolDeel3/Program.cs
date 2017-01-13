using System;
using IntegratieOpdrachtPolDeel3.Models;

namespace IntegratieOpdrachtPol3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lijstOpvragen = true;
            bool geldigeLijstWerdOpgevraagd = true;
            ConsoleKey inputKey;

            Aanhangwagen aanhangwagen1 = new Aanhangwagen(1, -50, "Steven", 10.95, 0, 50);
            Aanhangwagen aanhangwagen2 = new Aanhangwagen(4, 50, "Yannick", 15.95, 0, 75);

            Caravan caravan1 = new Caravan(2, 150, -98, "Christophe", 357298.54, 71, 500);
            Caravan caravan2 = new Caravan(2, 150, 260, "Chantale", 387159.57, 91, 550);

            Auto auto = new Auto(100, 150, "Peugeot", -5, "David", 25688.45);

            Motorhome motorhome1 = new Motorhome(50, -100, "Volvo", 0, -50, "Willy", 500384.94);
            Motorhome motorhome2 = new Motorhome(50, 100, "Volvo", 0, 100, "Suzanne", 624284.35);

            Woonboot woonBoot1 = new Woonboot(80, "Acm", 0, 5, 50, "Leonie", 65847.84);
            Woonboot woonBoot2 = new Woonboot(80, "Acm", 0, 2, 50, "Kobe", 84384.75);

            Huis huis1 = new Huis(2, -80, "Jullian", -150657.23);
            Huis huis2 = new Huis(1, 165, "Sven", 200985.65);

            Kasteel kasteel1 = new Kasteel(2, 350, "Jonnathan", 999999.99);
            Kasteel kasteel2 = new Kasteel(5, 350, "Pol", 3570284.21);

            Transportboot transportBoot = new Transportboot(0, 100, 120, "Acm", 0, "Pol", 50000.00);

            //Hiermee test ik de zelf gemaakte exceptions.
            try
            {
                auto.Versnel(10);
                auto.KoppelAanhangwagen(aanhangwagen2);
            }
            catch (KoppelException ke)
            {
                Console.WriteLine(ke.Message);
                Console.WriteLine(ke.Snelheid);
                Console.WriteLine();
            }
            finally
            {
                auto.Vertraag(10);
                Console.WriteLine(auto.Snelheid);
                Console.WriteLine();
            }

            try
            {
                auto.KoppelAanhangwagen(aanhangwagen2);
                (auto.Aanhangwagen as IBelaadbaar).Laden(60);
                auto.Versnel(10);
            }
            catch (OverBeladenException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TeTrekkenGewicht);
                Console.WriteLine(ex.MaximaleTrekkracht);
            }

            Console.ReadKey();
            Console.Clear();

            Beurs beurs = new Beurs();
            beurs.Add(aanhangwagen1);
            beurs.Add(aanhangwagen2);
            beurs.Add(caravan1);
            beurs.Add(caravan2);
            beurs.Add(auto);
            beurs.Add(motorhome1);
            beurs.Add(motorhome2);
            beurs.Add(woonBoot1);
            beurs.Add(woonBoot2);
            beurs.Add(huis1);
            beurs.Add(huis2);
            beurs.Add(kasteel1);
            beurs.Add(kasteel2);
            beurs.Add(transportBoot);

            do
            {
                Console.WriteLine(@"Wat wilt u doen? (geef de overeenkomende nummer in)
1   Lijst opvragen
2   Afsluiten
");
                inputKey = Console.ReadKey(true).Key;
                if (inputKey == ConsoleKey.NumPad1)
                {
                    do
                    {
                        Console.WriteLine(@"Welke lijst wil u opvragen? (geef de overeenkomende nummer in)
1   Lijst van belaadbare eigendommen.
2   Lijst van bewoonbare eigendommen.
3   Lijst van trekbare eigendommen.
4   Lijst van eigendommen die kunnen trekken.
5   Lijst van voertuigen.
");
                        geldigeLijstWerdOpgevraagd = true;
                        inputKey = Console.ReadKey(true).Key;
                        if (inputKey == ConsoleKey.NumPad1)
                        {
                            IBelaadbaar[] belaadbareEigendommenLijst = beurs.GetBelaadbaarLijs();
                            if (belaadbareEigendommenLijst != null)
                            {
                                foreach (IBelaadbaar belaadbaarEigendom in belaadbareEigendommenLijst)
                                {
                                    if (belaadbaarEigendom != null)
                                    {
                                        Console.WriteLine(belaadbaarEigendom + "\n"); 
                                    }
                                }
                            }
                        }
                        else if (inputKey == ConsoleKey.NumPad2)
                        {
                            IBewoonbaar[] bewoonbareEigendommenLijst = beurs.GetBewoonbaar();
                            if (bewoonbareEigendommenLijst != null)
                            {
                                foreach (IBewoonbaar bewoonbaarEigendom in bewoonbareEigendommenLijst)
                                {
                                    if (bewoonbaarEigendom != null)
                                    {
                                        Console.WriteLine(bewoonbaarEigendom + "\n"); 
                                    }
                                }
                            }
                        }
                        else if (inputKey == ConsoleKey.NumPad3)
                        {
                            ITrekbaar[] trekbareEigendommenLijst = beurs.GetTrekbaarLijst();
                            if (trekbareEigendommenLijst != null)
                            {
                                foreach (ITrekbaar trekbaarEigendom in trekbareEigendommenLijst)
                                {
                                    if (trekbaarEigendom != null)
                                    {
                                        Console.WriteLine(trekbaarEigendom + "\n"); 
                                    }
                                }
                            }
                        }
                        else if (inputKey == ConsoleKey.NumPad4)
                        {
                            ITrekker[] trekkerEigendommenLijst = beurs.GetTrekkerLijst();
                            if (trekkerEigendommenLijst != null)
                            {
                                foreach (ITrekker trekkerEigendom in trekkerEigendommenLijst)
                                {
                                    if (trekkerEigendom != null)
                                    {
                                        Console.WriteLine(trekkerEigendom + "\n"); 
                                    }
                                }
                            }
                        }
                        else if (inputKey == ConsoleKey.NumPad5)
                        {
                            IVoertuig[] voertuigenLijst = beurs.GetVoertuigLijst();
                            if (voertuigenLijst != null)
                            {
                                foreach (IVoertuig voertuig in voertuigenLijst)
                                {
                                    if (voertuig != null)
                                    {
                                        Console.WriteLine(voertuig + "\n"); 
                                    }
                                }
                            }
                        }
                        else
                        {
                            geldigeLijstWerdOpgevraagd = false;
                            Console.WriteLine("Geen geldige input. Probeer het opnieuw.");
                        }
                    } while (!geldigeLijstWerdOpgevraagd);
                }
                else if (inputKey == ConsoleKey.NumPad2)
                {
                    lijstOpvragen = false;
                }
                else
                {
                    Console.WriteLine("Geen geldige input. Probeer het opnieuw.");
                }
            } while (lijstOpvragen);
        }
    }
}