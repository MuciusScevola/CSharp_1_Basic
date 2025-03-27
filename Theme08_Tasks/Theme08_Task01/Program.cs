namespace Theme08_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число первое: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите число второе: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                int operation;
                bool validOperation;
                do
                {
                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("1 - сложение.");
                    Console.WriteLine("2 - вычитание.");
                    Console.WriteLine("3 - произведение.");
                    Console.WriteLine("4 - частное.");

                   validOperation = int.TryParse(Console.ReadLine(), out operation);

                    if (!validOperation || operation < 1 || operation > 4)
                    {
                        Console.WriteLine("Ошибка: введите число от 1 до 4!");
                        validOperation = false; // чтобы цикл продолжился
                    }
                } while (!validOperation);
                double result = 0;

                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;
                    case 2:
                        result = num2 - num1;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Введите корректный код операции.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенное значение нечисловое.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
