using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_III
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms["Form2"] != null)
            {
                Form form2 = Application.OpenForms["Form2"];
                form2.Hide();
            }

            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Form2"] != null)
            {
                Form form2 = Application.OpenForms["Form2"];
                form2.Hide();
            }

            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["Form2"] != null)
            {
                Form form2 = Application.OpenForms["Form2"];
                form2.Hide();
            }

            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
