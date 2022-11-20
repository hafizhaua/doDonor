using doDonor.Models;
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
        private FormUtama formUtama;
        public FormLogin(FormUtama mainForm)
        {
            formUtama = mainForm;
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

        public static Boolean isAdmin = false;


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Admin user = new Admin(tbUname.Text, tbPassword.Text);

            if(user.login())
            {
                isAdmin = true;
                MessageBox.Show("Berhasil login sebagai admin.", "Sukses");
                Hide();
                formUtama.Hide();
                FormBeranda formBeranda = new FormBeranda();

                formBeranda.Show();

            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
 
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
