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
        private string cover;

        /// <summary>
        /// Получает название книги
        /// </summary>
        /// <value>Название книги</value>
        public string Title { get; set; }



        public List<String> Authors { get; set; }



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
        public string Cover {
            get
            {
                if (cover != null)
                    return cover;
                else
                    return noCoverInfo;
            }
            set 
            {
                cover = value;
            }

        }

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
            result[6] = Cover;
            return result;
        }


        /// <summary>
        /// Получает список авторов книги в виде строки
        /// </summary>
        /// <returns>Список авторов книги</returns>
        public string AuthorsToString()
        {
            return getAuthors();
        }

        /// <summary>
        /// Возвращает строку со всеми авторами книги
        /// </summary>
        /// <returns>Строка, содержащая всех авторов</returns>
        string getAuthors()
        {
            var result = "";
            Authors.ForEach(i => result += i + ";");
            result = result.Remove(result.Length - 1);
            return result; 
        }

        public Book(string title, List<String> author, string category, int year, double price, string language, string cover)
        {
            this.Title = title;
            this.Authors = author;
            this.Category = category;
            this.Year =year;
            this.Price = price;
            this.Language = language;
            this.Cover = cover;
        }

        public Book()
        {
            Authors = new List<string>();
        }
    }
}
