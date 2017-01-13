using System;

namespace IntegratieOpdrachtPolDeel3.Models
{
    public class KoppelException : ApplicationException
    {
        public int Snelheid { get; set; }

        public KoppelException(string message, int snelheid) : base(message)
        {
            Snelheid = snelheid;
        }
    }
}