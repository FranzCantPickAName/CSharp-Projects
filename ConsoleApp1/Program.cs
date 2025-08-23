
var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();

GuessingGame.PrintResult(gameResult);
//if (gameResult == GameResult.Victory)
//{
//    Console.WriteLine("You win!");
//}
//else
//{
//    Console.WriteLine("You lose :(");
//}

//var diceRollResult = random.Next(1,7);
//Console.WriteLine(diceRollResult);

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(random.Next(1,11));
//}

Console.ReadKey();


public enum GameResult
{
    Victory,
    Loss
}

public class Dice
{
    private readonly Random _random;
    private const int SidesCount = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    //public int Roll()
    //{
    //    return _random.Next(1,7);
    //}
    public int Roll() => _random.Next(1, SidesCount + 1);

    public void Describe() =>
        Console.WriteLine($"This is a dice with {SidesCount} sides");

}

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

public static class ConsoleReader
{

    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }

}



