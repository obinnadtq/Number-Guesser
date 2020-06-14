using System;

namespace NumberGuesser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Please guess a number between 1 and 10");


                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                    }

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number entered, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are correct");


                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;

                }

                else if(answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }

            }


        }

        public static void GetAppInfo()
        {
            string authorName = "Obinna Isiwekpeni";
            string appVersion = "1.0.0";
            string appName = "Number Guesser";

            PrintColorMessage(ConsoleColor.Green, $"{appName} {appVersion} by {authorName}");

        }

        public static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let us play a game....");
        }

        public static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }

    }
}
