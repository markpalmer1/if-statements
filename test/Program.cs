using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Mark's Big Giveaway!");
            Console.Write("Choose a door: 1, 2 or 3:");
            string userValue = Console.ReadLine();


            string message = "";

            if (userValue == "1")
            {
                 message = "You won a new car!!";
                
            }
            else if (userValue == "2")
            {
                 message = "You won nothing";
                
            }
            else if (userValue == "3")
            {
                 message = "You won a £10 voucher";
                
            }
            else
            {
                 message = "Sorry, we didn't understand that. ";
                //message = message + "You Lose";
                message += "you lose. ";
                
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */
            
            Console.WriteLine("Mark's Big Giveaway!");
            Console.Write("Choose a door: 1, 2 or 3:");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Boat" : "Car";
            //   Console.Write("You won a  ");
            //Console.Write(message);
            //Console.Write (".");
            Console.WriteLine("You entered: {0}, therefore you won a {1}", userValue, message);

            Console.ReadLine();
            
        }
    }
}
