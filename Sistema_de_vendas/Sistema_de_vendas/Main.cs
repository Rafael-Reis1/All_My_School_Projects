namespace Sistema_de_vendas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Stock stock = new Stock();
        private Sales sales = new Sales();

        private void btnSales_Click(object sender, EventArgs e)
        {
            sales.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stock.Show();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            try
            {
                bllProduct bllProduct = new bllProduct();
                await bllProduct.SelecionarAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
