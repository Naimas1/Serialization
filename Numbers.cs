using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public static class Numbers
    {
        public static void GenerateAndWriteNumbersToFile(string filePath, int count, int minValue, int maxValue)
        {
            try
            {
                Random random = new Random();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < count; i++)
                    {
                        int randomNumber = random.Next(minValue, maxValue + 1);
                        writer.WriteLine(randomNumber);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при записі у файл: " + ex.Message);
            }
        }
        public static void SaveNumbersToFile(string filePath, List<int> numbers)
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
                Console.WriteLine("Помилка при збереженні у файл: " + ex.Message);
            }
        }
    }
}
