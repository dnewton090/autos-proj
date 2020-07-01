using System;
using static System.Console;

namespace Autos_ProjCs
{
    public class FinancedAutomobile : Automobile
    {
        public float Finance { get; set; }

        public FinancedAutomobile(int IDNumber, string Make, int Year, float Price, float Finance) : base(IDNumber, Make, Year, Price)
        {
            this.Finance = Finance/100;
            if (Finance < 0 || Finance > 10)
            {
                WriteLine("ERROR: Finance rates must lie between 0% and 10% p.a");
                Environment.Exit(1);
            }
        }

        public override string ToString()
        {
            string details = base.ToString() + String.Format(" | Rate: {0, 5} p.a.", this.Finance.ToString("P1"));
            return details;

        }

    }
}
