using System.Text;

namespace Theme12_Task01
{

    public class Book<T, U>
    {
        public T Code { get; set; }
        public string Title { get; set; }
        public U PublicationYear { get; set; }
        public string Author { get; set; }
        public Book(T code, string title, string author, U publicationYear)
        {
            Code = code;
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: \"{Title}\", Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }

    }
    class Program
    {
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                { return book; }
            }
            return null;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Массив книг с Code - string, PublicationYear - int.
            Book<string, int>[] booksA = new Book<string, int>[]
            {
                new Book<string, int>("B-1233", "La Reine Margot", "Alexandre Dumas", 1845),
                new Book<string, int>("F-1234", "Хобіт, або вандроўка туды і назад", "Джон Р. Р. Толкін", 2002),
                new Book<string, int>("D-5678", "Paradise Lost", "John Milton", 1667),
                new Book<string, int>("C-9012", "Глибинний шлях", "Микола Трублаїні", 1956)
            };

            // Массив книг с Code - int, PublicationYear - string.
            Book<int, string>[] booksB = new Book<int, string>[]
            {
                new Book<int, string>(99, "Les Enfants du capitaine Grant", "Jules Verne", "XIX век"),
                new Book<int, string>(20, "Хроники тестировщика", "Юрий Бригадир", "XX век"),
                new Book<int, string>(112, "Utopia", "Thomas More", "XVI век"),
                new Book<int, string>(42, "Српске народне пjесме", "Вук Стефановић Караџић", "XIX век")
            };

            // Вывод массивов.
            Console.WriteLine("Массив книг с Code - string, PublicationYear - int:");
            foreach (var book in booksA)
            { Console.WriteLine(book); }

            Console.WriteLine("\nМассив книг с Code - int, PublicationYear - string:");
            foreach (var book in booksB)
            { Console.WriteLine(book); }

            Console.WriteLine();

            // Поиск и вывод книги с кодом "F-1234" из первого массива.
            var foundBook1 = FindBook(booksA, "F-1234");
            Console.WriteLine("Найдена книга в массиве A:");
            Console.WriteLine(foundBook1 != null ? foundBook1.ToString() : "Книга не найдена");

            // Поиск и вывод книги с кодом 42 из второго массива.
            var foundBook2 = FindBook(booksB, 42);
            Console.WriteLine("\nНайдена книга в массиве B:");
            Console.WriteLine(foundBook2 != null ? foundBook2.ToString() : "Книга не найдена");

            Console.WriteLine("\nНажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}