namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }
            int[] simpleNumbers = Generate.GetPrimeNumbers(numbers);
            int[] fibonacciNumbers = Generate.GetFibonacciNumbers(numbers);
            Generate.WriteIntArrayToFile(simpleNumbers, "simpleNumbers.txt");
            Generate.WriteIntArrayToFile(fibonacciNumbers, "fibonacciNumbers.txt");
            foreach (int number in simpleNumbers)
            {
                Console.WriteLine(number);
            }
            foreach (int number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}