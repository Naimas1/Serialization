using System.Text;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть слово для пошуку: ");
            string searchWord = Console.ReadLine();

            Console.Write("Введіть слово для заміни: ");
            string replaceWord = Console.ReadLine();

            string filePath = "file.txt";
            int replacementsCount = Analyze.ReplaceWordInFile(filePath, searchWord, replaceWord);

            Console.WriteLine("Кількість замін: " + replacementsCount);
            Console.ReadKey();
        }
    }
}