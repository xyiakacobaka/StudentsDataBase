using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Group_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (LastName.Text != string.Empty && FirstName.Text != string.Empty && 
                SecondName.Text != string.Empty && Group.Text != string.Empty)
            {
                bool succes = Int32.TryParse(Group.Text, out int x);
                if(succes && x == 1 || x == 2 ||x == 3 ||x == 4)
                {

                }
                else
                {
                    Form2 Form2 = new Form2();
                    Form2.ShowDialog();
                }
            }
            else
            {
                {
                    Form2 Form2 = new Form2();
                    Form2.ShowDialog();
                }
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
