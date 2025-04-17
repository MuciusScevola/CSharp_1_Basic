using System.Text.RegularExpressions;

namespace Theme06_Task06
{
    internal class Program
    {
        static void Main()
        {
            //Составить регулярное выражение для проверки корректности пароля.
            //Пароль должен состоять минимум из 14 символов и иметь в составе
            //минимум одну цифру, заглавную букву, строчную букву и специальный символ из набора!#;%:?*.
            //Запрашивать у пользователя пароль до тех пор, пока он не введет пароль,
            //удовлетворяющий регулярному выражению.

            string passwordPattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!#;%:?*]).{14,}$";
            Regex passwordRegex = new Regex(passwordPattern);

            string password;
            bool isValid;

            do
            {
                Console.WriteLine("Введите пароль (минимум 14 символов, должен содержать цифру, заглавную и строчную буквы, и специальный символ !#;%:?*):");
                password = Console.ReadLine();

                isValid = passwordRegex.IsMatch(password);

                if (!isValid)
                {
                    Console.WriteLine("Пароль не соответствует требованиям. Попробуйте еще раз.");
                }

            } while (!isValid);

            Console.WriteLine("Пароль принят!");
        }
    }
}
