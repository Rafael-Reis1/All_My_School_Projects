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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            //CriarSales();
            FilterAndDrawSales();
        }

        int openCriarVendas = 0;

        private void CriarSales()
        {
            if (openCriarVendas == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    costumerSales.Add(new CostumerSales());
                    costumerSales[i].ID = i + 1;
                    costumerSales[i].costumerName = $"Costumer {i + 1}";
                    costumerSales[i].saleTotal = i + 100;
                    costumerSales[i].saleDate = DateTime.Today;
                }
                openCriarVendas = 1;
            }
        }

        public static List<CostumerSales> costumerSales = new List<CostumerSales>();
        public static List<Sale> sale = new List<Sale>();


        public static void FilterAndDrawSales()
        {
            flowPanelSales.Controls.Clear();

            int count = 0;

            for (int i = 0; i < costumerSales.Count(); i++)
            {
                sale.Add(new Sale());
                sale[i].ID = costumerSales[i].ID;
                sale[i].CostumerName = costumerSales[i].costumerName;
                sale[i].Total = costumerSales[i].saleTotal;
                sale[i].saleDate = costumerSales[i].saleDate;

                if ((count % 2) == 0)
                {
                    sale[i].BackColor = Color.DarkCyan;
                }
                else
                {
                    sale[i].BackColor = Color.LightSeaGreen;
                }

                count++;

                flowPanelSales.Controls.Add(sale[i]);

            }
        }



        private void tbClienteFilterFlex_Enter(object sender, EventArgs e)
        {
            if (tbClienteFilterFlex.Text == "NAME FLEXIBLE")
            {
                tbClienteFilterFlex.Text = "";
                tbClienteFilterFlex.ForeColor = Color.Black;
                tbClienteFilterRestricted.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbClienteFilterRestricted.Text = "NAME RESTRICTED";
            }
        }

        private void tbClienteFilterFlex_Leave(object sender, EventArgs e)
        {
            if (tbClienteFilterFlex.Text == "")
            {
                tbClienteFilterFlex.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbClienteFilterFlex.Text = "NAME FLEXIBLE";
            }
        }

        private void tbClienteFilterRestricted_Enter(object sender, EventArgs e)
        {
            if (tbClienteFilterRestricted.Text == "NAME RESTRICTED")
            {
                tbClienteFilterRestricted.Text = "";
                tbClienteFilterRestricted.ForeColor = Color.Black;
                tbClienteFilterFlex.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbClienteFilterFlex.Text = "NAME FLEXIBLE";
            }
        }

        private void tbClienteFilterRestricted_Leave(object sender, EventArgs e)
        {
            if (tbClienteFilterRestricted.Text == "")
            {
                tbClienteFilterRestricted.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbClienteFilterRestricted.Text = "NAME RESTRICTED";
            }
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent = null;
            e.Cancel = true;
            this.Hide();
        }

        private void Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }

    public class CostumerSales
    {
        public int ID;
        public string costumerName;
        public float saleTotal;
        public DateTime saleDate;
    }
}