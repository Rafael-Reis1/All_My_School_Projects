namespace Sistema_de_vendas
{
    partial class CadProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbName = new TextBox();
            tbQuant = new TextBox();
            tbPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConfirm = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top;
            tbName.Location = new Point(12, 94);
            tbName.MaxLength = 255;
            tbName.Name = "tbName";
            tbName.Size = new Size(300, 25);
            tbName.TabIndex = 1;
            // 
            // tbQuant
            // 
            tbQuant.Anchor = AnchorStyles.Top;
            tbQuant.Location = new Point(11, 157);
            tbQuant.Name = "tbQuant";
            tbQuant.Size = new Size(300, 25);
            tbQuant.TabIndex = 2;
            tbQuant.KeyPress += tbQuant_KeyPress;
            // 
            // tbPrice
            // 
            tbPrice.Anchor = AnchorStyles.Top;
            tbPrice.Location = new Point(12, 225);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(300, 25);
            tbPrice.TabIndex = 3;
            tbPrice.KeyPress += tbPrice_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(13, 74);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 5;
            label2.Text = "Quant";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(13, 205);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Top;
            btnConfirm.BackColor = Color.Lime;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Location = new Point(111, 300);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(93, 32);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirn";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackgroundImage = Properties.Resources.Trash;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(286, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(26, 28);
            btnDelete.TabIndex = 8;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CadProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(320, 370);
            Controls.Add(btnDelete);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPrice);
            Controls.Add(tbQuant);
            Controls.Add(tbName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "CadProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadProducts";
            TopMost = true;
            KeyDown += CadProducts_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbName;
        private TextBox tbQuant;
        private TextBox tbPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConfirm;
        private Button btnDelete;
    }
}