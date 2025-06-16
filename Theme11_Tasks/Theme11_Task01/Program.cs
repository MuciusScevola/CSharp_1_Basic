using System.Threading.Channels;

namespace Theme11_Task01
{
    public abstract class Animal
    {
        public abstract string Name { get; }

        public abstract string Say();

        public string ShowInfo()
        {
            return $"{Name} издает звук {Say()}";
        }
    }
    public class Dog : Animal
    {
        public override string Name => "Собака";

        public override string Say()
        {
            return "Гав!";
        }
    }

    public class Cat : Animal
    {
        public override string Name => "Кошка";

        public override string Say()
        {
            return "Мяу!";
        }
    }
    class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
            new Dog(),
            new Cat(),
            new Dog(),
            new Cat()
            };
            foreach (var animal in animals)
                Console.WriteLine(animal.ShowInfo());

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
