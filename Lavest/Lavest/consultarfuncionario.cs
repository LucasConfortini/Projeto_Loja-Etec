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
    public partial class consultarfuncionario : Form
    {
        public consultarfuncionario()
        {
            InitializeComponent();
        }

        private void consultarfuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.lojaDataSet.funcionario);
            // TODO: This line of code loads data into the 'lojaDataSet.ViewItensVenda' table. You can move, or remove it, as needed.
            this.viewItensVendaTableAdapter.Fill(this.lojaDataSet.ViewItensVenda);

        }

        private void viewItensVendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            funcionarioBindingSource.Filter = "nome_func like '" + textBox1.Text + "%'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoLocalizado = 0;
            this.Dispose();
        }

        private void funcionarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
