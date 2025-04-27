namespace Theme09_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать класс Book, который содержит:
            //Поля: 
            //_title (название книги, private)        
            //_author (автор, private)
            //Автосвойства:
            //Year (год издания, public геттер, public сеттер)
            //Pages (количество страниц, public геттер, public сеттер)
            //Конструктор:
            //Инициализирует все поля и свойства
            //Метод:
            //GetInfo() – возвращает строку с информацией о книге (например: "Война и мир, Л. Толстой, 1869, 1225 стр.")
            var book = new Book("Война и мир", "Л. Толстой", 1869, 1225);
            Console.WriteLine(book);

            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
        }

    }


    public class Book
    {
        // Поля.
        private string _title;
        private string _author;

        // Автосвойства.
        public int Year { get; set; }
        public int Pages { get; set; }

        // Конструктор.
        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }


        public string GetInfo()
        {
            return $"{_title}, {_author}, {Year}, {Pages} стр.";
        }

    }
}
