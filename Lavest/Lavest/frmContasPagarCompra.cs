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
    public partial class frmContasPagarCompra : Form
    {
        public frmContasPagarCompra()
        {
            InitializeComponent();
        }

        private void frmContasPagarCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.contas_pagar' table. You can move, or remove it, as needed.
            this.contas_pagarTableAdapter.Fill(this.lojaDataSet.contas_pagar);
            // TODO: This line of code loads data into the 'lojaDataSet.View_ContasPagarCompras' table. You can move, or remove it, as needed.
            this.view_ContasPagarComprasTableAdapter.Fill(this.lojaDataSet.View_ContasPagarCompras);
            view_ContasPagarComprasBindingSource.Filter = "dta_pag is null";

        }

        private void view_ContasPagarComprasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dataPag;
            decimal valorPago=0;
            try
            {
                dataPag= DateTime.Parse(Interaction.InputBox("Confirma a data do Pagamento", "Data Pagamento",DateTime.Now.ToShortDateString(), 500, 500));
                valorPago = decimal.Parse(Interaction.InputBox("Confirma o valor Pago", "Valor Pago",view_ContasPagarComprasDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), 500, 500));                
                contas_pagarTableAdapter.QuitarContaPagCompra(dataPag,valorPago,int.Parse(view_ContasPagarComprasDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                MessageBox.Show("Pagamento Registrado","Lavest",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmContasPagarCompra_Load(sender,e);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente","Lavest",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmContasPagarCompra_Load(sender, e);
            }
        }

        private void view_ContasPagarComprasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }
    }
}
