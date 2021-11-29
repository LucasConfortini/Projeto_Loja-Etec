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
    public partial class frmuser : Form
    {
        public frmuser()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);

        }

        private void usuariosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {


                this.Validate();
                this.usuariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.lojaDataSet);

                MessageBox.Show("Registro Salvo", "Lavest - Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.lojaDataSet.usuarios);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("confirma exclusão do registro atual", "Lavest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuariosBindingSource.RemoveCurrent();
                    usuariosTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("registro não pode ser excluído " + ex.Message);
                this.usuariosTableAdapter.Fill(this.lojaDataSet.usuarios);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
