using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pluto
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Form3().Close();
            new Form2().Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new Form3().Close();
            new Form2().Show();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            new Form3().Hide(); // Hide the current form (Form3)
            new Form2().Show(); // Show the next form (Pluto)
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            label3.Text = Form2.password;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
