using System;
using System.Diagnostics;
using MathGame.Models;

namespace MathGame;

internal class GameEngine
{
    Stopwatch stopWatch = new Stopwatch();
    Random random = new Random();
    internal void ArithmeticGame(string message, GameType type, GameDifficulty difficulty, Func<int, int, int> operation, string symbol)
    {
        Console.Clear();
        Console.WriteLine(message);
        var score = 0;
        stopWatch.Start();

        int max = (symbol, difficulty) switch
        {
            ("/", GameDifficulty.Easy) => 99,
            ("/", GameDifficulty.Medium) => 999,
            ("/", GameDifficulty.Hard) => 9999,
            (_, GameDifficulty.Medium) => 99,
            (_, GameDifficulty.Hard) => 999,
            _ => 9
        };

        for (int i = 0; i < 5; i++)
        {
            (int firstNumber, int secondNumber)  = Helpers.GenerateQuestionNumbers(symbol, max, random);

            var isCorrect = Helpers.AskQuestionAndEvaluate(symbol, firstNumber, secondNumber, operation);

            if (isCorrect) score++;
        }

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

        Console.WriteLine("Time taken to complete: " + elapsedTime);
        Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();

        Helpers.AddToHistory(score, type, difficulty, elapsedTime);
    }
}
