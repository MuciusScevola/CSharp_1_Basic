namespace Theme07_Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Напишите перегруженные методы Multiply,
             * которые могут умножать два числа (целые или дробные) и возвращать результат.
            */
            
            Console.WriteLine("Hello, World!");
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
