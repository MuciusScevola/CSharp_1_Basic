using System.Text.RegularExpressions;

namespace Theme06_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности номера телефона.
            //Корректный номер имеет формат +7(123)456-78-90.
            Regex pattern = new Regex(@"^\+\d\(\d{3}\)\d{3}-\d{2}-\d{2}$");
            string[] phoneNumbers =
                {
                "+7(123)456-78-90",
                "(921)1253453",
                "123456789",
                "1234567890",
                "(01)2345678",
                "+34(234)1234567",
                "+7(911)123-12-33"
            };

            foreach (string number in phoneNumbers)
            {
                if (pattern.IsMatch(number))
                    Console.WriteLine($"\"{number}\" - корректный номер.");

                else
                    Console.WriteLine($"\"{number}\" - некорректный номер.");
            }
            
            /*
            Console.Write("Введите номер телефона (в формате +0(000)000-00-00: ");
            var phone = Console.ReadLine();

            if (pattern.IsMatch(phone))
                Console.WriteLine("Номер телефона корректный.");
            else
                Console.WriteLine("Номер телефона некорректный.");
            */

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
