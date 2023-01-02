using System;

namespace Quizy
{
    class Program
    {
        static void Main(string[] args)
        {
			var totalScore = 0;


			Console.Write("To answer the question type \"true\" or \"false\"\n");

			Console.Write("1. Barcelona is the capital of Spain \n");

			var entry = Console.ReadLine();

			if (entry.ToLower() == "false")
			{
				totalScore += 1;
			}

			Console.Write("2. Flamenco is a Spanish dance\n");

			var entry2 = Console.ReadLine();

			if (entry2.ToLower() == "true")
			{
				totalScore += 1;
			}

			Console.Write("3. Football is the national sport of Spain\n");

			var entry3 = Console.ReadLine();

			if (entry3.ToLower() == "true")
			{
				totalScore += 1;
			}

			Console.Write("Your score is: " + totalScore + "\n");
			Console.Write("1. Madrid is the capital of Spain\n");
			Console.Write("2. Flamenco is a Spanish dance\n");
			Console.Write("3. Footbal is one of the national sports\n");
		}
    }
}
