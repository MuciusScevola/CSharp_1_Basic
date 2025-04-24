namespace Theme06_Task02
{
    internal class Program
    {
        static void Main()
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
            //Составить программу, определяющую, является ли строка палиндромом без учёта пробелов и регистра.
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            string sentenceAnalised = input.Replace(" ", "").ToLower(); //Получение сплошной строки.

            bool isPalindrome = true;
            int left = 0;
            int right = sentenceAnalised.Length - 1;
            while (left < right)
            {
                if (sentenceAnalised[left] != sentenceAnalised[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            if (isPalindrome)
                Console.WriteLine("Данное предложение палиндром.");
            else
                Console.WriteLine("Данное предложение не палиндром.");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
