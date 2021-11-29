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
    public partial class frmRelLucrosDespesas : Form
    {
        public frmRelLucrosDespesas()
        {
            InitializeComponent();
        }

        private void frmRelLucrosDespesas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.contas_pessoais' table. You can move, or remove it, as needed.
            this.contas_pessoaisTableAdapter.Fill(this.lojaDataSet.contas_pessoais);
            // TODO: This line of code loads data into the 'lojaDataSet.contas_pagar' table. You can move, or remove it, as needed.
            this.contas_pagarTableAdapter.Fill(this.lojaDataSet.contas_pagar);
            // TODO: This line of code loads data into the 'lojaDataSet.conta_receber' table. You can move, or remove it, as needed.
            this.conta_receberTableAdapter.Fill(this.lojaDataSet.conta_receber);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contas_pessoaisBindingSource.Filter = "data_pag >= '" + dtInicial.Value.ToShortDateString() + "' and data_pag <= '" + dtFinal.Value.ToShortDateString() + "'";
            contas_pagarBindingSource.Filter = "dta_pag >= '" + dtInicial.Value.ToShortDateString() + "' and dta_pag <= '" + dtFinal.Value.ToShortDateString() + "'";
            conta_receberBindingSource.Filter = "dta_rec >= '" + dtInicial.Value.ToShortDateString() + "' and dta_rec <= '" + dtFinal.Value.ToShortDateString() + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
