using System.Text;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть шлях до файлу з текстом: ");
            string textFilePath = Console.ReadLine();

            Console.Write("Введіть шлях до файлу зі словами для модерації: ");
            string moderationFilePath = Console.ReadLine();

            string[] moderationWords = Moderator.ReadModerationWords(moderationFilePath);

            if (moderationWords == null)
            {
                Console.WriteLine("Помилка при зчитуванні слів для модерації.");
                Console.ReadKey();
                return;
            }

            string resultText = Moderator.ModerateTextFile(textFilePath, moderationWords);

            Console.WriteLine("Результат модерації:");
            Console.WriteLine(resultText);

            Console.ReadKey();
        }
    }
}