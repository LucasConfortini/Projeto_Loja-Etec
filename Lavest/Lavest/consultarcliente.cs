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
    public partial class consultarcliente : Form
    {
        public consultarcliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);

        }

        private void frmLocalizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDataSet.cliente);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "nome_cli like '" + textBox1.Text + "%'";
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VariaveisGlobais.CodigoLocalizado = int.Parse(clienteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                VariaveisGlobais.CodigoLocalizado = 0;
                
            }

            this.Dispose();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
