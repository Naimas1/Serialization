using System.Text;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть шлях до вихідного файлу: ");
            string sourceFilePath = Console.ReadLine();

            string reversedContent = Replace.ReverseFileContent(sourceFilePath);

            if (!string.IsNullOrEmpty(reversedContent))
            {
                string destinationFilePath = "reversed_" + Path.GetFileName(sourceFilePath);
                Replace.SaveToFile(destinationFilePath, reversedContent);
                Console.WriteLine("Файл з перевернутим вмістом створено: " + destinationFilePath);
            }

            Console.ReadKey();
        }
    }
}