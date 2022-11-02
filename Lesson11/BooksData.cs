using System;

namespace Lesson11
{
    public class BooksData
    {
        public static Book BookDataFunc(int id)
        {
            Book book1 = new Lesson11.Book
            {
                ID = 1,
                Author = "Patrick King",
                Year = 2017,
                BookName = "Communication strategies and tactics",
                Genre = "Psyhosogy"
            };

            Book book2 = new Lesson11.Book
            {
                ID = 2,
                Author = "Stiven King",
                Year = 1977,
                BookName = "The shining",
                Genre = "Fiction"
            };

            Book book3 = new Lesson11.Book
            {
                ID = 3,
                Author = "Stiven King",
                Year = 1986,
                BookName = "It",
                Genre = "Fiction"
            };

            if (id < book1.ID) id = 1;
            else if (id > book3.ID) id = 3;
            
            if (book1.ID == id) return book1;
            else if (book2.ID == id) return book2;
            else if (book3.ID == id) return book3;
            else
            {
                Console.WriteLine("Error, wrong id");
                return null;
            }

        }

        /// <summary>
        /// Видає інформацію про книги в BooksData
        /// </summary>
        public static void BooksShow()
        {
            for (int i = 1; i <= 3; i++)
                Console.WriteLine($"Book's name {i}: {BookDataFunc(i).BookName}," +
                                  $" Author: {BookDataFunc(i).Author}, " +
                                  $"Year: {BookDataFunc(i).Year}");
        }



    }
}
