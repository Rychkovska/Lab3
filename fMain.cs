using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
	public partial class fMain : Form
	{
		public fMain()
		{
			InitializeComponent();
		}

		private void btnAddBook_Click(object sender, EventArgs e)
		{
			Book book = new Book();
			fBook ft = new fBook(book);
			if (ft.ShowDialog() == DialogResult.OK)
			{
				tbBooksInfo.Text +=
				string.Format("Назва книги: {0}, Автор: {1},  Мова: {2}, Рік видання: {3}, Жанр: "+
				" {4}, Видавець: {5}, Кількість сторінок {6}, КІлькість слів {7} " +
				"Кількість слів на одній сторінці: {8}, {9}.\r\n",
				book.Title, book.Author, book.Language, book.YearPublished, book.Genre,
				book.Publisher, book.NumPages,  book.WordCount,
				book.CalculateWordsPerPage(), book.IsLargeBook());
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				Application.Exit();
		}
	}
}
