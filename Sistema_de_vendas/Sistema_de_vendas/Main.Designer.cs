namespace Sistema_de_vendas
{
    partial class Main
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
            btnSales = new Button();
            panel1 = new Panel();
            btnExit = new Button();
            btnReports = new Button();
            btnStock = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSales
            // 
            btnSales.BackColor = SystemColors.ButtonFace;
            btnSales.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSales.ForeColor = SystemColors.ControlText;
            btnSales.Location = new Point(11, -1);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(75, 37);
            btnSales.TabIndex = 0;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 0, 0);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnSales);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 37);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(254, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.ButtonFace;
            btnReports.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnReports.ForeColor = SystemColors.ControlText;
            btnReports.Location = new Point(173, -1);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(75, 37);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = SystemColors.ButtonFace;
            btnStock.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnStock.ForeColor = SystemColors.ControlText;
            btnStock.Location = new Point(92, -1);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(75, 37);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 441);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Melhor sistema do MUNDO";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSales;
        private Panel panel1;
        private Button btnExit;
        private Button btnReports;
        private Button btnStock;
    }
}
