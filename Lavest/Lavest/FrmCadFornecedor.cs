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
    public partial class FrmCadFornecedor : Form
    {
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Validate();
                this.fornecedorBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.lojaDataSet);
                fornecedorTableAdapter.Update(lojaDataSet.fornecedor);
                MessageBox.Show("Registro Salvo", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.lojaDataSet.fornecedor);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                    fornecedorBindingSource.RemoveCurrent();
                    fornecedorTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não pode ser excluído " + ex.Message);
                this.fornecedorTableAdapter.Fill(this.lojaDataSet.fornecedor);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fornecedorBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            consultarfornecedor form = new consultarfornecedor();
            form.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
