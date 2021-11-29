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
    public partial class frmClienteInad : Form
    {
        public frmClienteInad()
        {
            InitializeComponent();
        }

        private void frmClienteInad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.View_ClientesInadimplentes' table. You can move, or remove it, as needed.
            this.View_ClientesInadimplentesTableAdapter.Fill(this.lojaDataSet.View_ClientesInadimplentes);

            this.reportViewer1.RefreshReport();
        }
    }
}
