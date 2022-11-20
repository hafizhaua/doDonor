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
    public partial class FormJadwalPMI : Form
    {
        public FormJadwalPMI()
        {
            InitializeComponent();
        }

        private void FormJadwalPMI_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            ListJadwal[] listJadwal = new ListJadwal[20];
            for (int i = 0; i < listJadwal.Length; i++)
            {
                listJadwal[i] = new ListJadwal();
                listJadwal[i].PMI = "Get data somewhere";
                listJadwal[i].lokasiPMI = "Get data somewhere";
                listJadwal[i].waktuJadwal = DateTime.Now;
                //if (flowLayoutPanel1.Controls.Count > 0)
                //{
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                //{

                //}
                scrollPanel.Controls.Add(listJadwal[i]);
            }
        }
    }
}
