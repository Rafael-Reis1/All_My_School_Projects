namespace Trabalho_Final_Estrutura_de_dados_2024._1_Modulo1
{
    partial class CadBooks
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblPubDate = new Label();
            tbBookTitle = new TextBox();
            tbAuthor = new TextBox();
            dateTimePubDate = new DateTimePicker();
            btnConfirm = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.HighlightText;
            lblTitle.Location = new Point(11, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = SystemColors.HighlightText;
            lblAuthor.Location = new Point(11, 111);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(58, 21);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author";
            // 
            // lblPubDate
            // 
            lblPubDate.AutoSize = true;
            lblPubDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPubDate.ForeColor = SystemColors.HighlightText;
            lblPubDate.Location = new Point(10, 173);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(76, 21);
            lblPubDate.TabIndex = 2;
            lblPubDate.Text = "Pub. Date";
            // 
            // tbBookTitle
            // 
            tbBookTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbBookTitle.Location = new Point(11, 70);
            tbBookTitle.Name = "tbBookTitle";
            tbBookTitle.Size = new Size(243, 25);
            tbBookTitle.TabIndex = 3;
            // 
            // tbAuthor
            // 
            tbAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbAuthor.Location = new Point(11, 135);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(243, 25);
            tbAuthor.TabIndex = 4;
            // 
            // dateTimePubDate
            // 
            dateTimePubDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePubDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePubDate.Format = DateTimePickerFormat.Short;
            dateTimePubDate.Location = new Point(10, 197);
            dateTimePubDate.Name = "dateTimePubDate";
            dateTimePubDate.Size = new Size(244, 29);
            dateTimePubDate.TabIndex = 5;
            dateTimePubDate.Value = new DateTime(2024, 4, 7, 15, 18, 0, 0);
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LimeGreen;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnConfirm.Location = new Point(95, 281);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(81, 31);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = Properties.Resources.TrashWhite;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(226, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(29, 32);
            btnDelete.TabIndex = 7;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CadBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(267, 340);
            Controls.Add(btnDelete);
            Controls.Add(btnConfirm);
            Controls.Add(dateTimePubDate);
            Controls.Add(tbAuthor);
            Controls.Add(tbBookTitle);
            Controls.Add(lblPubDate);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "CadBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadBooks";
            TopMost = true;
            FormClosing += CadBooks_FormClosing;
            Load += CadBooks_Load;
            KeyDown += CadBooks_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblPubDate;
        private TextBox tbBookTitle;
        private TextBox tbAuthor;
        private DateTimePicker dateTimePubDate;
        private Button btnConfirm;
        private Button btnDelete;
    }
}