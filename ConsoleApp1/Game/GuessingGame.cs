
using ConsoleApp1.UserCommunication;

namespace ConsoleApp1.Game
{

    class GuessingGame
    {
        private readonly Dice _dice;
        //private readonly ConsoleReader _consoleReader;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice) //,ConsoleReader consoleReader
        {
            _dice = dice;
            //_consoleReader = consoleReader;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine(
                $"Dice rolled. Guess what number it shows in {InitialTries} tries.");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number: ");

                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wronng number.");
                --triesLeft;

            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            //string message;
            //if (gameResult == GameResult.Victory)
            //{
            //    message = "You win!";
            //}
            //else
            //{
            //    message = "You lose :(";   }

            string message = gameResult == GameResult.Victory
            ? "You win!"
            : "You lose :(";

            Console.WriteLine(message);
        }

    }

}
