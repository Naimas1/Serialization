using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public static class Replace
    {
        public static string ReverseFileContent(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                char[] charArray = fileContent.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при роботі з файлом: " + ex.Message);
                return null;
            }
        }

        public static void SaveToFile(string filePath, string content)
        {
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Помилка при збереженні у файл: " + ex.Message);
            }
        }
    }
}
