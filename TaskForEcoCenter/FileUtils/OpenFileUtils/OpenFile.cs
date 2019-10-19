using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Globalization;


namespace TaskForEcoCenter.FileUtils.OpenFileUtils
{
    public static class OpenFile
    {
        public static List<Book> open(string fileName)
        {
            List<Book> books = new List<Book>();
            XmlDocument xml = new XmlDocument();
            xml.Load(fileName);
            XmlElement root = xml.DocumentElement;
            foreach(XmlNode xmlNode in root)
            {
                Book book = new Book();
                XmlNode attr = xmlNode.Attributes.GetNamedItem("category");
                if (attr != null)
                    book.Category = attr.Value;
                attr = xmlNode.Attributes.GetNamedItem("cover");
                if (attr != null)
                    book.Cover = attr.Value;
                else
                    book.Cover = null;
                foreach (XmlNode childnode in xmlNode.ChildNodes)
                {
                    if (childnode.Name == "title")
                    {
                        book.Title = childnode.InnerText;
                        XmlNode lang = childnode.Attributes.GetNamedItem("lang");
                        if (lang != null)
                            book.Language = lang.Value;
                    }
                       

                    if (childnode.Name == "author")
                        book.Author.Add(childnode.InnerText);

                    if (childnode.Name == "year")
                        book.Year = Convert.ToInt32(childnode.InnerText);

                    if (childnode.Name == "price")
                        book.Price = Double.Parse(childnode.InnerText, CultureInfo.InvariantCulture);
                    

                }
                books.Add(book);
            }
            return books;
        }
    }
}
