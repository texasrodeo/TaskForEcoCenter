using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace TaskForEcoCenter.FileUtils.SaveFileUtils
{
    public static class SaveFile
    {
        /// <summary>
        /// Формирует XML документ по списку книг
        /// </summary>
        /// <param name="books">Список книг</param>
        /// <returns>XML документ содержащий список книг</returns>
        private static XDocument GetXMLDocument(List<Book> books)
        {
            XDocument xdoc = new XDocument();
            XElement bookStore = new XElement("bookstore");
            books.ForEach(i => bookStore.Add(getBookXml(i)));
            xdoc.Add(bookStore);
            return xdoc;
            
        }

        /// <summary>
        /// Сохраняет XML документ по заданному пути
        /// </summary>
        /// <param name="books">Список книг</param>
        /// <param name="filename">Путь к файлу</param>
        public static void Save(List<Book> books, string filename)
        {
            XDocument xDocument = GetXMLDocument(books);
            xDocument.Save(filename);
        }

        /// <summary>
        /// Создает список XElement, содержащий всех авторов данной книги
        /// </summary>
        /// <param name="authors">Список авторов</param>
        /// <returns>Список XElement со всеми авторами</returns>
        private static List<XElement> getAuthors(List<string> authors)
        {
            List<XElement> result = new List<XElement>();
            authors.ForEach(i => result.Add(new XElement("author", i)));
            return result;
        }


        /// <summary>
        /// Создает XML код для каждой книги
        /// </summary>
        /// <param name="book">Экземпляр класса книги, для которого делается XML</param>
        /// <returns>XElement, содержащий информацию о книге</returns>
        private static XElement getBookXml(Book book)
        {
            XElement xbook = new XElement("book");
            XAttribute category = new XAttribute("category", book.Category);
            xbook.Add(category);
            if (book.Cover != null)
            {
                XAttribute cover = new XAttribute("cover", book.Cover);
                xbook.Add(cover);
            }
            XElement title = new XElement("title", book.Title);
            XAttribute lang = new XAttribute("lang", book.Language);
            title.Add(lang);
            List<XElement> authors = getAuthors(book.Author);
            XElement year = new XElement("year", book.Year);       
            XElement price = new XElement("price", book.Price.ToString(CultureInfo.InvariantCulture));

                   
            xbook.Add(title); //добавление в XML названия книги
            authors.ForEach(i => xbook.Add(i)); //добавление в XML всех авторов
            xbook.Add(year); //добавление в XML года выпуска
            xbook.Add(price); //добавление в XML цены
            return xbook;
        }
    }
}
