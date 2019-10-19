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
         List<int> ID = new List<int>();
        int choice;

        public int Choice
        {
            get
            {
                return choice;
            }
        }

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
