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
    public partial class ProcessForm : Form
    {
        private enum Mode { Add, Update }
        private readonly Mode _mode;
        private readonly Book? _selectedBook;
        public Book ProcessedBook { get; private set; }


        public ProcessForm()
        {
            InitializeComponent();
            _mode = Mode.Add;
            this.ProcessedBook = new Book();
        }


        public ProcessForm(Book selectedBook) : this()
        {
            _mode = Mode.Update;
            _selectedBook = selectedBook ?? throw new ArgumentNullException(nameof(selectedBook));
            this.ProcessedBook = selectedBook;
            InitializeFormWithBookData();
        }

        private void InitializeFormWithBookData()
        {
            txtTitle.Text = _selectedBook!.Title;
            txtAuthor.Text = _selectedBook.Author;
            txtGenre.Text = _selectedBook.Genre;
            txtYear.Text = _selectedBook.Year.ToString();
            chkIsBorrowed.Checked = _selectedBook.IsBorrowed;

            if (_selectedBook.IsBorrowed)
            {
                txtBorrowedBy.Text = _selectedBook.BorrowedBy;
                lblBorrowedBy.Visible = true;
                txtBorrowedBy.Visible = true;
            }

            BtnSave.Text = "Update";
        }

        private void ChkIsBorrowed_CheckedChanged(object? sender, EventArgs e)
        {
            lblBorrowedBy.Visible = chkIsBorrowed.Checked;
            txtBorrowedBy.Visible = chkIsBorrowed.Checked;
        }

        private string? Validation()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) return "Title is required.";
            if (string.IsNullOrWhiteSpace(txtAuthor.Text)) return "Author is required.";
            if (string.IsNullOrWhiteSpace(txtGenre.Text)) return "Genre is required.";
            if (string.IsNullOrWhiteSpace(txtYear.Text)) return "Year is required.";

            if (!int.TryParse(txtYear.Text, out _)) return "Year must be a valid number.";

            if (chkIsBorrowed.Checked && string.IsNullOrWhiteSpace(txtBorrowedBy.Text))
            {
                return "Borrowed By is required when the book is borrowed.";
            }

            return null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var validationMessage = Validation();
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_mode == Mode.Update && _selectedBook != null)
            {
                if (chkIsBorrowed.Checked && !_selectedBook.IsBorrowed)
                {
                    _selectedBook.BorrowedDate = DateTime.Now;
                }
                else if (!chkIsBorrowed.Checked && _selectedBook.IsBorrowed)
                {
                    _selectedBook.BorrowedDate = null;
                    _selectedBook.BorrowedBy = null;
                }

                _selectedBook.Title = txtTitle.Text;
                _selectedBook.Author = txtAuthor.Text;
                _selectedBook.Genre = txtGenre.Text;
                _selectedBook.Year = int.Parse(txtYear.Text);
                _selectedBook.IsBorrowed = chkIsBorrowed.Checked;
                _selectedBook.BorrowedBy = chkIsBorrowed.Checked ? txtBorrowedBy.Text : null;

                this.ProcessedBook = _selectedBook;
            }
            else 
            {
                this.ProcessedBook = new Book
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Genre = txtGenre.Text,
                    Year = int.Parse(txtYear.Text),
                    IsBorrowed = chkIsBorrowed.Checked,
                    BorrowedBy = chkIsBorrowed.Checked ? txtBorrowedBy.Text : null,
                    BorrowedDate = chkIsBorrowed.Checked ? DateTime.Now : null
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
