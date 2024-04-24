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
            switch (Main.openEdit)
            {
                case 0:
                    {
                        PopulatingLists();
                        Tdata aux = CreatingTreeAuxData();
                        DateTime time1 = DateTime.Now;
                        DateTime time2;
                        TimeSpan timeSpanAvl = InsertingAVLTree(aux, time1);
                        TimeSpan timeSpanAbb;
                        InsertingABBTree(out time1, out time2, out timeSpanAbb);
                        int balanceFactorAbb, balanceFactorAvl;
                        GettingTreeRootBalanceFactor(out balanceFactorAbb, out balanceFactorAvl);
                        SavingAndUpdatingDateFilters();
                        Main.quantBooksCreated++;
                        ClosingAndShowingTree(timeSpanAvl, timeSpanAbb, balanceFactorAbb, balanceFactorAvl);
                        break;
                    }

                default:
                    UpdatingBook();
                    break;
            }
        }

        private void UpdatingBook()
        {
            Main.title[Books.index] = tbBookTitle.Text;
            Main.author[Books.index] = tbAuthor.Text;
            Main.pubDate[Books.index] = dateTimePubDate.Value;
            SaveInTXT.UpdateTXT();
            Main.openEdit = 0;
            this.Close();
        }

        private void ClosingAndShowingTree(TimeSpan timeSpanAvl, TimeSpan timeSpanAbb, int balanceFactorAbb, int balanceFactorAvl)
        {
            arvore = "";
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

        private static void SavingAndUpdatingDateFilters()
        {
            SaveInTXT.UpdateTXT();
            Main.dateTimePickerMin.Value = Main.pubDate.Min();
            Main.dateTimePickerMax.Value = Main.pubDate.Max();
        }

        private static void GettingTreeRootBalanceFactor(out int balanceFactorAbb, out int balanceFactorAvl)
        {
            balanceFactorAbb = Main.bst.BalanceFactor();
            balanceFactorAvl = Main.tree.getRootBalanceFactor();
        }

        private static void InsertingABBTree(out DateTime time1, out DateTime time2, out TimeSpan timeSpanAbb)
        {
            time1 = DateTime.Now;
            Main.bst.Insert(Main.quantBooksCreated);
            time2 = DateTime.Now;
            timeSpanAbb = time2 - time1;
        }

        private static TimeSpan InsertingAVLTree(Tdata aux, DateTime time1)
        {
            Main.tree.root = Main.tree.insert(Main.tree.root, aux);
            DateTime time2 = DateTime.Now;
            TimeSpan timeSpanAvl = time2 - time1;
            return timeSpanAvl;
        }

        private Tdata CreatingTreeAuxData()
        {
            Tdata aux = new Tdata();
            aux.id = Main.quantBooksCreated;
            aux.bookTitle = tbBookTitle.Text;
            aux.author = tbAuthor.Text;
            aux.pubDate = dateTimePubDate.Value;
            return aux;
        }

        private void PopulatingLists()
        {
            Main.id.Add(Main.quantBooksCreated);
            Main.title.Add(tbBookTitle.Text);
            Main.author.Add(tbAuthor.Text);
            Main.pubDate.Add(dateTimePubDate.Value);
        }

        private void CadBooks_Load(object sender, EventArgs e)
        {
            dateTimePubDate.Value = DateTime.Today;
            switch (Main.openEdit)
            {
                case 0:
                    btnDelete.Hide();
                    break;
                default:
                    tbBookTitle.Text = Main.title[Books.index].ToString();
                    tbAuthor.Text = Main.author[Books.index].ToString();
                    dateTimePubDate.Value = Main.pubDate[Books.index];
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = ConfirmationMessage();

            if (delete == DialogResult.OK)
            {
                DateTime time1, time2;
                TimeSpan timeSpanAvl = DeleteAVLTree();
                TimeSpan timeSpanAbb;
                DeleteABBTree(out time1, out time2, out timeSpanAbb);
                DeleteOnList();
                SavingAndUpdatingDateFilter();
                ClosingShowingPerformance(timeSpanAvl, timeSpanAbb);
            }
        }

        private void ClosingShowingPerformance(TimeSpan timeSpanAvl, TimeSpan timeSpanAbb)
        {
            this.Close();
            MessageBox.Show(
                $"Tempo de execução da Arv. ABB: {timeSpanAbb.TotalNanoseconds} Nanossegundos\n" +
                $"Tempo de execução da Arv. AVL: {timeSpanAvl.TotalNanoseconds} Nanossegundos\n\n",
                "Arvore de pesquisa",
                MessageBoxButtons.OK);
        }

        private static void SavingAndUpdatingDateFilter()
        {
            SaveInTXT.UpdateTXT();
            Main.openEdit = 0;
            Main.dateTimePickerMin.Value = Main.pubDate.Min();
            Main.dateTimePickerMax.Value = Main.pubDate.Max();
        }

        private static void DeleteOnList()
        {
            Main.id.RemoveAt(Books.index);
            Main.title.RemoveAt(Books.index);
            Main.author.RemoveAt(Books.index);
            Main.pubDate.RemoveAt(Books.index);
        }

        private static void DeleteABBTree(out DateTime time1, out DateTime time2, out TimeSpan timeSpanAbb)
        {
            time1 = DateTime.Now;
            Main.bst.Delete(Main.id[Books.index]);
            time2 = DateTime.Now;
            timeSpanAbb = time2 - time1;
        }

        private static TimeSpan DeleteAVLTree()
        {
            DateTime time1 = DateTime.Now;
            Main.tree.root = Main.tree.deleteNode(Main.tree.root, Main.id[Books.index]);
            DateTime time2 = DateTime.Now;
            TimeSpan timeSpanAvl = time2 - time1;
            return timeSpanAvl;
        }

        private static DialogResult ConfirmationMessage()
        {
            return MessageBox.Show("Are you sure?", "Delete Book",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void CadBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.openEdit = 0;
            Main.DrawBooks();
        }
    }
}
