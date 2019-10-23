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
        /// <summary>
        /// Вывод списка книг в DataGridView
        /// <param name="dgv">DataGridView c которой будет происходить работа</param>
        /// <param name="books">Список книг информацию о которых будем выводить</param>
        /// </summary>
        public static void outputBooksStore(DataGridView dgv, List<Book> books)
        {
            int counter = 0;
            var columns = from book in books
                          select new
                          {
                              Number = ++counter,
                              Title = book.Title,
                              Authors = book.AuthorsToString(),
                              Category = book.Category,
                              Year = book.Year,
                              Price = book.Price,
                              Language = book.Language,
                              Cover = book.Cover
                          };
            dgv.DataSource = columns.ToList();

        }

        /// <summary>
        /// Получает список авторов книги
        /// <param name="authors">строка со всеми авторами книги</param>
        /// </summary>
        /// <returns>Список всех авторов</returns>
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

        /// <summary>
        /// Получает список книг из DataGridView
        ///<param name="dgv">DataGridView из которой получаем информацию</param>
        /// </summary>
        /// <returns>Список всех книг</returns>
        public static List<Book> constructBookList(DataGridView dgv)
        {
            List<Book> books = new List<Book>();
            for (int i = 0; i < dgv.RowCount; i++)
            {
               // string title = dgv[1, i].Value.ToString();
                string title = dgv[dgv.Columns["Title"].Index,i].Value.ToString();
                List<string> authors = getAuthors(dgv[dgv.Columns["Authors"].Index, i].Value.ToString());
                string category = dgv[dgv.Columns["Category"].Index, i].Value.ToString();
                int year = Convert.ToInt32(dgv[dgv.Columns["Year"].Index, i].Value.ToString());
                double price = Double.Parse(dgv[dgv.Columns["Price"].Index, i].Value.ToString().Replace(',','.'), CultureInfo.InvariantCulture);
                string language = dgv[dgv.Columns["Language"].Index, i].Value.ToString();
                string cover;
                if (dgv[dgv.Columns["Cover"].Index, i].Value.ToString() != Book.NoCoverInfo)
                {
                    cover = dgv[dgv.Columns["Cover"].Index, i].Value.ToString();
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
