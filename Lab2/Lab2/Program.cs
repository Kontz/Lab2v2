using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string useRes;

            Console.WriteLine("Hello.  Do you need to know the perimeter and area of a room?");

            do
            {

                Console.WriteLine("Enter Room Length:");

                string userLen1 = Console.ReadLine();
                decimal len1 = 0;

                while (!decimal.TryParse(userLen1, out len1))
                {
                    Console.WriteLine("Please enter the numaric value of the room length:");
                    userLen1 = Console.ReadLine();
                }

                Console.WriteLine("Enter Room Width:");
                string userWid1 = Console.ReadLine();
                decimal wid1 = 0;

                while (!decimal.TryParse(userWid1, out wid1))
                {
                    Console.WriteLine("Please enter the numaric value of the room width:");
                    userWid1 = Console.ReadLine();
                }

                Console.Write("The perimeter is: ");
                Console.WriteLine((len1 * 2) + (wid1 * 2));

                Console.Write("The area is: ");
                Console.WriteLine((len1 * wid1));
                Console.WriteLine();


                Console.Write("Would you like to measure another room? ");
                Console.WriteLine("Yes or No");
                useRes = (Console.ReadLine());

            } while (useRes == "Y" || useRes == "y" || useRes == "Yes" || useRes == "yes");

        }
    }
}
