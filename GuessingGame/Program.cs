
using System;
using System.Reflection.Metadata;

namespace Test
{
    class Stuff
    {


        public static void Game()
        {

            Random rd = new Random();
            int random = rd.Next(0, 20);
            //Console.WriteLine(random.ToString());

            int userinput;
            Console.Write("Enter a number of your choice: ");
            string? inp = Console.ReadLine();
            if (inp is null)
            {
                Console.WriteLine("invalid input :(");
                return;
            }

            try {
                userinput = Convert.ToInt32(inp);
            } catch (Exception)
            {
                Console.WriteLine("ERROR: invalid number! :(");
                return;
            }

            if (userinput > 20 || userinput < 0)
            {
                Console.WriteLine("ERROR: Number is out of range :(\n");
                return;
            }

            if (userinput == random)
                Console.WriteLine("You guessed right!! {0} and {1} are the same !!!", random, userinput);
            else
                Console.WriteLine("Nope, the random number is {0}; you guessed {1} :(", random, userinput);

            

        }

        public static bool AskForExit()
        {
            bool response = false;
            Console.WriteLine("Do you want to continue? (Y/n)");
            string? userinput = Console.ReadLine();
            /*if (userinput == null)
            {
                return response;
            }*/
            if (userinput == "N" || userinput == "n")
            {
                response = true;
            }
            return response;
        }

        public static void Main()
        {
            Console.WriteLine("Welcome to the famous guessing game!");

            bool quit = false;
            while (!quit)
            {
                Game();
                quit = AskForExit();
            }
        }
    }
}