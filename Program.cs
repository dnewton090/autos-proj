using System;

namespace assignment1
{
    public class Automobile
    {
        public int IDNumber { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }

        // Constructors must have the same name as the class
        public Automobile(int IDNumber, string Make, int Year, float Price)
        {
            this.IDNumber = IDNumber;
            this.Make = Make;
            this.Year = Year;
            this.Price = Price;
        }

        //Marked as incorrect – apparently needed to have a return statement
        public void GetDetails()
        {
            Console.WriteLine("The {0} from {1} is listed at {2}.", Make, Year, Price.ToString("C"));
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Automobile Car1 = new Automobile(0001, "Jaguar", 2015, 35000f);
            Automobile Car2 = new Automobile(0002, "Holden", 2012, 15000f);
            Automobile Car3 = new Automobile(0003, "Ford", 2017, 20000f);
            Automobile Car4 = new Automobile(0004, "Volkswagen", 2013, 7500f);
            Car1.GetDetails();
            Car2.GetDetails();
            Car3.GetDetails();
            Car4.GetDetails();
            Console.WriteLine("Hello");
        }
    }
}
