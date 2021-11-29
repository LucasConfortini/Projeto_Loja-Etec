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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.lojaDataSet);
                MessageBox.Show("Registro Salvo", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lojaDataSet.produto);

        }

        private void desc_prodTextBox_TextChanged(object sender, EventArgs e)
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
                    produtoBindingSource.RemoveCurrent();
                    produtoTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não pode ser excluído " + ex.Message);
                this.produtoTableAdapter.Fill(this.lojaDataSet.produto);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            consultarproduto form = new consultarproduto();
            form.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
