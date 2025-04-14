using MathGame.Models;

namespace MathGame;

internal class GameEngine
{
    internal void AdditionGame(string message, GameDifficulty difficulty)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        int firstNumber;
        int secondNumber;
        int max = 9;

        switch (difficulty)
        {
            case GameDifficulty.Medium:
                max = 99;
                break;
            case GameDifficulty.Hard:
                max = 999;
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, max);
            secondNumber = random.Next(1, max);

            Console.WriteLine($"{firstNumber} + {secondNumber}");

            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);


            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Addition, difficulty);
    }

    internal void SubtractionnGame(string message, GameDifficulty difficulty)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        int firstNumber;
        int secondNumber;
        int max = 9;

        switch (difficulty)
        {
            case GameDifficulty.Medium:
                max = 99;
                break;
            case GameDifficulty.Hard:
                max = 999;
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, max);
            secondNumber = random.Next(1, max);

            Console.WriteLine($"{firstNumber} - {secondNumber}");

            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Subtraction, difficulty);
    }

    internal void MultiplicationGame(string message, GameDifficulty difficulty)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        var score = 0;
        int firstNumber;
        int secondNumber;
        int max = 9;

        switch (difficulty)
        {
            case GameDifficulty.Medium:
                max = 99;
                break;
            case GameDifficulty.Hard:
                max = 999;
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            firstNumber = random.Next(1, max);
            secondNumber = random.Next(1, max);

            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Multiplication, difficulty);
    }

    internal void DivisionGame(string message, GameDifficulty difficulty)
    {
        var score = 0;
        int max = 99;

        switch (difficulty)
        {
            case GameDifficulty.Medium:
                max = 999;
                break;
            case GameDifficulty.Hard:
                max = 9999;
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers(max);
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                Console.ReadLine();
            }
        }
        Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, GameType.Division, difficulty);
    }
}
