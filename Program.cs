using System;



//nameSpace
namespace NumberGuesser
{

    class Program
    {
        // Entry Point Methos
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();


            while (true)
            {


                //int correctNumber = 7;

                //make numbr random

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess varable

                int guess = 0;

                //Ask User for number
                Console.WriteLine("Guess a number between 1 and 10");


                while (guess != correctNumber)
                {
                    //get users input

                    string input = Console.ReadLine();

                    //checking for data type

                    if (!int.TryParse(input, out guess))
                    {

                        //print error message

                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;

                    }

                    // cast to int and put in guess

                    guess = Int32.Parse(input);

                    //Match guess to correct Number

                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }


                //output success message


                PrintColorMessage(ConsoleColor.Yellow, "You are so smart !!!!!!!!!!");


                //ask to play again

                Console.WriteLine("Play Again? [Y or N]");

                //get answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }else if (answer == "N")
                {
                    return;
                }

                else {
                    return;

                }


            }
        }



        static void GetAppInfo()
        {

            // Set app Vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Elozzy";



            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            Console.ResetColor();
        }

        static void GreetUser()
        {

            //Ask Users Name

            Console.WriteLine("What is your name?");

            // Get user input

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game .... ", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();

        }
    }
}


