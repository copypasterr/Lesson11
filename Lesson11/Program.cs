using System;

namespace Lesson11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input book id:");
            Book BookData = BooksData.BookDataFunc(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(BookData.BookName);

            Console.WriteLine("Input visitor id:");
            Visitor PersonalData = VisitorsData.VisitorsDataFunc(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(PersonalData.Fullname);

            Console.WriteLine("Input '1' Show all books data, '2' if show visitors data");
            switch (Console.ReadLine())
            {
                case "1":
                    BooksData.BooksShow();
                    break;
                case "2":
                    VisitorsData.VisitorsShow();
                    break;
                default:
                    Console.WriteLine("Wrong data");
                    break;
            }
        }
    }
}
