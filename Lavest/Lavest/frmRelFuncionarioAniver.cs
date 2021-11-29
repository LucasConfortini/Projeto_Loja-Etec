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
    public partial class frmRelFuncionarioAniver : Form
    {
        public frmRelFuncionarioAniver()
        {
            InitializeComponent();
        }

        private void frmRelFuncionarioAniver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.View_FuncionariosAniversariantes' table. You can move, or remove it, as needed.
            this.View_FuncionariosAniversariantesTableAdapter.Fill(this.lojaDataSet.View_FuncionariosAniversariantes);

            this.reportViewer1.RefreshReport();
        }
    }
}
