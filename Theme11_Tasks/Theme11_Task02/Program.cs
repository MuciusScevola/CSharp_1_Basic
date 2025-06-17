namespace Theme11_Task02
{
    public interface IFlyable
    {
        void Fly();

        int MaxAltitude { get; }
    }
    public class Bird : IFlyable
    {
        public int MaxAltitude { get; }
        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров.");
        }
    }
    public class Airplane : IFlyable
    {
        public int MaxAltitude { get; }
        public int CountPassengers { get; }

        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров.");
        }
    }
    class Program
    {
        static void Main()
        {
            IFlyable[] flyingObjects = new IFlyable[]
            {
                        new Bird(maxAltitude: 890),
                        new Airplane(maxAltitude: 9140, countPassengers: 215),
                        new Bird(maxAltitude: 300),
                        new Airplane(maxAltitude: 4570, countPassengers: 80)
            };
            foreach (var flyingObject in flyingObjects)
                flyingObject.Fly();

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
}
