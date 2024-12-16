using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas
{
    public partial class CadProducts : Form
    {
        private int indexCad, indexProd;

        public CadProducts()
        {
            InitializeComponent();
            if (mode == 1)
            {
                indexCad = Products.indexCad;
                indexProd = Products.indexProd;
                tbPrice.Text = Stock.dtoProduct[indexCad].Price.ToString();
                tbQuant.Text = Stock.dtoProduct[indexCad].QTDE.ToString();
                tbName.Text = Stock.dtoProduct[indexCad].ProductName;
            }
            else if (mode == 0)
            {
                btnDelete.Hide();
            }
        }

        public static int mode = 0;
        public static int quantProds = 1;
        bllProduct bllProduct = new bllProduct();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure?", "Delete product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (delete == DialogResult.OK)
            {
                bllProduct.DeletarAsync(Stock.dtoProduct[indexCad]);
                Stock.dtoProduct.RemoveAt(indexCad);

                tbName.Text = "";
                tbQuant.Text = "";
                tbPrice.Text = "";

                try
                {
                    if (Stock.currentIndex > 15)
                    {
                        int i = Stock.currentIndex - 1;
                        Products productCriar = new Products();
                        productCriar.ID = Stock.dtoProduct[i].ID;
                        productCriar.ProductName = Stock.dtoProduct[i].ProductName;
                        productCriar.QTDE = Stock.dtoProduct[i].QTDE;
                        productCriar.Price = Stock.dtoProduct[i].Price;

                        productCriar.Name = Stock.dtoProduct[i].ID.ToString();
                        Stock.products.AddLast(productCriar);
                        Stock.flowPanelStock.Controls.Add(Stock.products.Last.Value);
                    }
                } catch { }

                Stock.flowPanelStock.Controls.Remove(Stock.productIndex(Stock.products, indexProd));
                Stock.RemoveAt(Stock.products, indexProd);
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text != "")
                {
                    if (tbQuant.Text != "")
                    {
                        if (tbPrice.Text != "")
                        {
                            switch (mode)
                            {
                                case 0:
                                    CreateNewProductOnList();
                                    tbName.Text = "";
                                    tbQuant.Text = "";
                                    tbPrice.Text = "";
                                    DrawNewProduct();
                                    this.Close();
                                    break;
                                case 1:
                                    UpdateProductList();
                                    tbName.Text = "";
                                    tbQuant.Text = "";
                                    tbPrice.Text = "";
                                    UpdateProductDetails();
                                    this.Close();
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("You must insert a price", "Price is null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbPrice.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must insert a quantity", "Quant is null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbQuant.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("You must insert a name", "Name is null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("An error ocurred!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int i = Stock.dtoProduct.Count() - 1;
                Stock.dtoProduct.RemoveAt(i);
            }
        }

        private void UpdateProductDetails()
        {
            Control control = Stock.flowPanelStock.Controls.Find(Convert.ToString(Stock.productIndex(Stock.products, indexProd).Name), true).FirstOrDefault();
            Products products = (Products)control;
            products.ID = Stock.dtoProduct[indexCad].ID;
            products.ProductName = Stock.dtoProduct[indexCad].ProductName;
            products.QTDE = Stock.dtoProduct[indexCad].QTDE;
            products.Price = Stock.dtoProduct[indexCad].Price;
        }

        private void UpdateProductList()
        {
            Stock.dtoProduct[indexCad].QTDE = Convert.ToSingle(tbQuant.Text);
            Stock.dtoProduct[indexCad].Price = Convert.ToSingle(tbPrice.Text);
            Stock.dtoProduct[indexCad].ProductName = tbName.Text;
            bllProduct.AlterarAsync(Stock.dtoProduct[indexProd]);
        }

        private void CreateNewProductOnList()
        {
            Stock.dtoProduct.Add(new dtoProduct());
            int i = Stock.dtoProduct.Count() - 1;
            Stock.dtoProduct[i].QTDE = Convert.ToSingle(tbQuant.Text);
            Stock.dtoProduct[i].Price = Convert.ToSingle(tbPrice.Text);
            Stock.dtoProduct[i].ID = quantProds;
            Stock.dtoProduct[i].ProductName = tbName.Text;
            bllProduct.InserirAsync(Stock.dtoProduct[i]);
            quantProds++;
        }

        private static void DrawNewProduct()
        {
            Products products = new Products();
            int index = Stock.dtoProduct.Count() - 1;
            products.ID = Stock.dtoProduct[index].ID;
            products.ProductName = Stock.dtoProduct[index].ProductName;
            products.QTDE = Stock.dtoProduct[index].QTDE;
            products.Price = Stock.dtoProduct[index].Price;

            Stock.products.AddLast(products);
            if (Stock.currentIndex < 15)
            {
                Stock.currentIndex++;
            }
            Stock.flowPanelStock.Controls.Add(Stock.products.Last.Value);
        }

        private void CadProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void tbQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 48 && ch != 57 && ch != ',')
            {
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 48 && ch != 57 && ch != ',')
            {
                e.Handled = true;
            }
        }
    }
}
