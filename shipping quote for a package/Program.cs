using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping_quote_for_a_package
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduction 
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            //asking the user to input their package weight
            Console.WriteLine("What is your package weight?");
            int yourpackageweight = Convert.ToInt32(Console.ReadLine());
            //if it is heavier than 50  a message will be displayed to tell the user that the package can't
            //be shipped via express shipping
            if (yourpackageweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
            }
            else
            {
                //asking the user to input the package width.
                Console.WriteLine("What is your package width?");
                int yourpackagewidth = Convert.ToInt32(Console.ReadLine());
                //asking the user to input the package height.
                Console.WriteLine("What is you package height?");
                int yourpackageheight = Convert.ToInt32(Console.ReadLine());
                //asking the user to input the package length.
                Console.WriteLine("what is you pachage length?");
                int yourpackagelength = Convert.ToInt32(Console.ReadLine());
                //if the total of the dimensions in greater than 50 a message will be displayed to the user
                if (yourpackagewidth + yourpackageheight + yourpackagelength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                //if the package dimensions and weight are lesser then 50 a calculated amount will be displayed to the user
                //for the shipping cost.
                else
                {
                    decimal Total = yourpackagewidth * yourpackageheight * yourpackagelength * yourpackageweight / 100.00m;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Total + " Thank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
