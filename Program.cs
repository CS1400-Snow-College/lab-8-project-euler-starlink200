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
        Console.ReadKey();
        sumSquareDifference();
        Console.ReadKey();
        sumOfPrimes();
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

    static void sumSquareDifference()
    {
        int squareSum = 0;
        int sumSquared = 0;
        for(int i = 1; i < 101; i++)
        {
            squareSum += i*i;
            sumSquared += i;
        }
        int difference = sumSquared*sumSquared - squareSum;
        Console.WriteLine($"The difference between the sum of the first 100 numbers squared and the squared sums of the first 100 numbers is {difference}");
    }

    static void sumOfPrimes()
    {
        int sum = 0;
        int num = 0;

        while(num <= 20)
        {
            //start count at 0, since a number will be tested against 1 and itself in the loop
            int count = 0;
            num++;
            for(int i = 1; i < 11; i++)
            {
                if(num%i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                sum += num;
                //Console.WriteLine("added to the sum");
            }
        }
        Console.WriteLine($"The sum of all primes under 2 million is {sum}");
    }
}