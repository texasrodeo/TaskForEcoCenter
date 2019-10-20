using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace TaskForEcoCenter
{
    public partial class AddBookForm : Form
    {
        Book book;

        /// <summary>
        /// Получает созданную пользователем книгу
        /// </summary>
        /// <value>Экземпляр класса книги</value>
        public Book Book
        {
            get
            {
                return book;
            }
        }

        /// <summary>
        /// Проверяет заполненность всех обязательных полей
        /// </summary>
        /// <returns>True, если какое либо обязательное поле не заполнено, иначе False</returns>
        bool checkNotFilling()
        {
            return (TitleTB.Text == "" || AuthorsTB.Text == "" || CategoryTB.Text == ""
                || YearTB.Text == "" || PriceTB.Text == "" || LanguageTB.Text == "");
            
        }

        /// <summary>
        /// Пытается создать экземпляр класса книги по введенным пользователем данным
        /// </summary>
        void createBook()
        {
            if (checkNotFilling())
                MessageBox.Show("Заполните обязательные поля"); //не все обязательные поля заполнены
            else
            {
                string title = TitleTB.Text;
                if (AuthorsTB.Text.Last<Char>() == ';')
                {
                    MessageBox.Show("Недопустимый разделитель в конце строки"); //строка авторов завершена символом ';' , 
                                                                                //что в последствии приведет к созданию пустого автороа

                }
                else
                {
                    List<string> authors = Scripts.getAuthors(AuthorsTB.Text);
                    string category = CategoryTB.Text;
                    int year;
                    if (Int32.TryParse(YearTB.Text, out year)) // корректно ли введен год?
                    {
                        if (year <= DateTime.Now.Year) //книга не из будущего?
                        {
                            double price;
                            if (Double.TryParse(PriceTB.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, 
                                CultureInfo.InvariantCulture, out price)) //корректно ли введена цена?
                            {
                                price = Double.Parse(PriceTB.Text, CultureInfo.InvariantCulture);
                                string language = LanguageTB.Text;
                                string cover;
                                if (CoverTB.Text == "")
                                    cover = null;
                                else
                                    cover = CoverTB.Text;
                                book = new Book(title, authors, category, year, price, language, cover);
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Некорректное значение для цены"); 
                            }

                        }
                        else
                        {
                            MessageBox.Show("Некорректный год");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение для года");
                    }
                }


            }
        }

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            createBook();
        }
    }
}
