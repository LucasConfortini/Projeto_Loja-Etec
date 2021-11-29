using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lavest
{
    public partial class frmQuitarContaReceber : Form
    {
        public frmQuitarContaReceber()
        {
            InitializeComponent();
        }

        private void frmQuitarContaReceber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.conta_receber' table. You can move, or remove it, as needed.
            this.conta_receberTableAdapter.Fill(this.lojaDataSet.conta_receber);
            // TODO: This line of code loads data into the 'lojaDataSet.View_ContaReceber' table. You can move, or remove it, as needed.
            this.view_ContaReceberTableAdapter.Fill(this.lojaDataSet.View_ContaReceber);
            view_ContaReceberBindingSource.Filter = "   dta_rec is null";


        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            this.view_ContaReceberTableAdapter.Fill(this.lojaDataSet.View_ContaReceber);
            view_ContaReceberBindingSource.Filter = "nome_cli like '" + txtNomeCliente.Text + "%' and dta_rec is null";
        }

        private void view_ContaReceberDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            decimal valorRecebido = 0;
            try
            {
                
                valorRecebido = decimal.Parse(Interaction.InputBox("Confirma o valor recebido", "Valor recebido", view_ContaReceberDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), 500, 500));
                conta_receberTableAdapter.QuitarContaReceber(DateTime.Now, valorRecebido, int.Parse(view_ContaReceberDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                MessageBox.Show("Recebimento Registrado", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCliente_TextChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCliente_TextChanged(sender, e);
            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }
    }
}
