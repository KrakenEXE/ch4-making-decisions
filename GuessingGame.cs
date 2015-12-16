using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            int userInput;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);


            Console.WriteLine("Pick a number between 1 and 11: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput != randomNumber)
            {
                if (userInput > randomNumber && userInput <= 12)
                {
                    Console.WriteLine("Guess was too high Guess again!");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else
                if (userInput < randomNumber && userInput >= 1)
                {
                    Console.WriteLine("Guess was too low Guess again!");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else
                if (userInput == randomNumber)
                {
                    Console.WriteLine("Great job " + randomNumber.ToString() + " was the number!");
                }
                else
                    Console.WriteLine("Please choose between 1-11. "+userInput.ToString()+" is not a proper guess.");
                    userInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
