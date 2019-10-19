using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskForEcoCenter
{
    public class Book
    {
        private static string noCoverInfo = "No info about cover";

        public string Title { get; set; }
        public List<String> Author { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public string Language { get; set; }

        public string Cover { get; set; }

        public static string NoCoverInfo { get
            {
                return noCoverInfo;
            }
        }

        new public string[] ToString()
        {
            string[] result = new string[7];
            result[0] = Title;
            result[1] = getAuthors();
            result[2] = Category;
            result[3] = Year.ToString();
            result[4] = Price.ToString();
            result[5] = Language;
            if(Cover != null)
            {
                result[6] = Cover;
            }
            else
            {
                result[6] = noCoverInfo;
            }
            return result;
        }

        string getAuthors()
        {
            var result = "";
            Author.ForEach(i => result += i + ";");
            result = result.Remove(result.Length - 1);
            return result; 
        }

        public Book(string title, List<String> author, string category, int year, double price, string language, string cover)
        {
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.Year =year;
            this.Price = price;
            this.Language = language;
            this.Cover = cover;
        }

        public Book()
        {
            Author = new List<string>();
        }
    }
}
