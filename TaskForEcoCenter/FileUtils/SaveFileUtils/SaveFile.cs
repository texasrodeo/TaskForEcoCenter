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
        private static XDocument GetXMLDocument(List<Book> books)
        {
            XDocument xdoc = new XDocument();
            XElement bookStore = new XElement("bookstore");
            books.ForEach(i => bookStore.Add(getBookXml(i)));
            xdoc.Add(bookStore);
            return xdoc;
            
        }

        public static void Save(List<Book> books, string filename)
        {
            XDocument xDocument = GetXMLDocument(books);
            xDocument.Save(filename);
        }

        private static List<XElement> getAuthors(List<String> authors)
        {
            List<XElement> result = new List<XElement>();
            authors.ForEach(i => result.Add(new XElement("author", i)));
            return result;
        }

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

                   
            xbook.Add(title);
            authors.ForEach(i => xbook.Add(i));
            xbook.Add(year);
            xbook.Add(price);
            return xbook;
        }
    }
}
