using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public static class Moderator
    {
        public static string[] ReadModerationWords(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath)
                           .SelectMany(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                           .Distinct()
                           .ToArray();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при зчитуванні файлу зі словами для модерації: " + ex.Message);
                return null;
            }
        }

        public static string ModerateTextFile(string filePath, string[] moderationWords)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);

                foreach (string word in moderationWords)
                {
                    string replacement = new string('*', word.Length);
                    fileContent = fileContent.Replace(word, replacement, StringComparison.OrdinalIgnoreCase);
                }

                return fileContent;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при роботі з файлом з текстом: " + ex.Message);
                return null;
            }
        }
    }
}
