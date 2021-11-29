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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario form = new FrmCadFuncionario();
            form.ShowDialog();  
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("       Deseja sair?      ", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCadCliente form = new FrmCadCliente();
            form.ShowDialog(); 
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor form = new FrmCadFornecedor();
            form.ShowDialog(); 
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FrmVenda form = new FrmVenda();
            form.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            FrmProduto form = new FrmProduto();
            form.ShowDialog();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarcliente form = new consultarcliente();
            form.ShowDialog();
        }

        private void consultaFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarfuncionario form = new consultarfuncionario();
            form.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void consultaFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarfornecedor form = new consultarfornecedor();
            form.ShowDialog(); 
        }

        private void consultaProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarproduto form = new consultarproduto();
            form.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            frmuser form = new frmuser();
            form.ShowDialog(); 
        }

        private void toolStripButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void relatórioDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (VariaveisGlobais.Nivel=="Funcionário")
            {
                toolStripButton10.Enabled=false;

                toolStripButton2.Enabled = false;
            }
        }

        private void clientesAniversariantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelAniversariantes sagula = new frmRelAniversariantes();
            sagula.ShowDialog();
            sagula.Dispose();
        }

        private void vendasPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelVendas saga = new frmRelVendas();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void lucrosEDespesasPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelLucrosDespesas saga = new frmRelLucrosDespesas();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void produtosEmFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelProdutoFalta saga = new frmRelProdutoFalta();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void produtosEmBaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelProdutoBaixa saga = new frmRelProdutoBaixa();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            FrmCompra saga = new FrmCompra();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void funcionáriosAniversariantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelFuncionarioAniver saga = new frmRelFuncionarioAniver();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void clientesInadimplentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteInad saga = new frmClienteInad();
            saga.ShowDialog();
            saga.Dispose();
        }

        private void produtosMaisVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoMaisVend form = new frmProdutoMaisVend();
            form.ShowDialog();
            form.Dispose();
        }

        private void contasPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconta form = new frmconta();
            form.ShowDialog();
            form.Dispose();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmContasPagarCompra form = new frmContasPagarCompra();
            form.ShowDialog();
            form.Dispose();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuitarContaReceber form = new frmQuitarContaReceber();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
