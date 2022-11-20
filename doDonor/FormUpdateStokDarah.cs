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
    public partial class FormUpdateStokDarah : Form
    {
        private string targetRegion;
        public FormUpdateStokDarah(string region)
        {
            targetRegion = region;
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            BloodStock stock = new BloodStock(
                cbRegion.Text,
                Int32.Parse(numWbA.Text),
                Int32.Parse(numWbB.Text),
                Int32.Parse(numWbAb.Text),
                Int32.Parse(numWbO.Text),
                Int32.Parse(numTcA.Text),
                Int32.Parse(numTcB.Text),
                Int32.Parse(numTcAb.Text),
                Int32.Parse(numTcO.Text),
                Int32.Parse(numPrcA.Text),
                Int32.Parse(numPrcB.Text),
                Int32.Parse(numPrcAb.Text),
                Int32.Parse(numPrcO.Text),
                dtPickDate.Value
                );
            DbBloodStock dbStock = new DbBloodStock();
            int status = dbStock.Create(stock);
            if (status == 1)
            {
                MessageBox.Show("Permintaan donor darah Anda berhasil dikirimkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Data gagal dikirimkan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUpdateStokDarah_Load(object sender, EventArgs e)
        {
            cbRegion.Text = targetRegion;
        }
    }
}
