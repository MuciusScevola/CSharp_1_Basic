namespace Theme10_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте базовый класс Building(описывает здание) со следующими характеристиками:

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }
        public class Building
        {
            string _address;
            double _area;
            int _yearBuilt;

            public Building(string address, double area, int yearBuilt)
            {
                _address = address;
                _area = area;
                _yearBuilt = yearBuilt;
            }
            public virtual decimal CalculateTax()
            {
                tax = area * 1000;
                return tax;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine();
            }
        }
    }
}
