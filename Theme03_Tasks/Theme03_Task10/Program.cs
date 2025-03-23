namespace Theme03_Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}

