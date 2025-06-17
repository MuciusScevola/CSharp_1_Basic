namespace Theme12_Task01
{
    class Program
    {
        // Обобщенный класс Book с двумя параметрами типов: T (код) и U (год публикации)
        public class Book<T, U>
        {
            // Свойства класса:
            public T Code { get; set; }          // Уникальный код книги (тип T)
            public string Title { get; set; }    // Название книги
            public U PublicationYear { get; set; } // Год публикации (тип U)
            public string Author { get; set; }   // Автор книги

            // Конструктор класса, принимающий все параметры
            public Book(T code, string title, string author, U publicationYear)
            {
                Code = code;
                Title = title;
                Author = author;
                PublicationYear = publicationYear;
            }

            // Переопределение метода ToString() для красивого вывода информации о книге
            public override string ToString()
            {
                return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
            }
        }

        // Обобщенный метод для поиска книги по коду
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            // Перебираем все книги в массиве
            foreach (var book in books)
            {
                // Если код текущей книги совпадает с искомым кодом
                if (book.Code.Equals(code))
                {
                    return book; // Возвращаем найденную книгу
                }
            }
            return null; // Если книга не найдена, возвращаем null
        }

        static void Main(string[] args)
        {
            // Первый массив книг: Code - string, PublicationYear - int
            Book<string, int>[] libraryBooks = new Book<string, int>[]
            {
            new Book<string, int>("F-1234", "Война и мир", "Лев Толстой", 1869),
            new Book<string, int>("S-5678", "Преступление и наказание", "Федор Достоевский", 1866),
            new Book<string, int>("T-9012", "Анна Каренина", "Лев Толстой", 1877)
            };

            // Второй массив книг: Code - int, PublicationYear - string
            Book<int, string>[] archiveBooks = new Book<int, string>[]
            {
            new Book<int, string>(42, "1984", "Джордж Оруэлл", "XX век"),
            new Book<int, string>(17, "Мастер и Маргарита", "Михаил Булгаков", "XX век"),
            new Book<int, string>(99, "Гарри Поттер", "Джоан Роулинг", "XXI век")
            };

            // Поиск и вывод книги с кодом "F-1234" из первого массива
            var foundBook1 = FindBook(libraryBooks, "F-1234");
            Console.WriteLine("Найдена книга в библиотеке:");
            Console.WriteLine(foundBook1 != null ? foundBook1.ToString() : "Книга не найдена");

            // Поиск и вывод книги с кодом 42 из второго массива
            var foundBook2 = FindBook(archiveBooks, 42);
            Console.WriteLine("\nНайдена книга в архиве:");
            Console.WriteLine(foundBook2 != null ? foundBook2.ToString() : "Книга не найдена");
        }
    }
}