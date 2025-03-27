namespace Theme08_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                AgeValidator.ValidateAge(age);
                Console.WriteLine($"Введённый возраст корректен: {age} лет");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено нечисловое значение.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

        public class AgeValidator
        {
            public static void ValidateAge(int age)
            {
                if (age < 0)
                {
                    throw new ArgumentException("Возраст не может быть отрицательным");
                }

                if (age > 150)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), "Слишком большой возраст");
                }
            }
        }   
    }
}

