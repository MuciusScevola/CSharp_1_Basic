namespace Theme06_Task01
{
    internal class Program
    {
        static void Main()
        {
            //Ввести с клавиатуры предложение.
            //Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Найти самое длинное слово в строке.
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            string[] words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string wordLongest = words[0];
            foreach (string word in words)
                {
                if (word.Length > wordLongest.Length)
                    wordLongest = word;
            }

            Console.WriteLine($"Самое длинное слово: \"{wordLongest}\" (длина: {wordLongest.Length}).");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
