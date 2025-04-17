using System.Text.RegularExpressions;

namespace Theme06_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности номера телефона.
            //Корректный номер имеет формат +7(123)456-78-90.
            string pattern = @"^\+7\(\d{3}\)\d{3}-\d{2}-\d{2}$";
            string phone = "+7(123)456-78-90";

            if (Regex.IsMatch(phone, pattern))
            {
                Console.WriteLine("Номер телефона корректный");
            }
            else
            {
                Console.WriteLine("Номер телефона некорректный");
            }
        }
    }
}
