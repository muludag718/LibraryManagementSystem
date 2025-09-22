namespace LibraryManagementSystem
{
    partial class ProcessForm
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
            headerPanel = new Panel();
            lblFormTitle = new Label();
            mainContentPanel = new Panel();
            BtnSave = new Button();
            btnCancel = new Button();
            txtBorrowedBy = new TextBox();
            lblBorrowedBy = new Label();
            chkIsBorrowed = new CheckBox();
            txtGenre = new TextBox();
            lblGenre = new Label();
            txtYear = new TextBox();
            lblYear = new Label();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            headerPanel.SuspendLayout();
            mainContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(41, 128, 185);
            headerPanel.Controls.Add(lblFormTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(420, 60);
            headerPanel.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Padding = new Padding(3);
            lblFormTitle.Size = new Size(420, 60);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Add New Book";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Controls.Add(BtnSave);
            mainContentPanel.Controls.Add(btnCancel);
            mainContentPanel.Controls.Add(txtBorrowedBy);
            mainContentPanel.Controls.Add(lblBorrowedBy);
            mainContentPanel.Controls.Add(chkIsBorrowed);
            mainContentPanel.Controls.Add(txtGenre);
            mainContentPanel.Controls.Add(lblGenre);
            mainContentPanel.Controls.Add(txtYear);
            mainContentPanel.Controls.Add(lblYear);
            mainContentPanel.Controls.Add(txtAuthor);
            mainContentPanel.Controls.Add(lblAuthor);
            mainContentPanel.Controls.Add(txtTitle);
            mainContentPanel.Controls.Add(lblTitle);
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.Location = new Point(0, 60);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Padding = new Padding(20);
            mainContentPanel.Size = new Size(420, 460);
            mainContentPanel.TabIndex = 0;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(46, 204, 113);
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSave.ForeColor = Color.White;
            BtnSave.Location = new Point(180, 412);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 40);
            BtnSave.TabIndex = 13;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(286, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtBorrowedBy
            // 
            txtBorrowedBy.BorderStyle = BorderStyle.FixedSingle;
            txtBorrowedBy.Font = new Font("Segoe UI", 10F);
            txtBorrowedBy.Location = new Point(20, 345);
            txtBorrowedBy.Name = "txtBorrowedBy";
            txtBorrowedBy.Size = new Size(380, 25);
            txtBorrowedBy.TabIndex = 2;
            txtBorrowedBy.Visible = false;
            // 
            // lblBorrowedBy
            // 
            lblBorrowedBy.AutoSize = true;
            lblBorrowedBy.Font = new Font("Segoe UI Semibold", 10F);
            lblBorrowedBy.Location = new Point(20, 320);
            lblBorrowedBy.Name = "lblBorrowedBy";
            lblBorrowedBy.Size = new Size(84, 19);
            lblBorrowedBy.TabIndex = 3;
            lblBorrowedBy.Text = "BorrowedBy";
            lblBorrowedBy.Visible = false;
            // 
            // chkIsBorrowed
            // 
            chkIsBorrowed.AutoSize = true;
            chkIsBorrowed.Font = new Font("Segoe UI Semibold", 10F);
            chkIsBorrowed.Location = new Point(20, 290);
            chkIsBorrowed.Name = "chkIsBorrowed";
            chkIsBorrowed.Size = new Size(98, 23);
            chkIsBorrowed.TabIndex = 4;
            chkIsBorrowed.Text = "IsBorrowed";
            chkIsBorrowed.CheckedChanged += ChkIsBorrowed_CheckedChanged;
            // 
            // txtGenre
            // 
            txtGenre.BorderStyle = BorderStyle.FixedSingle;
            txtGenre.Font = new Font("Segoe UI", 10F);
            txtGenre.Location = new Point(20, 240);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(380, 25);
            txtGenre.TabIndex = 5;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI Semibold", 10F);
            lblGenre.Location = new Point(20, 215);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(46, 19);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre";
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Font = new Font("Segoe UI", 10F);
            txtYear.Location = new Point(20, 175);
            txtYear.MaxLength = 4;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(380, 25);
            txtYear.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 10F);
            lblYear.Location = new Point(20, 150);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(35, 19);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year";
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Font = new Font("Segoe UI", 10F);
            txtAuthor.Location = new Point(20, 110);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(380, 25);
            txtAuthor.TabIndex = 9;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI Semibold", 10F);
            lblAuthor.Location = new Point(20, 85);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(52, 19);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(20, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(380, 25);
            txtTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 10F);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(37, 19);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Title";
            // 
            // ProcessForm
            // 
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(420, 520);
            Controls.Add(mainContentPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Book / Update";
            headerPanel.ResumeLayout(false);
            mainContentPanel.ResumeLayout(false);
            mainContentPanel.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Panel headerPanel;
        private Label lblFormTitle;
        private Panel mainContentPanel;
        private Button btnCancel;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblGenre;
        private TextBox txtGenre;
        private CheckBox chkIsBorrowed;
        private Label lblBorrowedBy;
        private TextBox txtBorrowedBy;
        private Button BtnSave;
    }
}