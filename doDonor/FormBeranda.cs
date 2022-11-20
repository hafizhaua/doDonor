namespace doDonor
{
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
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
            FormJadwalPMI formJadwalPMI = new FormJadwalPMI();
            //formJadwalPMI.TopLevel = false;
            //panel2.Controls.Add(formJadwalPMI);
            //formJadwalPMI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //formJadwalPMI.Dock = DockStyle.Fill;
            formJadwalPMI.Show();
        }
    }
}