using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using TaskForEcoCenter.FileUtils.OpenFileUtils;
using TaskForEcoCenter.FileUtils.SaveFileUtils;
using TaskForEcoCenter.FileUtils.XSLTransform;


namespace TaskForEcoCenter
{
    public partial class MainForm : Form
    {
        static List<Book> books = new List<Book>();


        /// <summary>
        /// Открывает и читает выбранный XML файл, и строит по нему список книг 
        /// </summary>
        void openFile() 
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                ofd.Filter = "xml files (*.xml)|*.xml";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    books = OpenFile.read(ofd.FileName); //открытие и чтение файла
                    
                    Scripts.outputBooksStore(MainDGV ,books);  //вывод информации на экран              
                }
            }
        }

        /// <summary>
        /// СОхраняет информацию в DataGridView в выбранный XML файл
        /// </summary>
        void saveFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                sfd.Filter = "xml files (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveFile.Save(Scripts.constructBookList(MainDGV), sfd.FileName); //сохранение файла
                }
            }
        }

        /// <summary>
        /// Удаляют книгу с выбранным пользователем кодом
        /// </summary>
        void deleteREcord()
        {
            List<int> ID = new List<int>();
            if (books.Count == 0)
            {
                MessageBox.Show("Список книг пуст");
            }
            else
            {
                for (int i = 0; i < MainDGV.RowCount; i++)
                {
                    ID.Add(Convert.ToInt32(MainDGV[0, i].Value));
                }
                ChooseIDForm chooseIDForm = new ChooseIDForm(ID);
                if (chooseIDForm.ShowDialog() == DialogResult.OK)
                {
                    books.RemoveAt(chooseIDForm.Choice);
                    Scripts.outputBooksStore(MainDGV, books);
                }
            }
        }

        /// <summary>
        /// Добавляет в список новую книгу
        /// </summary>
        void addRecord()
        {
            AddBookForm addBookForm = new AddBookForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                books.Add(addBookForm.Book); //добавление созданной книги к списку уже существующих
                Scripts.outputBooksStore(MainDGV, books);  //вывод новой информации на экран
            }
        }

        /// <summary>
        /// Сохраняет текущее состояние DataGridView в XML файл и строит по нему html файл
        /// </summary>
        void htmlReport()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                sfd.Filter = "xml files (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveFile.Save(Scripts.constructBookList(MainDGV), sfd.FileName); //создание xml файла содержащего текущую информацию на экране
                    TransformUtils.transform(sfd.FileName); //создание html страницы по этому файлу
                }
            }
        }
    



        public MainForm()
        {
            InitializeComponent();
            //Scripts.setUpDataGridView(MainDGV); //начальная подготовка DataGridView к работе
        }


        private void OpenXMLButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void SaveXMLButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            deleteREcord();
           
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void HTMLReport_Click(object sender, EventArgs e)
        {
            htmlReport();
        }
    }
}
