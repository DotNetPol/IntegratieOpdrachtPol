using System;

namespace IntegratieOpdrachtPolDeel3.Models
{
    public class OverBeladenException : ApplicationException
    {
        public double MaximaleTrekkracht { get; set; }
        public double TeTrekkenGewicht { get; set; }

        public OverBeladenException(string message, double maximaleTrekkracht, double teTrekkenGewicht) : base(message)
        {
            MaximaleTrekkracht = maximaleTrekkracht;
            TeTrekkenGewicht = teTrekkenGewicht;
        }
    }
}