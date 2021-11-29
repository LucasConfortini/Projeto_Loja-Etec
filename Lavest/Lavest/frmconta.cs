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
    public partial class frmconta : Form
    {
        public frmconta()
        {
            InitializeComponent();
        }

        private void contas_pessoaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contas_pessoaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);
            MessageBox.Show("Alterações registradas com sucesso");
            

        }

        private void frmconta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.contas_pessoais' table. You can move, or remove it, as needed.
            

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.contas_pessoaisTableAdapter.Fill(this.lojaDataSet.contas_pessoais);
            contas_pessoaisBindingSource.Filter = "data_pag is null";
            toolStripButton2.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.contas_pessoaisTableAdapter.Fill(this.lojaDataSet.contas_pessoais);
            contas_pessoaisBindingSource.Filter = "data_pag is not null";
            toolStripButton2.Enabled=false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            contas_pessoaisBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "Lavest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contas_pessoaisBindingSource.RemoveCurrent();
                    contas_pessoaisTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Registro não pode ser excluído ");
                this.contas_pessoaisTableAdapter.Fill(this.lojaDataSet.contas_pessoais);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
