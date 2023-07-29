using System.Text;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string filePath = "numbers.txt";

            int positiveCount = 0;
            int negativeCount = 0;
            int twoDigitCount = 0;
            int fiveDigitCount = 0;

            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();
            List<int> twoDigitNumbers = new List<int>();
            List<int> fiveDigitNumbers = new List<int>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int number))
                    {
                        if (number > 0)
                        {
                            positiveCount++;
                            positiveNumbers.Add(number);
                        }
                        else if (number < 0)
                        {
                            negativeCount++;
                            negativeNumbers.Add(number);
                        }

                        if (number >= 10 && number <= 99)
                        {
                            twoDigitCount++;
                            twoDigitNumbers.Add(number);
                        }
                        else if (number >= 10000 && number <= 99999)
                        {
                            fiveDigitCount++;
                            fiveDigitNumbers.Add(number);
                        }
                    }
                }

                Console.WriteLine("Кількість додатніх чисел: " + positiveCount);
                Console.WriteLine("Кількість від'ємних чисел: " + negativeCount);
                Console.WriteLine("Кількість двозначних чисел: " + twoDigitCount);
                Console.WriteLine("Кількість п'ятизначних чисел: " + fiveDigitCount);

                Numbers.SaveNumbersToFile("positive_numbers.txt", positiveNumbers);
                Numbers.SaveNumbersToFile("negative_numbers.txt", negativeNumbers);
                Numbers.SaveNumbersToFile("two_digit_numbers.txt", twoDigitNumbers);
                Numbers.SaveNumbersToFile("five_digit_numbers.txt", fiveDigitNumbers);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при роботі з файлом: " + ex.Message);
            }
        }
    }
}