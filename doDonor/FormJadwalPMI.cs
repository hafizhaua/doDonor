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
       
        public FormJadwalPMI()
        {
            InitializeComponent();
        }

        private void FormJadwalPMI_Load(object sender, EventArgs e)
        {
            DbSchedule dbSchedule = new DbSchedule();
            populateItems(dbSchedule);
        }

        private void populateItems(DbSchedule dbSchedule)
        {
            List<Schedule> listSchedule = dbSchedule.ReadSchedule();

            ListJadwal[] listJadwal = new ListJadwal[listSchedule.Count];
            int i = 0;
            foreach(Schedule schedule in listSchedule) 
            {
                listJadwal[i] = new ListJadwal();
                listJadwal[i].PMI = schedule.Region;
                listJadwal[i].lokasiPMI = schedule.Location;
                listJadwal[i].waktuJadwal = schedule.DateEvent;

                scrollPanel.Controls.Add(listJadwal[i]);
                i++;
            }


        }
    }
}
