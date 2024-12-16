using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas
{
    public partial class Sale : UserControl
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            lblID.Parent = btnSale;
            lblID.BackColor = Color.Transparent;
            lblName.Parent = btnSale;
            lblName.BackColor = Color.Transparent;
            lblTotal.Parent = btnSale;
            lblTotal.BackColor = Color.Transparent;
            lblDateSale.Parent = btnSale;
            lblDateSale.BackColor = Color.Transparent;
        }

        private string _costumername;
        public static int index;

        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                index = Sales.costumerSales.FindIndex(sale => sale.ID == Convert.ToInt32(lblID.Text));
                //CadSales.mode = 1;
                //CadSales cadSales = new CadSales();
                //cadSales.Show();
            }
            catch { }
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            try
            {
                index = Sales.costumerSales.FindIndex(sale => sale.ID == Convert.ToInt32(lblID.Text));
                //CadSales.mode = 1;
                //CadSales cadSales = new CadSales();
                //cadSales.Show();
            }
            catch { }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            try
            {
                index = Sales.costumerSales.FindIndex(sale => sale.ID == Convert.ToInt32(lblID.Text));
                //CadSales.mode = 1;
                //CadSales cadSales = new CadSales();
                //cadSales.Show();
            }
            catch { }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            try
            {
                index = Sales.costumerSales.FindIndex(sale => sale.ID == Convert.ToInt32(lblID.Text));
                //CadSales.mode = 1;
                //CadSales cadSales = new CadSales();
                //cadSales.Show();
            }
            catch { }
        }

        private void lblDateSale_Click(object sender, EventArgs e)
        {
            try
            {
                index = Sales.costumerSales.FindIndex(sale => sale.ID == Convert.ToInt32(lblID.Text));
                //CadSales cadSales = new CadSales();
                //cadSales.Show();
            }
            catch { }
        }

        private void lblID_MouseLeave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.Transparent;
        }

        private void lblID_MouseMove(object sender, MouseEventArgs e)
        {
            btnSale.BackColor = Color.DimGray;
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.Transparent;
        }

        private void lblName_MouseMove(object sender, MouseEventArgs e)
        {
            btnSale.BackColor = Color.DimGray;
        }

        private void lblTotal_MouseLeave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.Transparent;
        }

        private void lblTotal_MouseMove(object sender, MouseEventArgs e)
        {
            btnSale.BackColor = Color.DimGray;
        }

        private void lblDateSale_MouseLeave(object sender, EventArgs e)
        {
            btnSale.BackColor = Color.Transparent;
        }

        private void lblDateSale_MouseMove(object sender, MouseEventArgs e)
        {
            btnSale.BackColor = Color.DimGray;
        }

        public int ID
        {
            set { lblID.Text = value.ToString(); }
        }

        public string CostumerName
        {
            set { lblName.Text = value; }
        }

        public float Total
        {
            set
            { lblTotal.Text = "$ " + value.ToString(); }
        }

        public DateTime saleDate
        {
            set { lblDateSale.Text = value.ToString("dd/MM/yyyy"); }
        }
    }
}
