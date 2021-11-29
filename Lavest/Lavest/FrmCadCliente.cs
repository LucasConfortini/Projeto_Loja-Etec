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
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.lojaDataSet);
                clienteTableAdapter.Update(lojaDataSet.cliente);
                MessageBox.Show("Registro Salvo", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDataSet.cliente);

        }

        private void nATURA_CLITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "Lavest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Registro não pode ser excluído " );
                this.clienteTableAdapter.Fill(this.lojaDataSet.cliente);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
             
                
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            consultarcliente localizar = new consultarcliente();
            localizar.ShowDialog();

            if (VariaveisGlobais.CodigoLocalizado != 0)
            {
                clienteBindingSource.Position = clienteBindingSource.Find("COD_CLI", VariaveisGlobais.CodigoLocalizado);
            }  
        }

        private void txtnatu_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
