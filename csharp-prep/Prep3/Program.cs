using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        do
        {
            Console.WriteLine("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher, try again: ");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower, try again: ");
            }
            else
            {
                Console.WriteLine("That's it! You got it!");
            }
        } while (guess != number);
    }
}