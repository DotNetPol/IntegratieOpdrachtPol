using System;
using IntegratieOpdrachtPolDeel2.Models;

namespace IntegratieOpdrachtPol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aanhangwagen aanhangwagen1 = new Aanhangwagen(1, -50, "Steven", 10.95);
            Console.WriteLine(aanhangwagen1 + "\n");
            aanhangwagen1.VerkoopAan("Jens");
            aanhangwagen1.BepaalPrijs(-10.95);
            Console.WriteLine(aanhangwagen1 + "\n");
            aanhangwagen1.BepaalPrijs(9.01);
            Console.WriteLine(aanhangwagen1 + "\n");

            Aanhangwagen aanhangwagen2 = new Aanhangwagen(4, 50, "Yannick", 15.95);
            Console.WriteLine(aanhangwagen2 + "\n");

            Caravan caravan1 = new Caravan(2, 150, -98, "Christophe", 357298.54);
            Console.WriteLine(caravan1 + "\n");

            Caravan caravan2 = new Caravan(2, 150, 260, "Chantale", 387159.57);
            Console.WriteLine(caravan2 + "\n");

            Auto auto = new Auto(100, 150, "Peugeot", -5, "David", 25688.45);
            Console.WriteLine(auto + "\n");

            try
            {
                auto.KoppelAanhangwagen(caravan2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            auto.KoppelAanhangwagen(aanhangwagen2);
            Console.WriteLine(auto + "\n");
            auto.Versnel(70);

            try
            {
                auto.KoppelAanhangwagen(aanhangwagen1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            auto.Versnel(100);
            Console.WriteLine(auto + "\n");
            auto.Vertraag(10);
            Console.WriteLine(auto + "\n");
            auto.Vertraag(300);
            Console.WriteLine(auto + "\n");

            Motorhome motorhome1 = new Motorhome(50, -100, "Volvo", 0, -50, "Willy", 500384.94);
            Console.WriteLine(motorhome1 + "\n");
            Motorhome motorhome2 = new Motorhome(50, 100, "Volvo", 0, 100, "Suzanne", 624284.35);
            Console.WriteLine(motorhome2 + "\n");

            /*Boot boot1 = new Boot(-5, "Acm", 0, "Pieter-Jan", 150.14);
            Console.WriteLine(boot1 + "\n");
            Boot boot2 = new Boot(110, "Acm", 0, "Aaron", 150.14);
            Console.WriteLine(boot2 + "\n");*/

            Woonboot woonBoot1 = new Woonboot(80, "Acm", 0, 5, 50, "Leonie", 65847.84);
            Console.WriteLine(woonBoot1 + "\n");
            Woonboot woonBoot2 = new Woonboot(80, "Acm", 0, 2, 50, "Kobe", 84384.75);
            Console.WriteLine(woonBoot2 + "\n");

            Huis huis1 = new Huis(2, -80, "Jullian", -150657.23);
            Console.WriteLine(huis1 + "\n");
            Huis huis2 = new Huis(1, 165, "Sven", 200985.65);
            Console.WriteLine(huis2 + "\n");

            Kasteel kasteel1 = new Kasteel(2, 350, "Jonnathan", 999999.99);
            Console.WriteLine(kasteel1 + "\n");
            Kasteel kasteel2 = new Kasteel(5, 350, "Pol", 3570284.21);
            Console.WriteLine(kasteel2 + "\n");

            Transportboot transportBoot = new Transportboot(0, 100, 120, "Acm", 0, "Pol", 50000.00);
            Console.WriteLine(transportBoot + "\n");
            transportBoot.Laden(50);
            Console.WriteLine(transportBoot + "\n");
            transportBoot.Versnel(100);
            Console.WriteLine(transportBoot + "\n");
            transportBoot.Vertraag(100);
            Console.WriteLine(transportBoot + "\n");
            transportBoot.Lossen(10);
            Console.WriteLine(transportBoot + "\n");
            transportBoot.Versnel(10);
            Console.WriteLine(transportBoot + "\n");

            try
            {
                transportBoot.Laden(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            Console.WriteLine(transportBoot + "\n");
            try
            {
                transportBoot.Lossen(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            try
            {
                transportBoot.Versnel(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
            try
            {
                transportBoot.Vertraag(200);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            Console.ReadKey();
        }
    }
}