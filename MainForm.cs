using LibraryManagementSystem.Database;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly LibraryRepository _repository;

        private const string searchPlaceholder = "Search by title, author, or genre...";

        public MainForm()
        {
            InitializeComponent();
            _repository = new();
            InitializeDataAndUI();
        }

        private void InitializeDataAndUI()
        {
            SetSearchPlaceholder();
            BindEventHandlers();
            LoadBooks();
        }

        private void SetSearchPlaceholder()
        {
            txtSearch.Text = searchPlaceholder;
            txtSearch.ForeColor = Color.Silver;
        }
        private void BindEventHandlers()
        {
            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == searchPlaceholder)
                {
                    txtSearch.Text = string.Empty;
                    txtSearch.ForeColor = Color.Black;
                }
            };

            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    SetSearchPlaceholder();
                }
            };


            this.txtSearch.TextChanged += TxtSearch_TextChanged;

            this.btnUpdate.MouseEnter += (s, e) => this.btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            this.btnUpdate.MouseLeave += (s, e) => this.btnUpdate.BackColor = Color.FromArgb(52, 152, 219);

            this.btnAdd.MouseEnter += (s, e) => this.btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            this.btnAdd.MouseLeave += (s, e) => this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            this.btnDelete.MouseEnter += (s, e) => this.btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            this.btnDelete.MouseLeave += (s, e) => this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);

            this.dgvBooks.AutoGenerateColumns = false;

            var idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50,
                ReadOnly = true
            };
            idColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var titleColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Title",
                Width = 250
            };

            var authorColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Author",
                HeaderText = "Author",
                Width = 180
            };

            var yearColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Year",
                HeaderText = "Year",
                Width = 60
            };

            var genreColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Genre",
                HeaderText = "Genre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            var isBorrowedColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IsBorrowed",
                HeaderText = "IsBorrowed",
                Width = 90
            };

            var borrowedByColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BorrowedBy",
                HeaderText = "BorrowedBy",
                Width = 130
            };

            this.dgvBooks.Columns.AddRange([
                idColumn,
                    titleColumn,
                    authorColumn,
                    yearColumn,
                    genreColumn,
                    isBorrowedColumn,
                    borrowedByColumn]);

            btnAdd.Click += (s, e) => AddBook();
            btnUpdate.Click += (s, e) => UpdateBook();
            btnDelete.Click += (s, e) => DeleteBook();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _repository.GetAllBooks();
            lblStatus.Text = $"{dgvBooks.RowCount} books found.";
        }
        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(keyword) || keyword == searchPlaceholder)
            {
                LoadBooks();
                return;
            }

            var filteredBooks = _repository.SearchBooks(keyword);
            dgvBooks.DataSource = filteredBooks;
            lblStatus.Text = $"{filteredBooks.Count} books found.";
        }

        #region CRUD Operations

        private void AddBook()
        {
            using var bookForm = new ProcessForm();
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                var newBook = bookForm.ProcessedBook;
                _repository.AddBook(newBook);
                LoadBooks();
                lblStatus.Text = "New book added successfully.";
            }
        }
        private void UpdateBook()
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBookId = (int)dgvBooks.SelectedRows[0].Cells[0].Value;
            var selectedBook = _repository.GetBookById(selectedBookId);
            if (selectedBook == null)
            {
                MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var bookForm = new ProcessForm(selectedBook);
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                var updatedBook = bookForm.ProcessedBook;
                _repository.UpdateBook(updatedBook);
                LoadBooks();
                lblStatus.Text = "Book updated successfully.";
            }
        }
        private void DeleteBook()
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedBookId = (int)dgvBooks.SelectedRows[0].Cells[0].Value;
                _repository.DeleteBook(selectedBookId);
                LoadBooks();
                lblStatus.Text = "Book deleted successfully.";
            }
        }

        #endregion

    }
}
