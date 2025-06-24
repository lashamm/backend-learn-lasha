using backend1.Enums;

namespace backend1.Mocdels
{
    internal class Book
    {
        private int _quantity;
        public string Title { get; set; }
        public string Author { get; init; }
        public string ISBN { get; init; }
        public Genre Genre { get; init; }
        public DateTime ReleaseDate { get; init; }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _quantity = value;
                }
            }
        }
    

    public Book() { }

        public Book(
            string title,
            string author,
            string isbn,
            Genre genre,
            DateTime releasedate,
            int quantity
            )
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            ReleaseDate = releasedate;
            Quantity = quantity;
        }

        public void PrintBook()
        {
            Console.WriteLine($"Book title: {Title}, " +
                $"\nBook author: {Author}," +
                $"\nBook isbn: {ISBN}" +
                $"\nBook genre: {Genre}" +
                $"\nBook release date: {ReleaseDate}" +
                $"\nBook quantity {Quantity}");
        }
    } 
}
