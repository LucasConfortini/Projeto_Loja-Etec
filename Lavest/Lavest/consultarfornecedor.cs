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
    public partial class consultarfornecedor : Form
    {
        public consultarfornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);

        }

        private void consultarfornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.lojaDataSet.fornecedor);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fornecedorBindingSource.Filter = "nome_forn like '" + textBox1.Text + "%'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void fornecedorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
