﻿namespace IntegratieOpdrachtPol.Models
{
    public class Boot : IVoertuig
    {
        int maximumSnelheid;
        string merk;
        int snelheid;
        public int MaximumSnelheid
        {
            get
            {
                return maximumSnelheid;
            }
        }

        public string Merk
        {
            get
            {
                return merk;
            }
        }

        public int Snelheid
        {
            get
            {
                return snelheid;
            }
        }

        public Boot(int maximumSnelheid, string merk, int snelheid)
        {
            if (maximumSnelheid < 0)
            {
                this.maximumSnelheid = 0;
            }
            else if (maximumSnelheid > int.MaxValue)
            {
                this.maximumSnelheid = int.MaxValue;
            }
            else
            {
                this.maximumSnelheid = maximumSnelheid;
            }

            this.merk = merk;

            if (snelheid < 0)
            {
                snelheid = 0;
            }
            else if (snelheid > int.MaxValue)
            {
                this.snelheid = int.MaxValue;
            }
            else if (snelheid > int.MaxValue)
            {
                this.snelheid = int.MaxValue;
            }
            else
            {
                this.snelheid = snelheid;
            }
        }

        public void Versnel(int versnelling)
        {
            snelheid += versnelling;
            if (snelheid > maximumSnelheid)
            {
                snelheid = maximumSnelheid;
            }
        }

        public void Vertraag(int vertraging)
        {
            snelheid -= vertraging;
            if (snelheid < 0)
            {
                snelheid = 0;
            }
        }
        public override string ToString()
        {
            return "Maximum snelheid: " + maximumSnelheid + "\nMerk: " + merk + "\nSnelheid: " + snelheid;
        }
    }
}