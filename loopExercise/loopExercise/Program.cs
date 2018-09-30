using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace loopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
			//1st question
			string[] colors = { "White", "Red", "Blue", "Green", "Purple", "Black" };
			Console.WriteLine("What is your favorite animal?");
			string userAnimal = Console.ReadLine();

			for (int i = 0; i < colors.Length; i++)
			{
				colors[i] = (colors[i] + " " + userAnimal);
				//Console.WriteLine("Your animal paired with a color is: " + colors[i]); //You don't need the 2nd loop but it was asked for in the exercise.
			}
			for (int j = 0; j < colors.Length; j++)
			{
				Console.WriteLine("Your animal paired with a color is: " + colors[j]);
			}
			Console.ReadLine();

			//2nd Question
			Console.WriteLine("It's time for everyones favorite game, Guess my favorite number. When your ready please enter your guess.");
			int number = Convert.ToInt32(Console.ReadLine());
			bool guess = number == -1;

			while (!guess)
			{
				switch (number)
				{
					case 14:
						Console.WriteLine("You guessed 21. You are correct! Well Done!");
						guess = true;
						break;

					default:
						Console.WriteLine("You guessed incorrectly. Please try again.");
						Console.WriteLine("Your guess?");
						number = Convert.ToInt32(Console.ReadLine());
						break;
				}
			}
			Console.ReadLine();

			//3rd Question
			Console.WriteLine("It's time for everyones favorite game, Guess my favorite number. When your ready please enter your guess.");
			int numberA = Convert.ToInt32(Console.ReadLine());
			bool guessA = number == 21;

			while (!guessA)
			{
				switch (numberA)
				{
					case 14:
						Console.WriteLine("You guessed 21. You are correct! Well Done!");
						guessA = true;
						break;

					default:
						Console.WriteLine("You guessed incorrectly. Please try again.");
						Console.WriteLine("Your guess?");
						numberA = Convert.ToInt32(Console.ReadLine());
						break;
				}
			}
			Console.ReadLine();

			//4th Question
			int[] userNumber = new int[10];
			Console.WriteLine("I'm going to ask you for a few numbers. Please pick numbers between 1-50. Thank you.");

			for (int h = 0; h < userNumber.Length; h++)
			{
				Console.WriteLine("Number please.");
				userNumber[h] = Convert.ToInt32(Console.ReadLine());

			}

			for (int i = 0; i < userNumber.Length; i++)
			{
				if (userNumber[i] < 10)
				{
					Console.WriteLine("The numbers that you entered that were under 10 were: " + userNumbers[i]);

				}
				Console.WriteLine("Thanks for playing.");
			}
			Console.ReadLine();

			//5th question
			int[] userNumber2 = new int[10];
			Console.WriteLine("I'm going to ask you for a few numbers. Please pick numbers between 1-50. Thank you.");

			for (int k = 0; k < userNumber2.Length; k++)
			{
				Console.WriteLine("Number please.");
				userNumber2[k] = Convert.ToInt32(Console.ReadLine());

			}

			for (int j = 0; j < userNumber2.Length; j++)
			{
				if (userNumber2[j] <= 10)
				{
					Console.WriteLine("The numbers that you entered that were 10 or less: " + userNumber2[j]);
				}
			}

			Console.ReadLine();

			//6th, 7th and 8th question
			List<string> favColors = new List<string> { "Red", "Blue", "Green", "Pink", "Turquoise", "Yellow", "Silver", "Orange" };
			Console.WriteLine("What is your favorite color?");
			string userColor = Console.ReadLine();
			CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
			TextInfo textInfo = cultureInfo.TextInfo;
			string newUserColor = textInfo.ToTitleCase(userColor);

			for (int a = 0; a < favColors.Count; a++)
			{
				if (favColors[a] == newUserColor)
				{
					Console.WriteLine("The index in the list of colors that matched yours is: " + a);
					Console.ReadLine();
					Environment.Exit(0);
				}
				else
				{
					Console.WriteLine("You picked a color that was not in the list. Thanks for playing.");
				}
			}

			Console.ReadLine();

			//9th Question
			List<string> userNames = new List<string>() { "Ruth", "Barry", "Bob", "Jason", "John", "Chris", "Jennifer", "Jason", "Ada", "Theresa", "Rylee" };
			var userList = new List<string>();
			var duplicateUserName = new List<string>();

			foreach (var name in userNames)
			{
				if (!userList.Contains(name))
					userList.Add(name);
				else
					duplicateUserName.Add(name);
			}

			foreach (var name in duplicateUserName)
				Console.WriteLine(name);

			Console.ReadLine();


































			Console.ReadLine();

            

        }
    }
}
