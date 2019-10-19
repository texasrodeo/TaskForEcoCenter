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
       
         
        void openFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                ofd.Filter = "xml files (*.xml)|*.xml";

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    books = OpenFile.open(ofd.FileName);
                    MainDGV.RowCount = books.Count;
                    Scripts.outputBooksStore(MainDGV ,books);                
                }
            }
        }



        public MainForm()
        {
            InitializeComponent();
            Scripts.setUpDataGridView(MainDGV);
        }


        private void OpenXMLButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void SaveXMLButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                sfd.Filter = "xml files (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveFile.Save(Scripts.constructBookList(MainDGV), sfd.FileName);
                }
            }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            List<int> ID = new List<int>();
            if(books.Count == 0)
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

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            if(addBookForm.ShowDialog() == DialogResult.OK)
            {
                books.Add(addBookForm.Book);
                Scripts.outputBooksStore(MainDGV, books); 
            }
        }

        private void HTMLReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
                sfd.Filter = "xml files (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    SaveFile.Save(Scripts.constructBookList(MainDGV), sfd.FileName);
                    TransformUtils.transform(sfd.FileName);
                }
            }
        }
    }
}
