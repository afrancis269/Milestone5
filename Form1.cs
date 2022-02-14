using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Milestone4
{
    
    public partial class Form1 : Form
    {
        Warehouse BookList = new Warehouse();
        Book first_book = new Book("FirstBook", "FirstAuthor", "FirstPublisher", 100, "FirstGenre", 2021, 1);
        Book second_book = new Book("SecondBook", "SecondAuthor", "SecondPublisher", 200, "SecondGenre", 2022, 2);
        Book third_book = new Book("ThirdBook", "ThirdAuthor", "ThirdPublisher", 300, "ThirdGenre", 2020, 3);
        
       
        public Form1()
        {
            InitializeComponent();
            BookList.addBook(first_book);
            BookList.addBook(second_book);
            BookList.addBook(third_book);
            DisplayBooks(BookList);
        }

        public Form1(Book item)
        {
            InitializeComponent();
            BookList.addBook(item);
            DisplayBooks(BookList);
        }

        public void DisplayBooks(Warehouse List)
        {
            BooksLbx.Items.Clear();   
            foreach (Book book in List.Books)
            {
                BooksLbx.Items.Add(book.BookName + " - " + book.AuthorName + " - " + book.Publisher + " - " + book.Price.ToString() + " - " + book.Genre + " - " + book.YearOfPublish + " - " + book.Quant.ToString());
            }
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BooksLbx.SelectedIndex != -1)
            {
                BookList.removeBook(BooksLbx.SelectedIndex);
                DisplayBooks(BookList);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BooksLbx.SelectedIndex != -1)
            {
                Book book = BookList.Books[BooksLbx.SelectedIndex];
                int quant = Int32.Parse(Interaction.InputBox("Input quantity: "));
                BookList.restockBook(book, quant);
                DisplayBooks(BookList);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook frm2 = new AddBook();
            frm2.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nameBook = Interaction.InputBox("Input book name: ");
            string nameGenre = Interaction.InputBox("Input genre: ");
            Book book = BookList.findBook(nameBook, nameGenre);
            MessageBox.Show(book.BookName + " - " + book.AuthorName + " - " + book.Publisher + " - " + book.Price.ToString() + " - " + book.Genre + " - " + book.YearOfPublish + " - " + book.Quant.ToString());

        }

        public void addItem(Book itemBook)
        {
            BookList.addBook(itemBook);
            DisplayBooks(BookList);

        }
        public void changeItem(Book itemBook)
        {
            BookList.addBook(itemBook);
            DisplayBooks(BookList);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            if (BooksLbx.SelectedIndex != -1)
            {
                Book itemBook = BookList.Books[BooksLbx.SelectedIndex];
                BookList.removeBook(BooksLbx.SelectedIndex);
                EditBook frm3 = new EditBook(itemBook);
                frm3.ShowDialog();
            }
            
        }
    }
}
