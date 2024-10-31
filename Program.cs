using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        multiples3_5();
        Console.ReadKey();
        fibonacciEvens();
        Console.ReadKey();
        smallestMultiple();
    }

    static void multiples3_5()
    {
        int sumOfNumbers = 0;
        for(int i = 1; i < 1000; i++)
        {
            if(i%3 == 0 || i%5 == 0)
            {
                sumOfNumbers += i;
            }
        }
        Console.WriteLine("The sum of all numbers divisible by 3 or 5 between 1 and 1000 is " + sumOfNumbers);
    }

    static void fibonacciEvens()
    {
        int previousNum = 0;
        int currentNum = 1;
        int sumOfNumbers = 0;
        while(currentNum < 4000000)
        {
            int temp = currentNum + previousNum;
            if(temp % 2 == 0)
            {
                sumOfNumbers += currentNum + previousNum;
            }
            previousNum = currentNum;
            currentNum = temp;
        }
        Console.WriteLine($"The sum of even terms of the Fibonnacci Sequence under 4,000,000 is {sumOfNumbers}");
    }

    static void smallestMultiple()
    {
        bool divisible = false;
        int possibleNum = 1;
        int correctCount = 0;
        do
        {
            correctCount = 0;
            for(int i = 1; i < 21; i++)
            {
                if(possibleNum % i == 0)
                {
                    correctCount++;
                }
            }
            if(correctCount == 20)
            {
                divisible = true;
            }
            else
            {
                possibleNum++;
            }
        }
        while(!divisible);
        Console.WriteLine($"The lowest number divisble by the numbers 1-20 {possibleNum}");
    }
}