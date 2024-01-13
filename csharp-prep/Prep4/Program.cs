using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int listNumber = -1;
        while (listNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            string userNumber = Console.ReadLine();
            listNumber = int.Parse(userNumber);

            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your list is {sum}.");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of your list is {average}.");

        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The largest number in your list is {maxNumber}.");
    }
}