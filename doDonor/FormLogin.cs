using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doDonor
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "Admin" & textBox1.Text =="Admin")
            {
                this.Hide();
                FormBeranda formBeranda = new FormBeranda();
                formBeranda.Show();

            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
 
    }
    }
}
