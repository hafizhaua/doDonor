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
using System.Xml.Linq;

namespace doDonor
{
    public partial class FormJadwalPMI : Form
    {
        private string? region;
        public FormJadwalPMI(string reg)
        {
            region = reg;
            InitializeComponent();
        }

        private void FormJadwalPMI_Load(object sender, EventArgs e)
        {
            lblRegion.Text = region;
            populateItems();
            if (region == "Semua" || !FormLogin.isAdmin)
            {
                btnAddSchedule.Enabled = false;
                btnAddSchedule.Visible = false;
            }
            else
            {
                btnAddSchedule.Enabled = true;
                btnAddSchedule.Visible = true;
            }
            
        }

        private void populateItems()
        {
            DbSchedule dbSchedule = new DbSchedule();
            List<Schedule> listSchedule = dbSchedule.ReadSchedule(region);

            ListJadwal[] listJadwal = new ListJadwal[listSchedule.Count];
            int i = 0;
            foreach(Schedule schedule in listSchedule) 
            {
                listJadwal[i] = new ListJadwal();
                listJadwal[i].id = schedule.IdSchedule;
                listJadwal[i].PMI = schedule.Region;
                listJadwal[i].lokasiPMI = schedule.Location;
                listJadwal[i].waktuJadwal = schedule.DateEvent;
                listJadwal[i].alamat = schedule.Address;

                scrollPanel.Controls.Add(listJadwal[i]);
                i++;
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (FormLogin.isAdmin)
            {
                FormTambahJadwal frm = new FormTambahJadwal(region);
                frm.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            scrollPanel.Controls.Clear();
            populateItems();
        }
    }
}
