using System.Text.RegularExpressions;

namespace Theme06_Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности пароля.
            //Пароль должен состоять минимум из 14 символов и иметь в составе
            //минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора !#;%:?*.
            //Запрашивать у пользователя пароль до тех пор, пока он не введет пароль, удовлетворяющий регулярному выражению.

            Regex pattern = new Regex(@"^(?=.+\d)(?=.+[A-Z])(?=.+[a-z])(?=.+[!#;%:?*])[\dA-Za-z!#;%:?*]{14,}$");
            // {14,} - не менее 14 любых символов
            // [!#;%:?*], [a-z], [A-Z], [0-9] - класс символов, букв, цифр
            // + - поиск 1 или более повторов символа
            // . - поиск любого символа
            // [0-9A-Za-z!!#;%:?*] - символы только из данного диапазона
            // (?= ...) - положительное опережающее условие(за первой частью выражения обязательно следует выражение из условия)

            Console.WriteLine("Требуется ввести пароль, соответствующий следующим требованиям.");
            Console.WriteLine("Длина не менее 14 символов.");
            Console.WriteLine("Пароль должен содержать все 4 типа символов:");
            Console.WriteLine("прописная буква; строчная буква; цифра; специальный символ (! # ; % : ? *).");
            Console.WriteLine();

            /*
            bool isSatisfy = false;

            while (!isSatisfy)
            {
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();

                isSatisfy = pattern.IsMatch(password);

                if (!isSatisfy)
                    Console.WriteLine("Введенный пароль не соответствует требованиям.");
            }
            Console.WriteLine("Пароль принят!");
            */
            string[] passwords =
{
                ";r;!6=*@mA!Ur;/",
                "QwErTy!1234567",
                "p6cb8mQ3Ifan958",
                "A1b2C3d4!?#*",
                "ValidPass123!*#",
                "1+/</53_0",
                "~/tL01.Qn;30aw",
                "A!bCdEfGhIjK1mN",
                "S[$Yv3}%~Mm3v%I"
            };
            foreach (string unit in passwords)
            {
                if (pattern.IsMatch(unit))
                    Console.WriteLine($"\"{unit}\" - соответствует.");

                else
                    Console.WriteLine($"\"{unit}\" - не соответствует.");
            }

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
