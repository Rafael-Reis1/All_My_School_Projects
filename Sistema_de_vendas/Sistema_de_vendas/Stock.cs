using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            flowPanelStock.MouseWheel += new MouseEventHandler(OnMouseWheel);
            flowPanelStock.Scroll += new ScrollEventHandler(OnScroll);
            flowPanelStock.VerticalScroll.Visible = false;
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            orderByDescending.Clear();
            orderByDescending.Add(true);
            for (int i = 1; i < 4; i++)
            {
                orderByDescending.Add(false);
            }
            FilterAndDrawItens(16);
        }

        public static string nameFilter = "", orderBy = "";
        public static int searchType, openCriarProdutos = 0, currentIndex = 0, quantProdToDraw = 1;
        public static List<dtoProduct> dtoProduct = new List<dtoProduct>();
        public static LinkedList<Products> products = new LinkedList<Products>();
        private static List<bool> orderByDescending = new List<bool>();

        public static void FilterAndDrawItens(int count)
        {            
            if (orderBy == "id")
            {
                OrderByID();
                orderBy = "";
            }
            else if (orderBy == "name")
            {
                OrderByName();
                orderBy = "";
            }
            else if (orderBy == "quant")
            {
                OrderByQuant();
                orderBy = "";
            }
            else if (orderBy == "price")
            {
                OrderByPrice();
                orderBy = "";
            }

            int itemsToLoad = Math.Min(count, dtoProduct.Count() - currentIndex);

            try
            {
                for (int i = currentIndex; i < currentIndex + itemsToLoad; i++)
                {
                    Products productCriar = new Products();
                    productCriar.ID = dtoProduct[i].ID;
                    productCriar.ProductName = dtoProduct[i].ProductName;
                    productCriar.QTDE = dtoProduct[i].QTDE;
                    productCriar.Price = dtoProduct[i].Price;
                    
                    productCriar.Name = dtoProduct[i].ID.ToString();
                    products.AddLast(productCriar);
                    flowPanelStock.Controls.Add(products.Last.Value);

                    if (currentIndex > 16)
                    {
                        flowPanelStock.Controls.RemoveAt(0);
                        RemoveAt(products, 0);
                    }
                }

                currentIndex += itemsToLoad;
            }
            catch { }
        }

        private void LoadPreviousItems(int count)
        {
            if (currentIndex > 17)
            {
                int quant = 17;
                currentIndex -= count;
                if (currentIndex < 0)
                {
                    currentIndex = 0;
                }

                try
                {
                    Products productCriar = new Products();
                    productCriar.ID = dtoProduct[currentIndex - quant].ID;
                    productCriar.ProductName = dtoProduct[currentIndex - quant].ProductName;
                    productCriar.QTDE = dtoProduct[currentIndex - quant].QTDE;
                    productCriar.Price = dtoProduct[currentIndex - quant].Price;
                    RemoveAt(products, flowPanelStock.Controls.Count - 1);
                    flowPanelStock.Controls.RemoveAt(flowPanelStock.Controls.Count - 1);
                    productCriar.Name = dtoProduct[currentIndex - quant].ID.ToString();
                    products.AddFirst(productCriar);
                    flowPanelStock.Controls.Add(products.First.Value);
                    flowPanelStock.Controls.SetChildIndex(products.First.Value, 0);

                }
                catch { }
            }
        }

        public static void RemoveAt<T>(LinkedList<T> lista, int index)
        {
            if (index < 0 || index >= lista.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index fora do intervalo da lista.");
            }

            LinkedListNode<T> current = lista.First;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            lista.Remove(current);
        }

        public static T productIndex<T>(LinkedList<T> lista, int index)
        {
            if (index < 0 || index >= lista.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index fora do intervalo da lista.");
            }

            LinkedListNode<T> current = lista.First;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public static int EncontrarIndice<T>(LinkedList<T> lista, T valor)
        {
            int index = 0;
            foreach (T item in lista)
            {
                if (EqualityComparer<T>.Default.Equals(item, valor))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        private async void tbNameFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                currentIndex = 0;
                quantProdToDraw = 16;
                flowPanelStock.Controls.Clear();
                bllProduct bllProduct = new bllProduct();
                await bllProduct.SearchStrictAsync(tbNameFilter.Text);
                FilterAndDrawItens(quantProdToDraw);
                quantProdToDraw = 1;

                if (tbNameFilter.Text == "")
                {
                    tbNameFilter.ForeColor = Color.FromArgb(100, 114, 114, 114);
                    tbNameFilter.Text = "NAME RESTRICTED";
                    btnADD.Focus();
                }
            }
        }

        private async void tbNameFilterFlex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                currentIndex = 0;
                quantProdToDraw = 16;
                flowPanelStock.Controls.Clear();
                bllProduct bllProduct = new bllProduct();
                await bllProduct.SearchFlexibleAsync(tbNameFilterFlex.Text);
                FilterAndDrawItens(quantProdToDraw);
                quantProdToDraw = 1;

                if (tbNameFilterFlex.Text == "")
                {
                    tbNameFilterFlex.ForeColor = Color.FromArgb(100, 114, 114, 114);
                    tbNameFilterFlex.Text = "NAME FLEXIBLE";
                    btnADD.Focus();
                }
            }
        }

        private void tbNameFilterFlex_Enter(object sender, EventArgs e)
        {
            if (tbNameFilterFlex.Text == "NAME FLEXIBLE")
            {
                tbNameFilterFlex.Text = "";
                tbNameFilterFlex.ForeColor = Color.Black;
                tbNameFilter.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbNameFilter.Text = "NAME RESTRICTED";
            }
        }

        private void tbNameFilterFlex_Leave(object sender, EventArgs e)
        {
            if (tbNameFilterFlex.Text == "")
            {
                tbNameFilterFlex.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbNameFilterFlex.Text = "NAME FLEXIBLE";
            }
        }

        private void tbNameFilter_Enter(object sender, EventArgs e)
        {
            if (tbNameFilter.Text == "NAME RESTRICTED")
            {
                tbNameFilter.Text = "";
                tbNameFilter.ForeColor = Color.Black;
                tbNameFilterFlex.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbNameFilterFlex.Text = "NAME FLEXIBLE";
            }
        }

        private void tbNameFilter_Leave(object sender, EventArgs e)
        {
            if (tbNameFilter.Text == "")
            {
                tbNameFilter.ForeColor = Color.FromArgb(100, 114, 114, 114);
                tbNameFilter.Text = "NAME RESTRICTED";
            }
        }

        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent = null;
            e.Cancel = true;
            this.Hide();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            CadProducts.mode = 0;
            CadProducts cadProducts = new CadProducts();
            cadProducts.Show();
        }

        private void Stock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            orderBy = "id";
            currentIndex = 0;
            quantProdToDraw = 16;
            flowPanelStock.Controls.Clear();
            products.Clear();
            FilterAndDrawItens(quantProdToDraw);
            quantProdToDraw = 1;
        }

        private static void OrderByID()
        {
            if (orderByDescending[0])
            {
                dtoProduct = dtoProduct.OrderByDescending(w => w.ID).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = false;
                orderByDescending[2] = false;
                orderByDescending[3] = false;

            }
            else
            {
                dtoProduct = dtoProduct.OrderBy(w => w.ID).ToList();
                orderByDescending[0] = true;
                orderByDescending[1] = false;
                orderByDescending[2] = false;
                orderByDescending[3] = false;
            }
        }

        private void btnProductName_Click(object sender, EventArgs e)
        {
            orderBy = "name";
            currentIndex = 0;
            quantProdToDraw = 16;
            products.Clear();
            flowPanelStock.Controls.Clear();
            FilterAndDrawItens(quantProdToDraw);
            quantProdToDraw = 1;
        }

        private static void OrderByName()
        {
            if (orderByDescending[1])
            {
                dtoProduct = dtoProduct.OrderByDescending(w => w.ProductName).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = false;
                orderByDescending[2] = false;
                orderByDescending[3] = false;
            }
            else
            {
                dtoProduct = dtoProduct.OrderBy(w => w.ProductName).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = true;
                orderByDescending[2] = false;
                orderByDescending[3] = false;
            }
        }

        private void btnQuant_Click(object sender, EventArgs e)
        {
            orderBy = "quant";
            currentIndex = 0;
            quantProdToDraw = 16;
            products.Clear();
            flowPanelStock.Controls.Clear();
            FilterAndDrawItens(quantProdToDraw);
            quantProdToDraw = 1;
        }

        private static void OrderByQuant()
        {
            if (orderByDescending[2])
            {
                dtoProduct = dtoProduct.OrderByDescending(w => w.QTDE).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = false;
                orderByDescending[2] = false;
                orderByDescending[3] = false;
            }
            else
            {
                dtoProduct = dtoProduct.OrderBy(w => w.QTDE).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = false;
                orderByDescending[2] = true;
                orderByDescending[3] = false;
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            orderBy = "price";
            currentIndex = 0;
            quantProdToDraw = 16;
            products.Clear();
            flowPanelStock.Controls.Clear();
            FilterAndDrawItens(quantProdToDraw);
            quantProdToDraw = 1;
        }

        private static void OrderByPrice()
        {
            if (orderByDescending[3])
            {
                dtoProduct = dtoProduct.OrderByDescending(w => w.Price).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = false;
                orderByDescending[2] = false;
                orderByDescending[3] = false;
            }
            else
            {
                dtoProduct = dtoProduct.OrderBy(w => w.Price).ToList();
                orderByDescending[0] = false;
                orderByDescending[1] = false;
                orderByDescending[2] = false;
                orderByDescending[3] = true;
            }
        }

        private void tbNameFilter_TextChanged(object sender, EventArgs e)
        {
            if (tbNameFilter.Text == "")
            {
                nameFilter = tbNameFilter.Text;
            }
        }

        private void tbNameFilterFlex_TextChanged(object sender, EventArgs e)
        {
            if (tbNameFilter.Text == "")
            {
                nameFilter = tbNameFilter.Text;
            }
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {            
            var maxScroll = flowPanelStock.VerticalScroll.Maximum - flowPanelStock.ClientSize.Height;
            var PercentScroll = (int)(maxScroll * 1);
            if (flowPanelStock.VerticalScroll.Value >= PercentScroll)
            {
                FilterAndDrawItens(quantProdToDraw);
            }
            else if (flowPanelStock.VerticalScroll.Value == 0)
            {
                LoadPreviousItems(quantProdToDraw);
            }
        }

        private void OnScroll(object sender, ScrollEventArgs e)
        {
            var maxScroll = flowPanelStock.VerticalScroll.Maximum - flowPanelStock.ClientSize.Height;
            var PercentScroll = (int)(maxScroll * 1);
            if (flowPanelStock.VerticalScroll.Value >= PercentScroll)
            {
                FilterAndDrawItens(quantProdToDraw);
            }
            else if (flowPanelStock.VerticalScroll.Value == 0)
            {
                LoadPreviousItems(quantProdToDraw);
            }
        }
    }
}
