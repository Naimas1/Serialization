using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public static class Analyze
    {
        public static int ReplaceWordInFile(string filePath, string searchWord, string replaceWord)
        {
            int replacementsCount = 0;
            try
            {
                string fileContent = File.ReadAllText(filePath);

                fileContent = fileContent.Replace(searchWord, replaceWord, StringComparison.OrdinalIgnoreCase);
                replacementsCount = CountOccurrences(fileContent, replaceWord, StringComparison.OrdinalIgnoreCase);

                File.WriteAllText(filePath, fileContent);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при роботі з файлом: " + ex.Message);
            }

            return replacementsCount;
        }

        public static int CountOccurrences(string text, string word, StringComparison comparison)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(word, index, comparison)) != -1)
            {
                index += word.Length;
                count++;
            }

            return count;
        }
    }
}
