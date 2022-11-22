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
    public partial class FormCariJadwal : Form
    {
        public FormCariJadwal()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormJadwalPMI frm = new FormJadwalPMI(cbRegion.Text);
            frm.Show();
        }
    }
}
