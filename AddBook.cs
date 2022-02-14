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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
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
            Book item = new Book(bookName, authorName, publisherName, price, genre, year, quant);
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            frm1.addItem(item);
        }

    }
}
