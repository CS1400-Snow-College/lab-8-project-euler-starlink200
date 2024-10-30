internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        multiples3_5();
        Console.ReadKey();
        fibonacciEvens();
    }

    static void multiples3_5()
    {
        int sumOfNumbers = 0;
        for(int i = 1; i < 1001; i++)
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
        for(int i = 0; i < 20; i++)
        {
            int temp = currentNum + previousNum;
            Console.Write($"{currentNum + previousNum} ");
            previousNum = currentNum;
            currentNum = temp;
        }
    }
}