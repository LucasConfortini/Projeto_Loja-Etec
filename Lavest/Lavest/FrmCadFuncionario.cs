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
    public partial class FrmCadFuncionario : Form
    {
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.lojaDataSet);
                MessageBox.Show("Registro Salvo", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.lojaDataSet.funcionario);

        }

        private void nASC_FUNCMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
                    funcionarioBindingSource.RemoveCurrent();
                    funcionarioTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não pode ser excluído " + ex.Message);
                this.funcionarioTableAdapter.Fill(this.lojaDataSet.funcionario);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            funcionarioBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            consultarfuncionario form = new consultarfuncionario();
            form.ShowDialog();
        }

        private void funcionarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
