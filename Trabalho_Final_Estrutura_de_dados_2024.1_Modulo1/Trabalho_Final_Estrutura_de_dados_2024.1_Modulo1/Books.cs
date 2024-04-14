using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_Estrutura_de_dados_2024._1_Modulo1
{
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            lblBookTitle.Parent = btnBooks;
            lblBookTitle.BackColor = Color.Transparent;
            lblAuthorName.Parent = btnBooks;
            lblAuthorName.BackColor = Color.Transparent;
            lblID.Parent = btnBooks;
            lblID.BackColor = Color.Transparent;
            lblPubDate.Parent = btnBooks;
            lblPubDate.BackColor = Color.Transparent;
        }

        private int _index;
        public static int index;

        private void btnBooks_Click(object sender, EventArgs e)
        {
            index = _index;
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblBookTitle_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.Gray;
        }

        private void lblBookTitle_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Gainsboro;
        }

        private void lblBookTitle_Click(object sender, EventArgs e)
        {
            index = _index;
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblAuthorName_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.Gray;
        }

        private void lblAuthorName_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Gainsboro;
        }

        private void lblAuthorName_Click(object sender, EventArgs e)
        {
            index = _index;
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblID_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.Gray;
        }

        private void lblID_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Gainsboro;
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            index = _index;
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        private void lblPubDate_MouseMove(object sender, MouseEventArgs e)
        {
            btnBooks.BackColor = Color.Gray;
        }

        private void lblPubDate_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Gainsboro;
        }

        private void lblPubDate_Click(object sender, EventArgs e)
        {
            index = _index;
            Main.openEdit = 1;
            CadBooks books = new CadBooks();
            books.Show();
        }

        public string BookTitle
        {
            set { lblBookTitle.Text = value; }
        }

        public string AuthorName
        {
            set { lblAuthorName.Text = value; }
        }

        public int ID
        {
            set { lblID.Text = value.ToString(); }
        }

        public DateTime PubDate
        {
            set { lblPubDate.Text = value.ToString(); }
        }

        public int Index
        {
            set { _index = value; }
        }
    }
}
