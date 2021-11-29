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
    public partial class frmRelProdutoBaixa : Form
    {
        public frmRelProdutoBaixa()
        {
            InitializeComponent();
        }

        private void frmRelProdutoBaixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.View_ProdutosemBaixa' table. You can move, or remove it, as needed.
            this.View_ProdutosemBaixaTableAdapter.Fill(this.lojaDataSet.View_ProdutosemBaixa);

            this.reportViewer1.RefreshReport();
        }
    }
}
