using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forcaComUI
{
    public partial class TelaJogo : Form
    {
        public static TelaJogo instance;

        private string[] dividido = new string[50];
        private string[] mostrarNaTela = new string[50];
        private string txtPalavraSegredo = MenuInicial.instance.palavraSegredo.Text, letraEscolhida = "";
        private int tentativas = 0, certos = 0;


        public TelaJogo()
        {
            InitializeComponent();
            instance = this;
            btnReiniciar.Hide();

            for (int i = 0; i < txtPalavraSegredo.Length; i++)
            {
                dividido[i] = txtPalavraSegredo.Substring(i, 1);
            }

            EscreverNaTela();

            lblQuantLetras.Text = txtPalavraSegredo.Length.ToString() + " letras";
        }

        private void TelaJogo_Load(object sender, EventArgs e)
        {

        }

        private void EscreverNaTela()
        {
            certos = 0;

            for (int i = 0; i < txtPalavraSegredo.Length; i++)
            {
                if (mostrarNaTela[i] == "" || mostrarNaTela[i] == null)
                {
                    lblPalavraSegredo.Text += "_ ";
                }
                else
                {
                    lblPalavraSegredo.Text += mostrarNaTela[i];
                    certos++;
                }
            }

            lblNTentativas.Text = "Tentativa " + tentativas + " de 10 tentativas";

            if (certos >= txtPalavraSegredo.Length)
            {
                btnReiniciar.Show();
                lblPalavraSegredo.Text = "VOCE ACERTOU!!!!!";
            }
            if (tentativas >= 11)
            {
                btnReiniciar.Show();
                lblPalavraSegredo.Text = "VOCE NAO ACERTOU!!!!!";
            }
        }

        private void LetraCerta()
        {
            if (txtPalavraSegredo.Contains(letraEscolhida.ToLower()) || txtPalavraSegredo.Contains(letraEscolhida.ToUpper()))
            {
                for (int i = 0; i < txtPalavraSegredo.Length; i++)
                {
                    if (dividido[i] == letraEscolhida.ToLower() || dividido[i] == letraEscolhida.ToUpper())
                    {
                        mostrarNaTela[i] = dividido[i];
                    }
                }

                lblPalavraSegredo.Text = "";
                letraEscolhida = "";

                EscreverNaTela();
            }
            else
            {
                tentativas++;
                letraEscolhida = "";
                lblNTentativas.Text = "Tentativa " + tentativas + " de 10 tentativas";
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            letraEscolhida = "a";
            LetraCerta();
            btnA.Hide();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            letraEscolhida = "b";
            LetraCerta();
            btnB.Hide();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            letraEscolhida = "c";
            LetraCerta();
            btnC.Hide();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            letraEscolhida = "d";
            LetraCerta();
            btnD.Hide();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            letraEscolhida = "e";
            LetraCerta();
            btnE.Hide();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            letraEscolhida = "f";
            LetraCerta();
            btnF.Hide();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            letraEscolhida = "g";
            LetraCerta();
            btnG.Hide();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            letraEscolhida = "h";
            LetraCerta();
            btnH.Hide();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            letraEscolhida = "i";
            LetraCerta();
            btnI.Hide();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            letraEscolhida = "j";
            LetraCerta();
            btnJ.Hide();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            letraEscolhida = "k";
            LetraCerta();
            btnK.Hide();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            letraEscolhida = "l";
            LetraCerta();
            btnL.Hide();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            letraEscolhida = "m";
            LetraCerta();
            btnM.Hide();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            letraEscolhida = "n";
            LetraCerta();
            btnN.Hide();
        }

        private void bntO_Click(object sender, EventArgs e)
        {
            letraEscolhida = "o";
            LetraCerta();
            btnO.Hide();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            letraEscolhida = "p";
            LetraCerta();
            btnP.Hide();
        }

        private void bntQ_Click(object sender, EventArgs e)
        {
            letraEscolhida = "q";
            LetraCerta();
            btnQ.Hide();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            letraEscolhida = "r";
            LetraCerta();
            btnR.Hide();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            letraEscolhida = "s";
            LetraCerta();
            btnS.Hide();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            letraEscolhida = "t";
            LetraCerta();
            btnT.Hide();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            letraEscolhida = "u";
            LetraCerta();
            btnU.Hide();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            letraEscolhida = "v";
            LetraCerta();
            btnV.Hide();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            letraEscolhida = "w";
            LetraCerta();
            btnW.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            letraEscolhida = "x";
            LetraCerta();
            btnX.Hide();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            letraEscolhida = "y";
            LetraCerta();
            btnY.Hide();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            letraEscolhida = "z";
            LetraCerta();
            btnZ.Hide();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            TelaJogo.instance.Hide();
            MenuInicial.instance.palavraSegredo.Text = "";
            MenuInicial.instance.palavraSegredo.Show();
        }
    }
}
