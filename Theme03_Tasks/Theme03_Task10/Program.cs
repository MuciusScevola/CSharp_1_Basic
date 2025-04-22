namespace Theme03_Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Застройщик построил n домов. Вывести фразу «Мы построили n домов»,
            // обеспечив правильное согласование числа со словом «дом».
            Console.Write("Введите количество построенных домов: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int digitLast = number % 10;
            int digitsTwoLast = number % 100;

            if (digitsTwoLast >= 11 && digitsTwoLast <= 14)
            {
                Console.WriteLine($"Мы построили {number} домов.");
            }
            else
            {
                switch (digitLast)
                {
                    case 1:
                        Console.WriteLine($"Мы построили {number} дом.");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine($"Мы построили {number} дома.");
                        break;
                    default:
                        Console.WriteLine($"Мы построили {number} домов.");
                        break;
                }
            }
            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}

