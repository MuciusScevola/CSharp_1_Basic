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
            string month = "Май";
            int year = 2023;
            decimal totalSales = 1234567.89m;
            int itemsSold = 42;

            // Вычисления
            decimal averagePrice = totalSales / itemsSold;

            // Форматирование данных
            string formattedTotalSales = totalSales.ToString("N2");
            string formattedAveragePrice = Math.Round(averagePrice, 2).ToString("0.00");

            // Создание отчёта
            string reportTitle = $"Отчёт о продажах за {month} {year}";
            string salesInfo = $"Общая сумма продаж: {formattedTotalSales}";
            string itemsInfo = $"Количество проданных товаров: {itemsSold}";
            string averageInfo = $"Средняя стоимость одного товара: {formattedAveragePrice}";

            // Вывод отчёта
            Console.WriteLine(reportTitle);
            Console.WriteLine(salesInfo);
            Console.WriteLine(itemsInfo);
            Console.WriteLine(averageInfo);
        }
    }
}
    }
}
