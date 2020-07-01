using static System.Console;

namespace Autos_ProjCs
{
    public class TestAutomobile
    {
        static void Main(string[] args)
        {
            Automobile[] Autos = new Automobile[10];

            // Vanilla autos
            Autos[0] = new Automobile(0001, "Jaguar Blue", 2015, 35000f);
            Autos[1] = new Automobile(0002, "Holden Commy", 2012, 15000f);

            // Overloaded autos, discount = ##.#f (%)
            Autos[2] = new Automobile(0003, "Ford Ranger", 2017, 20000f, 7.8f);
            Autos[3] = new Automobile(0004, "Volkswagen", 2013, 48000f, 17.5f);
            Autos[4] = new Automobile(0005, "Audi TT", 2013, 75000f, 19.0f);

            // Extended financed class, annual interest rate = ##.#f (%)
            Autos[5] = new FinancedAutomobile(0006, "Toyota Lexus", 2018, 39999f, 7.0f);
            Autos[6] = new FinancedAutomobile(0007, "Suzuki Buzz", 2009, 19990f, 8.5f);
            Autos[7] = new FinancedAutomobile(0008, "Google Pixel", 2015, 22000f, 9.2f);
            Autos[8] = new FinancedAutomobile(0009, "Dodge RAM", 2020, 50000f, 5.6f);
            Autos[9] = new FinancedAutomobile(0010, "Jeep Cherokee", 1990, 65000f, 7.5f);

            WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––\n" +
                "\t\t\t\t   Autos Inventory\n" +
                "––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");

            for (int i = 0; i < Autos.Length; i++)
            {
                WriteLine((Autos[i]).ToString());
            }




        }
    }
}
