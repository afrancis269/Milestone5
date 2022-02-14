using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4
{
    public class Book
    {
        private string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string authorName;

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private int yearOfPublish;
        public int YearOfPublish
        {
            get { return yearOfPublish; }
            set { yearOfPublish = value; }
        }
        private int quant;

        public int Quant
        {
            get { return quant; }
            set { quant = value; }
        }

        public Book(string bookName, string authorName, string publisher, double price, string genre, int year, int quant)
        {
            this.BookName = bookName;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.Publisher = publisher;
            this.Price = price;
            this.YearOfPublish = year;
            this.Quant = quant;
        }



        public void changeBookName(string newName)
        {
            BookName = newName;
        }
        public void changeAuthorName(string newName)
        {
            AuthorName = newName;
        }
        public void changePublisher(string newName)
        {
            Publisher = newName;
        }
        public void changePrice(double newPrice)
        {
            Price = newPrice;
        }
        public void changeGenre(string newGenre)
        {
            Genre = newGenre;
        }
        public void changeYear(int newYear)
        {
            YearOfPublish = newYear;
        }

        public void changeQuant(int newquant)
        {
            Quant = newquant;
        }
    }

    public class Warehouse
    {
        public List<Book> Books = new List<Book>();

        public void addBook(Book book)
        {
            this.Books.Add(book);
        }

        public void removeBook(int index)
        {
            this.Books.RemoveAt(index);
        }


        public void restockBook(Book book, int quant)
        {
            if (book.Quant == 0)
            {

                book.changeQuant(quant);
            }
            
        }
        // find book by book name, and gerne
        public Book findBook(string nameBook, string nameGerne)
        {
            Book res = null;
            foreach (Book book in this.Books)
            {
                if (book.BookName == nameBook && book.Genre == nameGerne)
                {
                    res = book; break;
                }

            }
            return res;
        }
    }
}
