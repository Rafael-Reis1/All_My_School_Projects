namespace Sistema_de_vendas
{
    partial class Sales
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
            panel1 = new Panel();
            button1 = new Button();
            tbClienteFilterRestricted = new TextBox();
            tbClienteFilterFlex = new TextBox();
            flowPanelSales = new FlowLayoutPanel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            dateTimeFilterFinal = new DateTimePicker();
            dateTimeFilterStart = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnProductName = new Button();
            btnID = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(76, 0, 0);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 32);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(165, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // tbClienteFilterRestricted
            // 
            tbClienteFilterRestricted.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbClienteFilterRestricted.ForeColor = Color.FromArgb(114, 114, 114);
            tbClienteFilterRestricted.Location = new Point(0, 48);
            tbClienteFilterRestricted.Name = "tbClienteFilterRestricted";
            tbClienteFilterRestricted.Size = new Size(165, 25);
            tbClienteFilterRestricted.TabIndex = 1;
            tbClienteFilterRestricted.Text = "NAME RESTRICTED";
            tbClienteFilterRestricted.Enter += tbClienteFilterRestricted_Enter;
            tbClienteFilterRestricted.Leave += tbClienteFilterRestricted_Leave;
            // 
            // tbClienteFilterFlex
            // 
            tbClienteFilterFlex.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tbClienteFilterFlex.ForeColor = Color.FromArgb(114, 114, 114);
            tbClienteFilterFlex.Location = new Point(0, 79);
            tbClienteFilterFlex.Name = "tbClienteFilterFlex";
            tbClienteFilterFlex.Size = new Size(165, 25);
            tbClienteFilterFlex.TabIndex = 2;
            tbClienteFilterFlex.Text = "NAME FLEXIBLE";
            tbClienteFilterFlex.Enter += tbClienteFilterFlex_Enter;
            tbClienteFilterFlex.Leave += tbClienteFilterFlex_Leave;
            // 
            // flowPanelSales
            // 
            flowPanelSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelSales.AutoScroll = true;
            flowPanelSales.BackColor = Color.LightSteelBlue;
            flowPanelSales.Font = new Font("Segoe UI", 9.75F);
            flowPanelSales.Location = new Point(165, 65);
            flowPanelSales.Margin = new Padding(0);
            flowPanelSales.Name = "flowPanelSales";
            flowPanelSales.Size = new Size(750, 475);
            flowPanelSales.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(76, 0, 0);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimeFilterFinal);
            panel2.Controls.Add(dateTimeFilterStart);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbClienteFilterFlex);
            panel2.Controls.Add(tbClienteFilterRestricted);
            panel2.Location = new Point(0, 32);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 505);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(0, 159);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Final date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(0, 107);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 3;
            label2.Text = "Inicial date:";
            // 
            // dateTimeFilterFinal
            // 
            dateTimeFilterFinal.Format = DateTimePickerFormat.Short;
            dateTimeFilterFinal.Location = new Point(0, 183);
            dateTimeFilterFinal.Name = "dateTimeFilterFinal";
            dateTimeFilterFinal.Size = new Size(165, 25);
            dateTimeFilterFinal.TabIndex = 6;
            // 
            // dateTimeFilterStart
            // 
            dateTimeFilterStart.Format = DateTimePickerFormat.Short;
            dateTimeFilterStart.Location = new Point(0, 131);
            dateTimeFilterStart.Name = "dateTimeFilterStart";
            dateTimeFilterStart.Size = new Size(165, 25);
            dateTimeFilterStart.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(31, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 0;
            label1.Text = "FILTERS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(76, 0, 0);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnProductName);
            panel3.Controls.Add(btnID);
            panel3.Location = new Point(165, 32);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 33);
            panel3.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(625, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(125, 33);
            button3.TabIndex = 8;
            button3.Text = "Sale date";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(518, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(107, 33);
            button2.TabIndex = 7;
            button2.Text = "Total";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnProductName
            // 
            btnProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnProductName.FlatAppearance.BorderSize = 0;
            btnProductName.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 0, 0);
            btnProductName.FlatStyle = FlatStyle.Flat;
            btnProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnProductName.ForeColor = SystemColors.HighlightText;
            btnProductName.Location = new Point(70, 0);
            btnProductName.Margin = new Padding(0);
            btnProductName.Name = "btnProductName";
            btnProductName.Size = new Size(448, 33);
            btnProductName.TabIndex = 6;
            btnProductName.Text = "Costumer Name";
            btnProductName.TextAlign = ContentAlignment.MiddleLeft;
            btnProductName.UseVisualStyleBackColor = false;
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
            btnID.Size = new Size(70, 33);
            btnID.TabIndex = 5;
            btnID.Text = "  ID";
            btnID.TextAlign = ContentAlignment.MiddleLeft;
            btnID.UseVisualStyleBackColor = false;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 536);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(flowPanelSales);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "Sales";
            Text = "Sales";
            TopMost = true;
            FormClosing += Sales_FormClosing;
            Load += Sales_Load;
            KeyDown += Sales_KeyDown;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox tbClienteFilterFlex;
        private TextBox tbClienteFilterRestricted;
        private Panel panel2;
        private Label label1;
        private DateTimePicker dateTimeFilterStart;
        private DateTimePicker dateTimeFilterFinal;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button btnID;
        private Button button3;
        private Button button2;
        private Button btnProductName;
        public static FlowLayoutPanel flowPanelSales;
    }
}