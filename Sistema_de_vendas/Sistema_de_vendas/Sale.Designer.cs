namespace Sistema_de_vendas
{
    partial class Sale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblID = new Label();
            lblName = new Label();
            lblTotal = new Label();
            lblDateSale = new Label();
            btnSale = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblID.ForeColor = SystemColors.HighlightText;
            lblID.Location = new Point(13, 6);
            lblID.Name = "lblID";
            lblID.Size = new Size(22, 17);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            lblID.Click += lblID_Click;
            lblID.MouseLeave += lblID_MouseLeave;
            lblID.MouseMove += lblID_MouseMove;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblName.ForeColor = SystemColors.HighlightText;
            lblName.Location = new Point(74, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Nome Cliente";
            lblName.Click += lblName_Click;
            lblName.MouseLeave += lblName_MouseLeave;
            lblName.MouseMove += lblName_MouseMove;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTotal.ForeColor = SystemColors.HighlightText;
            lblTotal.Location = new Point(521, 6);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(39, 17);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            lblTotal.Click += lblTotal_Click;
            lblTotal.MouseLeave += lblTotal_MouseLeave;
            lblTotal.MouseMove += lblTotal_MouseMove;
            // 
            // lblDateSale
            // 
            lblDateSale.AutoSize = true;
            lblDateSale.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDateSale.ForeColor = SystemColors.HighlightText;
            lblDateSale.Location = new Point(628, 6);
            lblDateSale.Name = "lblDateSale";
            lblDateSale.Size = new Size(76, 17);
            lblDateSale.TabIndex = 3;
            lblDateSale.Text = "02/05/2024";
            lblDateSale.Click += lblDateSale_Click;
            lblDateSale.MouseLeave += lblDateSale_MouseLeave;
            lblDateSale.MouseMove += lblDateSale_MouseMove;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.Transparent;
            btnSale.Dock = DockStyle.Fill;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSale.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Location = new Point(0, 0);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(732, 31);
            btnSale.TabIndex = 4;
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(lblDateSale);
            Controls.Add(lblTotal);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Controls.Add(btnSale);
            Margin = new Padding(0);
            Name = "Sale";
            Size = new Size(732, 31);
            Load += Sale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblName;
        private Label lblTotal;
        private Label lblDateSale;
        private Button btnSale;
    }
}
