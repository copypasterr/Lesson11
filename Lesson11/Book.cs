namespace Lesson11
{
    public class Book
    {
        public int ID { get; set; }

        public string Author { get; set; }

        public string BookName { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }

        public Book() { }

        public Book(int id,string author, string bookName, string genre, int year)
        {
            ID = id;
            Author = author;
            BookName = bookName;
            Genre = genre;
            Year = year;
        }
    }
}
