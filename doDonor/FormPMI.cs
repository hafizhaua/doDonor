using doDonor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doDonor
{
    public partial class FormPMI : Form
    {
        public FormPMI()
        {
            InitializeComponent();
        }

        private void FormPMI_Load(object sender, EventArgs e)
        {
            if(FormLogin.isAdmin)
            {
                btnAddStock.Visible = true;
            } else
            {
                btnAddStock.Visible = false;
            }
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if(FormLogin.isAdmin)
            {
                FormUpdateStokDarah frm = new FormUpdateStokDarah(cbRegion.Text);
                frm.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblPMI.Text = "Stok Darah UTD PMI " + cbRegion.Text;
            DbBloodStock db = new DbBloodStock();
            Dictionary<string, string> data = db.Search(cbRegion.Text);

            if (data.Count != 0)
            {
                lblDate.Text = DateTime.Parse(data["date_stock"].ToString()).ToString("dd MMMM yyyy");
                lblPMI.Text = "Stok Darah UTD PMI " + data["region"].ToString();

                lblWbA.Text = data["wb_a"].ToString();
                lblWbB.Text = data["wb_b"].ToString();
                lblWbAb.Text = data["wb_ab"].ToString();
                lblWbO.Text = data["wb_o"].ToString();

                lblPrcA.Text = data["prc_a"].ToString();
                lblPrcB.Text = data["prc_b"].ToString();
                lblPrcAb.Text = data["prc_ab"].ToString();
                lblPrcO.Text = data["prc_o"].ToString();

                lblTcA.Text = data["tc_a"].ToString();
                lblTcB.Text = data["tc_b"].ToString();
                lblTcAb.Text = data["tc_ab"].ToString();
                lblTcO.Text = data["tc_o"].ToString();
            } else
            {
                lblPMI.Text = lblDate.Text =
                lblWbA.Text = lblWbB.Text =
                lblWbAb.Text = lblWbO.Text =
                lblPrcA.Text = lblPrcB.Text =
                lblPrcAb.Text = lblPrcO.Text =
                lblTcA.Text = lblTcB.Text =
                lblTcAb.Text = lblTcO.Text = "-";
                MessageBox.Show("Data tidak ditemukan.");
            }
        }
    }
}
