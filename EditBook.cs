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
    public partial class EditBook : Form
    {
        public EditBook(Book itemBook)
        {
            InitializeComponent();
            this.BookNameTxb.Text = itemBook.BookName;
            this.AuthorNameTxb.Text = itemBook.AuthorName;
            this.PublisherNameTxb.Text = itemBook.Publisher;
            this.PriceTxb.Text = itemBook.Price.ToString();
            this.GenreTxb.Text = itemBook.Genre;
            this.YearTxb.Text = itemBook.YearOfPublish.ToString();
            this.QuantTxb.Text = itemBook.Quant.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookName = BookNameTxb.Text;
            string authorName = AuthorNameTxb.Text;
            string publisherName = PublisherNameTxb.Text;
            double price = double.Parse(PriceTxb.Text);
            string genre = GenreTxb.Text;
            int year = Int32.Parse(YearTxb.Text);
            int quant = Int32.Parse(QuantTxb.Text);
            Book itemBook = new Book(bookName, authorName, publisherName, price, genre, year, quant);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.changeItem(itemBook);
        }
    }
}
