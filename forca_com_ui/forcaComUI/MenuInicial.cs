namespace forcaComUI
{
    public partial class MenuInicial : Form
    {
        public static MenuInicial instance;
        public TextBox palavraSegredo;

        public MenuInicial()
        {
            InitializeComponent();
            instance = this;
            palavraSegredo = txtPalavraSegredo;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtPalavraSegredo.Text != "")
            {
                TelaJogo telaJogo = new TelaJogo();
                txtPalavraSegredo.Hide();
                telaJogo.Show();
            }
        }
    }
}
