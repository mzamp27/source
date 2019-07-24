using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicEventForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _currentIndex = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
           
            switch (_currentIndex)
            {
                case 0:
                    tabControl.SelectTab(tabPage2);
                    break;
                case 1:
                    tabControl.SelectTab(tabPage3);
                    break;
                case 2:  //whatever that last number really is
                    tabControl.SelectTab(tabPage1);  //wrap back to the first page?  or exit?
                    _currentIndex = 0;
                    return;
            }

            _currentIndex++;
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }
    


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
