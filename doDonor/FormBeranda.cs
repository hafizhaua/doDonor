namespace doDonor
{
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
            if (!FormLogin.isAdmin)
                btnLogout.Text = "Login";

            FormHomepage formHomepage = new FormHomepage(this);
            formHomepage.TopLevel = false;
            panel2.Controls.Add(formHomepage);
            formHomepage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formHomepage.Dock = DockStyle.Fill;
            formHomepage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormCari formCari = new FormCari();
            formCari.TopLevel = false;
            panel2.Controls.Add(formCari);
            formCari.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formCari.Dock = DockStyle.Fill;
            formCari.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormPermohonan formPermohonan = new FormPermohonan();  
            formPermohonan.TopLevel = false;
            panel2.Controls.Add(formPermohonan);
            formPermohonan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formPermohonan.Dock = DockStyle.Fill;
            formPermohonan.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormPMI formPMI = new FormPMI();
            formPMI.TopLevel = false;
            panel2.Controls.Add(formPMI);
            formPMI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formPMI.Dock = DockStyle.Fill;
            formPMI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormCariJadwal formCariJadwal = new FormCariJadwal();
            formCariJadwal.TopLevel = false;
            panel2.Controls.Add(formCariJadwal);
            formCariJadwal.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formCariJadwal.Dock = DockStyle.Fill;
            formCariJadwal.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin.isAdmin = false;
            Hide();
            FormUtama formUtama = new FormUtama();
            formUtama.Show();
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormHomepage formHomepage = new FormHomepage(this);
            formHomepage.TopLevel = false;
            panel2.Controls.Add(formHomepage);
            formHomepage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formHomepage.Dock = DockStyle.Fill;
            formHomepage.Show();
        }
    }
}