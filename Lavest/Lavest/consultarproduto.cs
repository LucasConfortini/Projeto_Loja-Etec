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
    public partial class consultarproduto : Form
    {
        public consultarproduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);

        }

        private void consultarproduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lojaDataSet.produto);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produtoBindingSource.Filter = "desc_prod like '" + textBox1.Text + "%'";
        }

        private void produtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void produtoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VariaveisGlobais.CodigoLocalizado = int.Parse(produtoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                VariaveisGlobais.CodigoLocalizado = 0;

            }

            this.Dispose();
        }
    }
}
