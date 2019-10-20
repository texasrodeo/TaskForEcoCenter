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

        /// <summary>
        /// Получает название книги
        /// </summary>
        /// <value>Название книги</value>
        public string Title { get; set; }

        /// <summary>
        /// Получает список авторов книги
        /// </summary>
        /// <value>Список авторов книги</value>
        public List<String> Author { get; set; }

        /// <summary>
        /// Получает категорию книги
        /// </summary>
        /// <value>Категория книги</value>
        public string Category { get; set; }

        /// <summary>
        /// Получает год выпуска книги
        /// </summary>
        /// <value>Год выпуска книги</value>
        public int Year { get; set; }

        /// <summary>
        /// Получает цену книги
        /// </summary>
        /// <value>Цена книги</value>
        public double Price { get; set; }

        /// <summary>
        /// Получает язык написания книги
        /// </summary>
        /// <value>Язык написания книги</value>
        public string Language { get; set; }

        /// <summary>
        /// Получает информацию об обложке книги
        /// </summary>
        /// <value>Информацию об обложке книги</value>
        public string Cover { get; set; }

        /// <summary>
        /// Получает строку для сигнализирования отсутствия информации об обложке
        /// </summary>
        /// <value>Строка с сообщением об отсутствии информации об обложке</value>
        public static string NoCoverInfo { get
            {
                return noCoverInfo;
            }
        }

        /// <summary>
        /// Новый метод ToString() возвращающий всю информацию о книге
        /// </summary>
        /// <returns>Массив строк все всей информацией о книге</returns>
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

        /// <summary>
        /// Возвращает строку со всеми авторами книги
        /// </summary>
        /// <returns>Строка, содержащая всех авторов</returns>
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
