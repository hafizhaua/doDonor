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
    public partial class ListJadwal : UserControl
    {
        public ListJadwal()
        {
            InitializeComponent();
        }

        private string _PMI;
        private string _lokasiPMI;
        private DateTime _waktuJadwal;
        private Image _gambar;

        [Category("Custom Props")]
        public  string PMI
        {
            get { return _PMI; }
            set { _PMI = value; lblPMI.Text = value;  }
        }

        [Category("Custom Props")]
        public string lokasiPMI
        {
            get { return _lokasiPMI; }
            set { _lokasiPMI = value; lblLokasi.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime waktuJadwal { 
            get { return _waktuJadwal; }
            set { _waktuJadwal = value; lblTanggal.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public Image gambar
        {
            get => _gambar;
            set { _gambar = value; pictureBox1.Image = value; }
        }


    }
}
