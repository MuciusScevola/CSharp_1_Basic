namespace Theme08_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
            < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
            > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").
             */
            try
            {
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine($"Введен корректный возраст: {age}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("ОШИБКА: Введено не число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
        public static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным.");

            if (age > 150)
                throw new ArgumentOutOfRangeException("Слишком большой возраст.");

        }

    }
}

