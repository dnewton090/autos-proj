using System;
using static System.Console;

namespace Autos_ProjCs
{
    public class Automobile
    {
        public int IDNumber { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        protected float Discount;

        // Constructors must have the same name as the class
        public Automobile(int IDNumber, string Make, int Year, float Price)
        {
            this.IDNumber = IDNumber;
            this.Make = Make;
            this.Year = Year;
            if ( Year < 1950 || Year > 2020)
            {
                WriteLine("ERROR: Manufacturing years must lie between 1950 and 2020");
                Environment.Exit(1);
            }
            this.Price = Price;
        }

        // Overloaded Constructor:  this keyword reduces code replication
        public Automobile(int IDNumber, string Make, int Year, float Price, float Discount) : this(IDNumber, Make, Year, Price)
        {
            this.Price = Price * (1 - Discount/100);
            if(Discount < 0 || Discount > 20)
            {
                WriteLine("ERROR: Auto discounts must only be entered between 0% and 20%");
                Environment.Exit(1);
            }
        }

        // ToString() similar to __str__ or __repr__ in python?
        public override string ToString()
        {
            string details = String.Format("ID #: {0, 2} | Year: {1, 6} | Make: {2, 15} | Price: {3, 10}", this.IDNumber, this.Year, this.Make, this.Price.ToString("C"));
            return details;

        }

    }

}
