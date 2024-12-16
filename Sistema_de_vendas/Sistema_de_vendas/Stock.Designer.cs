namespace Sistema_de_vendas
{
    partial class Stock
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
            btnADD = new Button();
            panel1 = new Panel();
            tbNameFilterFlex = new TextBox();
            tbNameFilter = new TextBox();
            flowPanelStock = new FlowLayoutPanel();
            panel3 = new Panel();
            btnPrice = new Button();
            btnQuant = new Button();
            btnProductName = new Button();
            btnID = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnADD
            // 
            btnADD.BackColor = SystemColors.ButtonFace;
            btnADD.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnADD.FlatStyle = FlatStyle.Flat;
            btnADD.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnADD.Location = new Point(11, -1);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(90, 32);
            btnADD.TabIndex = 0;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnADD_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 0, 0);
            panel1.Controls.Add(tbNameFilterFlex);
            panel1.Controls.Add(btnADD);
            panel1.Controls.Add(tbNameFilter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 32);
            panel1.TabIndex = 1;
            // 
            // tbNameFilterFlex
            // 
            tbNameFilterFlex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbNameFilterFlex.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbNameFilterFlex.ForeColor = Color.FromArgb(114, 114, 114);
            tbNameFilterFlex.Location = new Point(731, 2);
            tbNameFilterFlex.Name = "tbNameFilterFlex";
            tbNameFilterFlex.Size = new Size(142, 25);
            tbNameFilterFlex.TabIndex = 4;
            tbNameFilterFlex.Text = "NAME FLEXIBLE";
            tbNameFilterFlex.TextChanged += tbNameFilterFlex_TextChanged;
            tbNameFilterFlex.Enter += tbNameFilterFlex_Enter;
            tbNameFilterFlex.KeyDown += tbNameFilterFlex_KeyDown;
            tbNameFilterFlex.Leave += tbNameFilterFlex_Leave;
            // 
            // tbNameFilter
            // 
            tbNameFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbNameFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbNameFilter.ForeColor = Color.FromArgb(114, 114, 114);
            tbNameFilter.Location = new Point(583, 2);
            tbNameFilter.Name = "tbNameFilter";
            tbNameFilter.Size = new Size(142, 25);
            tbNameFilter.TabIndex = 1;
            tbNameFilter.Text = "NAME RESTRICTED";
            tbNameFilter.TextChanged += tbNameFilter_TextChanged;
            tbNameFilter.Enter += tbNameFilter_Enter;
            tbNameFilter.KeyDown += tbNameFilter_KeyDown;
            tbNameFilter.Leave += tbNameFilter_Leave;
            // 
            // flowPanelStock
            // 
            flowPanelStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelStock.AutoScroll = true;
            flowPanelStock.BackColor = Color.LightSteelBlue;
            flowPanelStock.Font = new Font("Segoe UI", 9.75F);
            flowPanelStock.Location = new Point(0, 63);
            flowPanelStock.Margin = new Padding(0);
            flowPanelStock.Name = "flowPanelStock";
            flowPanelStock.Size = new Size(932, 475);
            flowPanelStock.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(76, 0, 0);
            panel3.Controls.Add(btnPrice);
            panel3.Controls.Add(btnQuant);
            panel3.Controls.Add(btnProductName);
            panel3.Controls.Add(btnID);
            panel3.Location = new Point(0, 32);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 31);
            panel3.TabIndex = 2;
            // 
            // btnPrice
            // 
            btnPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrice.FlatAppearance.BorderSize = 0;
            btnPrice.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            btnPrice.FlatStyle = FlatStyle.Flat;
            btnPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPrice.ForeColor = SystemColors.HighlightText;
            btnPrice.Location = new Point(803, 0);
            btnPrice.Margin = new Padding(0);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(81, 33);
            btnPrice.TabIndex = 7;
            btnPrice.Text = "Price";
            btnPrice.TextAlign = ContentAlignment.MiddleLeft;
            btnPrice.UseVisualStyleBackColor = false;
            btnPrice.Click += btnPrice_Click;
            // 
            // btnQuant
            // 
            btnQuant.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuant.FlatAppearance.BorderSize = 0;
            btnQuant.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            btnQuant.FlatStyle = FlatStyle.Flat;
            btnQuant.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnQuant.ForeColor = SystemColors.HighlightText;
            btnQuant.Location = new Point(717, -1);
            btnQuant.Margin = new Padding(0);
            btnQuant.Name = "btnQuant";
            btnQuant.Size = new Size(86, 33);
            btnQuant.TabIndex = 6;
            btnQuant.Text = "Quant";
            btnQuant.TextAlign = ContentAlignment.MiddleLeft;
            btnQuant.UseVisualStyleBackColor = false;
            btnQuant.Click += btnQuant_Click;
            // 
            // btnProductName
            // 
            btnProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnProductName.FlatAppearance.BorderSize = 0;
            btnProductName.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            btnProductName.FlatStyle = FlatStyle.Flat;
            btnProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnProductName.ForeColor = SystemColors.HighlightText;
            btnProductName.Location = new Point(72, -2);
            btnProductName.Margin = new Padding(0);
            btnProductName.Name = "btnProductName";
            btnProductName.Size = new Size(645, 33);
            btnProductName.TabIndex = 5;
            btnProductName.Text = "Product Name";
            btnProductName.TextAlign = ContentAlignment.MiddleLeft;
            btnProductName.UseVisualStyleBackColor = false;
            btnProductName.Click += btnProductName_Click;
            // 
            // btnID
            // 
            btnID.FlatAppearance.BorderSize = 0;
            btnID.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            btnID.FlatStyle = FlatStyle.Flat;
            btnID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnID.ForeColor = SystemColors.HighlightText;
            btnID.Location = new Point(0, 0);
            btnID.Margin = new Padding(0);
            btnID.Name = "btnID";
            btnID.Size = new Size(72, 33);
            btnID.TabIndex = 4;
            btnID.Text = "  ID";
            btnID.TextAlign = ContentAlignment.MiddleLeft;
            btnID.UseVisualStyleBackColor = false;
            btnID.Click += btnID_Click;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 536);
            Controls.Add(flowPanelStock);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "Stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock";
            TopMost = true;
            FormClosing += Stock_FormClosing;
            Load += Stock_Load;
            KeyDown += Stock_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnADD;
        private Panel panel1;
        private TextBox tbNameFilter;
        private Panel panel3;
        private Button btnID;
        private TextBox tbNameFilterFlex;
        private Button btnProductName;
        private Button btnQuant;
        private Button btnPrice;
        public static FlowLayoutPanel flowPanelStock;
    }
}