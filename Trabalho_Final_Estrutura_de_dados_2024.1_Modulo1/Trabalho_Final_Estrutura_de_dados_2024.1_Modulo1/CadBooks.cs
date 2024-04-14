using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_Estrutura_de_dados_2024._1_Modulo1
{
    public partial class CadBooks : Form
    {
        public CadBooks()
        {
            InitializeComponent();
        }

        public static string arvore;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Main.openEdit == 0)
            {
                Main.id.Add(Main.quantBooksCreated);
                Main.title.Add(tbBookTitle.Text);
                Main.author.Add(tbAuthor.Text);
                Main.pubDate.Add(dateTimePubDate.Value);
                Tdata aux = new Tdata();
                aux.id = Main.quantBooksCreated;
                aux.bookTitle = tbBookTitle.Text;
                aux.author = tbAuthor.Text;
                aux.pubDate = dateTimePubDate.Value;
                DateTime time1 = DateTime.Now;
                Main.tree.root = Main.tree.insert(Main.tree.root, aux);
                DateTime time2 = DateTime.Now;
                TimeSpan timeSpanAvl = time2 - time1;
                time1 = DateTime.Now;
                Main.bst.Insert(Main.quantBooksCreated);
                time2 = DateTime.Now;
                TimeSpan timeSpanAbb = time2 - time1;
                int balanceFactorAbb = Main.bst.BalanceFactor(); 
                int balanceFactorAvl = Main.tree.getRootBalanceFactor();
                Main.quantBooksCreated++;
                arvore = "";
                SaveInTXT.UpdateTXT();
                Main.dateTimePickerMin.Value = Main.pubDate.Min();
                Main.dateTimePickerMax.Value = Main.pubDate.Max();
                this.Close();
                Main.tree.printTree(Main.tree.root, "", true);
                MessageBox.Show($"FB nó raiz Arv. ABB: {balanceFactorAbb} \n" +
                    $"Tempo de execução da Arv. ABB: {timeSpanAbb.TotalNanoseconds} Nanossegundos\n" +
                    $"FB nó raiz Arv. AVL: {balanceFactorAvl} \n" +
                    $"Numero de rotações Arv. AVL: {Main.numRotation} \n" +
                    $"Tempo de execução da Arv. AVL: {timeSpanAvl.TotalNanoseconds} Nanossegundos\n\n" +
                    arvore,
                    "Arvore de pesquisa",
                    MessageBoxButtons.OK);

            }
            else
            {
                Main.title[Books.index] = tbBookTitle.Text;
                Main.author[Books.index] = tbAuthor.Text;
                Main.pubDate[Books.index] = dateTimePubDate.Value;
                SaveInTXT.UpdateTXT();
                Main.openEdit = 0;
                this.Close();
            }
        }

        private void CadBooks_Load(object sender, EventArgs e)
        {
            dateTimePubDate.Value = DateTime.Today;
            if (Main.openEdit == 0)
            {
                btnDelete.Hide();
            }
            else
            {
                tbBookTitle.Text = Main.title[Books.index].ToString();
                tbAuthor.Text = Main.author[Books.index].ToString();
                dateTimePubDate.Value = Main.pubDate[Books.index];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Are you sure?", "Delete Book", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (delete == DialogResult.OK)
            {
                DateTime time1 = DateTime.Now;
                Main.tree.root = Main.tree.deleteNode(Main.tree.root, Main.id[Books.index]);
                DateTime time2 = DateTime.Now;
                TimeSpan timeSpanAvl = time2 - time1;
                time1 = DateTime.Now;
                Main.bst.Delete(Main.id[Books.index]);
                time2 = DateTime.Now;
                TimeSpan timeSpanAbb = time2 - time1;
                Main.id.RemoveAt(Books.index);
                Main.title.RemoveAt(Books.index);
                Main.author.RemoveAt(Books.index);
                Main.pubDate.RemoveAt(Books.index);
                SaveInTXT.UpdateTXT();
                Main.openEdit = 0;
                Main.dateTimePickerMin.Value = Main.pubDate.Min();
                Main.dateTimePickerMax.Value = Main.pubDate.Max();
                this.Close();
                MessageBox.Show(
                    $"Tempo de execução da Arv. ABB: {timeSpanAbb.TotalNanoseconds} Nanossegundos\n" +
                    $"Tempo de execução da Arv. AVL: {timeSpanAvl.TotalNanoseconds} Nanossegundos\n\n",
                    "Arvore de pesquisa",
                    MessageBoxButtons.OK);
            }  
        }

        private void CadBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.openEdit = 0;
            Main.DrawBooks();
        }
    }
}
