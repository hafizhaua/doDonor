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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //this.Hide();
            FormLogin formLogin = new FormLogin(this);
            formLogin.TopLevel = false;
            panel1.Controls.Add(formLogin);
            formLogin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formLogin.Dock = DockStyle.Fill;
            formLogin.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBeranda formBeranda = new FormBeranda();
            formBeranda.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
