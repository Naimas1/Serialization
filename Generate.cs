using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public static class Generate
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] GetPrimeNumbers(int[] numbers)
        {
            List<int> primeNumbersList = new List<int>();

            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    primeNumbersList.Add(number);
                }
            }

            return primeNumbersList.ToArray();
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int prev = 0;
            int current = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = current;
                current = prev + current;
                prev = temp;
            }

            return current;
        }

        public static int[] GetFibonacciNumbers(int[] numbers)
        {
            int[] fibonacciNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                fibonacciNumbers[i] = Fibonacci(numbers[i]);
            }

            return fibonacciNumbers;
        }
        public static void WriteIntArrayToFile(int[] numbers, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (int number in numbers)
                    {
                        writer.WriteLine(number);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при записі у файл: " + ex.Message);
            }
        }
    }
}
