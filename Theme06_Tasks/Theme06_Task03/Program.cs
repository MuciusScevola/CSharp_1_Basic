namespace Theme06_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Нужно создать отчёт, который будет содержать информацию о продажах за определённый период. Отчёт должен быть отформатирован следующим образом:
            //Название отчёта: "Отчёт о продажах за [месяц] [год]".
            //Информация о продажах:
            //Общая сумма продаж.
            //Количество проданных товаров.
            //Средняя стоимость одного товара.
            //Общая сумма продаж должна быть отформатирована как денежная величина (с разделителями тысяч и двумя знаками после запятой).
            //Средняя стоимость товара должна быть округлена до двух знаков после запятой.

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.Write("Отчётный месяц: ");
            //string month = Console.ReadLine();
            //Console.Write("Отчётный год: ");
            //string year = Console.ReadLine();
            //Console.Write("Общая сумма продаж: ");
            //decimal sales = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Количество проданных товаров: ");
            //int units = Convert.ToInt32(Console.ReadLine());

            string month = "Май";
            string year = "2023";
            decimal sales = 1234567.89M;
            int units = 1050;

            decimal averagePrice = Math.Round(sales / units, 2);
            
            string frame = new String('-', 15);

            Console.WriteLine(frame);
            Console.WriteLine($"Отчёт о продажах за {month} {year}");
            Console.WriteLine(frame);
            Console.WriteLine($"Общая сумма продаж: {sales:C2}");
            Console.WriteLine($"Количество проданных товаров: {units:N0} шт.");
            Console.WriteLine($"Средняя стоимость одного товара: {averagePrice:0.00} ₽");
            Console.WriteLine(frame);

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
 
