using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lavest
{
    public partial class frmRelVendas : Form
    {
        public frmRelVendas()
        {
            InitializeComponent();
        }

        private void frmRelVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.View_VendasCliFunc' table. You can move, or remove it, as needed.
            this.View_VendasCliFuncTableAdapter.Fill(this.lojaDataSet.View_VendasCliFunc);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_VendasCliFuncBindingSource.Filter = "dta_venda >= '" + dtInicial.Value.ToShortDateString() + "' and dta_venda <= '" + dtFinal.Value.ToShortDateString() + "'";
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
