namespace Theme11_Task01_2
{
    public abstract class Animal
    {
        public abstract string Name { get; }

        private string _nickname; // Добавил поле клички для различения конкретного животного.

        public string Nickname // Свойство для доступа к кличке.
        {
            get => _nickname;
            set => _nickname = value;
        }

        public Animal(string nickname) // Конструктор для установки клички.
        {
            _nickname = nickname;
        }

        public abstract string Say();

        public string ShowInfo() // Модифицированный метод ShowInfo() с включением клички.
        {
            return $"{Name} по кличке {Nickname} произносит {Say()}.";
        }
    }
    public class Dog : Animal
    {
        public override string Name => "Собака";

        public Dog(string nickname) : base(nickname) { } // Конструктор передает кличку в базовый класс.

        public override string Say()
        {
            return "Гав!";
        }
    }

    public class Cat : Animal
    {
        public override string Name => "Кошка";

        public Cat(string nickname) : base(nickname) { } // Конструктор передает кличку в базовый класс.

        public override string Say()
        {
            return "Мяу!";
        }
    }
    class Program
    {
        static void Main()
        {

           // Создаем массив, содержащий объекты обоих типов с кличками.
           Animal[] animals = new Animal[]
           {
            new Dog("Бобик"),
            new Cat("Мурка"),
            new Dog("Рекс"),
            new Cat("Васька")
           };

            foreach (var animal in animals)
                Console.WriteLine(animal.ShowInfo());

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
