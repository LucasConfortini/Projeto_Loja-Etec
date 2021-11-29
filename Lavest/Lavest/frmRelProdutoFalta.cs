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
    public partial class frmRelProdutoFalta : Form
    {
        public frmRelProdutoFalta()
        {
            InitializeComponent();
        }

        private void frmRelProdutoFalta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.View_ProdutosFalta' table. You can move, or remove it, as needed.
            this.View_ProdutosFaltaTableAdapter.Fill(this.lojaDataSet.View_ProdutosFalta);

            this.reportViewer1.RefreshReport();
        }
    }
}
