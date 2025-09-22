namespace LibraryManagementSystem
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            headerPanel = new Panel();
            lblTitle = new Label();
            mainLayout = new TableLayoutPanel();
            searchPanel = new Panel();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            buttonsPanel = new FlowLayoutPanel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            lblStatus = new Label();
            bookBindingSource = new BindingSource(components);
            headerPanel.SuspendLayout();
            mainLayout.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(41, 128, 185);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 70);
            headerPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(900, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Library Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            mainLayout.BackColor = Color.Transparent;
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(searchPanel, 0, 0);
            mainLayout.Controls.Add(dgvBooks, 0, 1);
            mainLayout.Controls.Add(buttonsPanel, 0, 2);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 70);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 3;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.Size = new Size(900, 505);
            mainLayout.TabIndex = 0;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.White;
            searchPanel.Controls.Add(txtSearch);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(13, 13);
            searchPanel.Name = "searchPanel";
            searchPanel.Padding = new Padding(10);
            searchPanel.Size = new Size(874, 44);
            searchPanel.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Silver;
            txtSearch.Location = new Point(10, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(854, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search by title, author, or genre...";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 249);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.FromArgb(220, 220, 220);
            dgvBooks.Location = new Point(13, 63);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowTemplate.Height = 30;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(874, 369);
            dgvBooks.TabIndex = 1;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnDelete);
            buttonsPanel.Controls.Add(btnUpdate);
            buttonsPanel.Controls.Add(btnAdd);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.FlowDirection = FlowDirection.RightToLeft;
            buttonsPanel.Location = new Point(13, 438);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Padding = new Padding(0, 10, 0, 0);
            buttonsPanel.Size = new Size(874, 54);
            buttonsPanel.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(774, 10);
            btnDelete.Margin = new Padding(5, 0, 0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(669, 10);
            btnUpdate.Margin = new Padding(5, 0, 0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(564, 10);
            btnAdd.Margin = new Padding(5, 0, 0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(0, 575);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(0, 0, 15, 0);
            lblStatus.Size = new Size(900, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready.";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.Book);
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(900, 600);
            Controls.Add(mainLayout);
            Controls.Add(headerPanel);
            Controls.Add(lblStatus);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            headerPanel.ResumeLayout(false);
            mainLayout.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label lblTitle;
        private TableLayoutPanel mainLayout;
        private Panel searchPanel;
        private TextBox txtSearch;
        private DataGridView dgvBooks;
        private FlowLayoutPanel buttonsPanel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label lblStatus;
        private BindingSource bookBindingSource;

    }
}