using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskForEcoCenter
{
    public partial class ChooseIDForm : Form
    {
         List<int> ID = new List<int>();//коды книг
        int choice;

        /// <summary>
        /// Получает выбранный пользователем код книги
        /// </summary>
        /// <value>Код книги</value>
        public int Choice
        {
            get
            {
                return choice;
            }
        }

        /// <summary>
        /// Заполняет DropDownList, вводя туда все коды существующих книг
        /// </summary>
        /// <returns>Список книг</returns>
        private void constructCB()
        {
            IDChooseCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ID.ForEach(i => IDChooseCB.Items.Add(i));
        }

        public ChooseIDForm(List<int> ID)
        {
            this.ID = ID;            
            InitializeComponent();
            Apply.DialogResult = DialogResult.OK;
            constructCB();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(IDChooseCB.SelectedItem);
        }
    }
}
