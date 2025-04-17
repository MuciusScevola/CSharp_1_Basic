using System.Text;
namespace Theme06_Task04
{
    internal class Program
    {
        static void Main()
        {
            //Запросите у пользователя имя, возраст и город. Сформируйте строку в формате:
            //"Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append($"Имя: {name}, Возраст: {age}, Город: {city}");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
