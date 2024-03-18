namespace forcaComUI
{
    partial class MenuInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            lblBemVindo = new Label();
            lblPedindoAPalavraSegredo = new Label();
            txtPalavraSegredo = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(215, 71);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(360, 37);
            lblBemVindo.TabIndex = 0;
            lblBemVindo.Text = "Bem vindo  ao jogo da forca!";
            // 
            // lblPedindoAPalavraSegredo
            // 
            lblPedindoAPalavraSegredo.AutoSize = true;
            lblPedindoAPalavraSegredo.Location = new Point(319, 222);
            lblPedindoAPalavraSegredo.Name = "lblPedindoAPalavraSegredo";
            lblPedindoAPalavraSegredo.Size = new Size(153, 17);
            lblPedindoAPalavraSegredo.TabIndex = 1;
            lblPedindoAPalavraSegredo.Text = "Digite a palavra segredo";
            // 
            // txtPalavraSegredo
            // 
            txtPalavraSegredo.Location = new Point(215, 242);
            txtPalavraSegredo.Name = "txtPalavraSegredo";
            txtPalavraSegredo.Size = new Size(360, 25);
            txtPalavraSegredo.TabIndex = 2;
            txtPalavraSegredo.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(343, 331);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(104, 38);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Iniciar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // MenuInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPalavraSegredo);
            Controls.Add(lblPedindoAPalavraSegredo);
            Controls.Add(lblBemVindo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuInicial";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBemVindo;
        private Label lblPedindoAPalavraSegredo;
        private TextBox txtPalavraSegredo;
        private Button btnConfirmar;
    }
}
