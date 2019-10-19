using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TaskForEcoCenter
{
    public static class Scripts
    {
        public static void setUpDataGridView(DataGridView dgv)
        {
            dgv.ColumnCount = 8;
            dgv.Columns[0].Name = "ID книги";
            dgv.Columns[1].Name = "Книга";
            dgv.Columns[2].Name = "Автор";
            dgv.Columns[2].Width = 300;
            dgv.Columns[3].Name = "Категория";
            dgv.Columns[4].Name = "Год";
            dgv.Columns[5].Name = "Цена";
            dgv.Columns[6].Name = "Язык";
            dgv.Columns[7].Name = "Обложка";
        }

        private static void outputBook(DataGridView dgv, Book book, int rownumber)
        {
            string[] info = book.ToString();
            dgv[0, rownumber].Value = rownumber.ToString();
            int k = 1;
            for (int i = 0; i < info.Length; i++)
            {
                dgv[k++, rownumber].Value = info[i];
            }
        }

        public static void outputBooksStore(DataGridView dgv, List<Book> books)
        {
            if(books.Count == 0)
            {
                dgv.Rows.Clear();
                dgv.RowCount = 1;
            }
            else
            {
                dgv.RowCount = books.Count;
            }
            books.ForEach(i => outputBook(dgv, i, books.IndexOf(i)));

        }

        public static List<String> getAuthors(string authors)
        {
            List<string> result = new List<string>();
            string[] splitedAuthors = authors.Split(';');
            for (int i = 0; i < splitedAuthors.Length; i++)
            {
                result.Add(splitedAuthors[i]);
            }
            return result;
        }

        public static List<Book> constructBookList(DataGridView dgv)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                string title = dgv[1, i].Value.ToString();
                List<string> authors = getAuthors(dgv[2, i].Value.ToString());
                string category = dgv[3, i].Value.ToString();
                int year = Convert.ToInt32(dgv[4, i].Value.ToString());
                double price = Double.Parse(dgv[5, i].Value.ToString().Replace(',','.'), CultureInfo.InvariantCulture);
                string language = dgv[6, i].Value.ToString();
                string cover;
                if (dgv[7, i].Value.ToString() != Book.NoCoverInfo)
                {
                    cover = dgv[7, i].Value.ToString();
                }
                else
                {
                    cover = null;
                }
                books.Add(new Book(title, authors, category, year, price, language, cover));
            }
            return books;
        }
    }
}
