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
    public partial class FormHomepage : Form
    {
        FormBeranda formBeranda;
        public FormHomepage(FormBeranda frm)
        {
            InitializeComponent();
            formBeranda = frm;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            formBeranda.panel2.Controls.Clear();
            FormPMI formPMI = new FormPMI();    
            formPMI.TopLevel = false;
            formBeranda.panel2.Controls.Add(formPMI);
            formPMI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formPMI.Dock = DockStyle.Fill;
            formPMI.Show();
        }

        private void btnPermohonan_Click(object sender, EventArgs e)
        {
            formBeranda.panel2.Controls.Clear();
            FormPermohonan formPermohonan = new FormPermohonan();
            formPermohonan.TopLevel = false;
            formBeranda.panel2.Controls.Add(formPermohonan);
            formPermohonan.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formPermohonan.Dock = DockStyle.Fill;
            formPermohonan.Show();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            formBeranda.panel2.Controls.Clear();
            FormJadwalPMI formJadwalPMI = new FormJadwalPMI();
            formJadwalPMI.TopLevel = false;
            formBeranda.panel2.Controls.Add(formJadwalPMI);
            formJadwalPMI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formJadwalPMI.Dock = DockStyle.Fill;
            formJadwalPMI.Show();

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            formBeranda.panel2.Controls.Clear();
            FormCari formCari = new FormCari();
            formCari.TopLevel = false;
            formBeranda.panel2.Controls.Add(formCari);
            formCari.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formCari.Dock = DockStyle.Fill;
            formCari.Show();
        }
    }
}
