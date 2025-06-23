// Разработайте программу для управления складом магазина электроники, используя коллекцию Dictionary<string, int>, где:
//  Ключ — артикул товара(например, "A001");
//  Значение — количество единиц товара на складе.
// Требования:
//   Создайте словарь и добавьте в него 3 товара:
//    Ноутбуки("A001") — 10 шт.;
//    Смартфоны("B205") — 25 шт.;
//    Наушники("C307") — 15 шт..
//   Реализуйте следующие операции:
//    Проверьте наличие товара с артикулом "B205" (ContainsKey).
//    Обновите количество ноутбуков до 8 (продали 2 шт.) через индексатор.
//    Получите количество наушников безопасным способом (TryGetValue).
//    Увеличьте количество смартфонов на 5 (новый завоз).
//    Удалите наушники из инвентаря (Remove).
//   Выведите текущий инвентарь в формате:
//    Артикул: A001, Количество: 8.
//    Артикул: B205, Количество: 30.
//   Проверьте, пуст ли словарь (Count), затем полностью очистите инвентарь (Clear).

namespace Theme14_Task02
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int>storeroom = new Dictionary<string, int>();

            storeroom.Add("A001", 10);
            storeroom.Add("B205", 25);
            storeroom.Add("C307", 15);

            bool is_B205 = storeroom.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом \"B205\"? => {is_B205}.");

            storeroom["A001"] = 8;

            if (storeroom.TryGetValue("C307", out int earphonesCount))
                Console.WriteLine($"\nКоличество наушников: {earphonesCount}.");

            storeroom.Remove("C307");

            Console.WriteLine("\nТекущие товары:");
            foreach (KeyValuePair<string, int> item in storeroom)
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}.");

            Console.WriteLine($"\nСписок пуст? => {storeroom.Count == 0}.");

            storeroom.Clear();
            Console.WriteLine($"\nКоличество товаров после очистки: {storeroom.Count}.");


            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
