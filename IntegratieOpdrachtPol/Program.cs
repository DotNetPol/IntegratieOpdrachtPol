using System;
using IntegratieOpdrachtPol.Models;

namespace IntegratieOpdrachtPol
{
    class Program
    {
        static void Main(string[] args)
        {
            Aanhangwagen aanhangwagen1 = new Aanhangwagen(1, -50);
            Console.WriteLine(aanhangwagen1 + "\n");

            Aanhangwagen aanhangwagen2 = new Aanhangwagen(4, 50);
            Console.WriteLine(aanhangwagen2 + "\n");

            Caravan caravan1 = new Caravan(2, 150, -98);
            Console.WriteLine(caravan1 + "\n");

            Caravan caravan2 = new Caravan(2, 150, 260);
            Console.WriteLine(caravan2 + "\n");

            Auto auto = new Auto(100, 150, "Peugeot", -5);
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

            Motorhome motorhome1 = new Motorhome(50, -100, "Volvo", 0, -50);
            Console.WriteLine(motorhome1 + "\n");
            Motorhome motorhome2 = new Motorhome(50, 100, "Volvo", 0, 100);
            Console.WriteLine(motorhome2 + "\n");

            Boot boot1 = new Boot(-5, "Acm", 0);
            Console.WriteLine(boot1 + "\n");
            Boot boot2 = new Boot(110, "Acm", 0);
            Console.WriteLine(boot2 + "\n");

            Woonboot woonBoot1 = new Woonboot(80, "Acm", 0, 5, 50);
            Console.WriteLine(woonBoot1 + "\n");
            Woonboot woonBoot2 = new Woonboot(80, "Acm", 0, 2, 50);
            Console.WriteLine(woonBoot2 + "\n");

            Huis huis1 = new Huis(2, -80);
            Console.WriteLine(huis1 + "\n");
            Huis huis2 = new Huis(1, 165);
            Console.WriteLine(huis2 + "\n");

            Kasteel kasteel1 = new Kasteel(2, 350);
            Console.WriteLine(kasteel1 + "\n");
            Kasteel kasteel2 = new Kasteel(5, 350);
            Console.WriteLine(kasteel2 + "\n");


            Console.ReadKey();
        }
    }
}