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

        public Book Book
        {
            get
            {
                return book;
            }
        }

        bool checkNotFilling()
        {
            return (TitleTB.Text == "" || AuthorsTB.Text == "" || CategoryTB.Text == ""
                || YearTB.Text == "" || PriceTB.Text == "" || LanguageTB.Text == "");
            
        }

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (checkNotFilling())
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                
                string title = TitleTB.Text;
                if(AuthorsTB.Text.Last<Char>() == ';')
                {
                    MessageBox.Show("Недопустимый разделитель в конце строки");
                
                }
                else
                {
                    List<string> authors = Scripts.getAuthors(AuthorsTB.Text);
                    string category = CategoryTB.Text;
                    int year;
                    if (Int32.TryParse(YearTB.Text, out year))
                    {
                        if (year <= DateTime.Now.Year)
                        {
                            double price;
                            if (Double.TryParse(PriceTB.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out price))
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
    }
}
