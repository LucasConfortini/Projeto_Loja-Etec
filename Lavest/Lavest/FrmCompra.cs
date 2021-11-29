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
    public partial class FrmCompra : Form
    {
        int codItemRemover = 0, qtdRemover = 0, codProdutoRemover;
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);
            try
            {
                this.Validate();
                this.compraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.lojaDataSet);
                MessageBox.Show("Registro Salvo", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxc.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.contas_pagar' table. You can move, or remove it, as needed.
            this.contas_pagarTableAdapter.Fill(this.lojaDataSet.contas_pagar);
            // TODO: This line of code loads data into the 'lojaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lojaDataSet.produto);
            // TODO: This line of code loads data into the 'lojaDataSet.itens_compra' table. You can move, or remove it, as needed.
            this.itens_compraTableAdapter.Fill(this.lojaDataSet.itens_compra);
            // TODO: This line of code loads data into the 'lojaDataSet.View_ItensCompra' table. You can move, or remove it, as needed.
            this.view_ItensCompraTableAdapter.Fill(this.lojaDataSet.View_ItensCompra);
            // TODO: This line of code loads data into the 'lojaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.lojaDataSet.fornecedor);
            // TODO: This line of code loads data into the 'lojaDataSet.compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.lojaDataSet.compra);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBoxc.Enabled = true;
            sit_compraComboBox.Text = "Aberta";
            valor_totalTextBox.Text = "0";

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "Lavest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    compraBindingSource.RemoveCurrent();
                    compraTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não pode ser excluído " + ex.Message);
                this.compraTableAdapter.Fill(this.lojaDataSet.compra);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            compraBindingSource.CancelEdit();
            groupBoxc.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBoxc.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valor_totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodpro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcodpro.Text!="")
                {

                    produtoBindingSource.Filter = "cod_prod=" + txtcodpro.Text;
                    if (produtoBindingSource.Count == 1)
                    {
                        DataRowView produto = (DataRowView)produtoBindingSource.Current;

                        txtNomeProduto.Text = produto["desc_prod"].ToString();
                        txtpreco.Text = produto["custo_prod"].ToString();
                        txtestoque.Text = produto["qtd_prod"].ToString();
                        txtqtde.Focus();
                    }
                    else
                    {
                        btn_localizar_Click(sender, e);
                    }    
                }
                
                

            }
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            consultarproduto sagula = new consultarproduto();
            sagula.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado != 0)
            {

                produtoBindingSource.Filter = "cod_prod=" + VariaveisGlobais.CodigoLocalizado;
                DataRowView produto = (DataRowView)produtoBindingSource.Current;
                txtcodpro.Text = VariaveisGlobais.CodigoLocalizado.ToString();
                txtNomeProduto.Text = produto["desc_prod"].ToString();
                txtpreco.Text = produto["custo_prod"].ToString();
                txtestoque.Text = produto["qtd_prod"].ToString();
                txtqtde.Focus();
            }
        }

        private void txtqtde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpreco.Focus();
            }
        }

        private void txtpreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int qtd, estoque, codprod;
                codprod = int.Parse(txtcodpro.Text);
                qtd = int.Parse(txtqtde.Text);
                estoque = int.Parse(txtestoque.Text);

                    itens_compraTableAdapter.InserirItemCompra(int.Parse(cod_compraTextBox.Text), int.Parse(txtcodpro.Text), int.Parse(txtqtde.Text), decimal.Parse(txtpreco.Text));

                produtoTableAdapter.EntradaEstoque(qtd, codprod);
                produtoTableAdapter.AtualizarPrecoCusto(decimal.Parse(txtpreco.Text),codprod);

                    Atualizar_grid();
                    txtcodpro.Clear();
                    txtNomeProduto.Clear();
                    txtqtde.Clear();
                    txtpreco.Clear();
                    txtestoque.Clear();
                    txtcodpro.Focus();
              
            }
            catch (Exception)
            {


            }
        }

        private void view_ItensCompraDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codItemRemover = int.Parse(view_ItensCompraDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                qtdRemover = int.Parse(view_ItensCompraDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                codProdutoRemover = int.Parse(view_ItensCompraDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            catch (Exception)
            {
                codItemRemover = 0;

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (codItemRemover == 0)
            {
                MessageBox.Show("Clique no item a ser removido", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                itens_compraTableAdapter.RemoverItemCompra(codItemRemover);//remover do itens
                produtoTableAdapter.BaixaEstoque(qtdRemover, codProdutoRemover);//volta o estoque
                codProdutoRemover = 0;
                codItemRemover = 0;
                qtdRemover = 0;
                Atualizar_grid();
            }
        }

        private void groupBoxc_Enter(object sender, EventArgs e)
        {

        }



        public void Atualizar_grid()
        {
            if (cod_compraTextBox.Text != "")
            {

                produtoTableAdapter.Fill(lojaDataSet.produto);

                view_ItensCompraTableAdapter.Fill(lojaDataSet.View_ItensCompra);
                view_ItensCompraBindingSource.Filter = "cod_compra = " + cod_compraTextBox.Text;

                //view_TotalVendaTableAdapter.Fill(lojaDataSet.View_TotalVenda);
                //view_TotalVendaBindingSource.Filter = "cod_compra= " + cod_compraTextBox.Text;

                if (sit_compraComboBox.Text == "Finalizada")
                {
                    btnFinalizar.Enabled = false;
                    toolStripButton2.Enabled = false;
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                else
                {
                    btnFinalizar.Enabled = true;
                    toolStripButton2.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                }


                //MessageBox.Show(viewItensVendaBindingSource.Count.ToString());
            }
            else
            {
                view_ItensCompraBindingSource.Filter = "cod_compra = 0";
            }
        }

        private void cod_compraTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_grid();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            decimal ValorTotal=0;
            DateTime dataPag;
            try
            {
                ValorTotal= decimal.Parse(Interaction.InputBox("Confirma o valor total do boleto","Valor total do Boleto",valor_totalTextBox.Text,500,500));
            
            }
            catch (Exception)
            {
                ValorTotal=0;
                MessageBox.Show("Valor não informado","Lavest",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            if (ValorTotal>0)

	        {
		         if (MessageBox.Show("Pagamento foi a Vista","Lavest",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
	            {
		            dataPag= DateTime.Parse(Interaction.InputBox("Informe a data do Pagamento","data do Pagamento",DateTime.Now.ToShortDateString(),500,500));    
                    contas_pagarTableAdapter.INserirContaPAgar(dataPag,ValorTotal,dataPag,ValorTotal,int.Parse(cod_compraTextBox.Text));

	            }

                else //boleto prazo
	            {
                     dataPag= DateTime.Parse(Interaction.InputBox("Informe a data de vencimento","data de vencimento","",500,500));    
                    contas_pagarTableAdapter.INserirContaPAgar(dataPag,ValorTotal,null,null,int.Parse(cod_compraTextBox.Text));

	            }
                MessageBox.Show("Conta registrada","Lavest",MessageBoxButtons.OK,MessageBoxIcon.Information);


                sit_compraComboBox.Text="Finalizada";
                compraBindingNavigatorSaveItem_Click(sender,e);
                Atualizar_grid();

	        }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor form = new FrmCadFornecedor();
            form.ShowDialog();
            fornecedorTableAdapter.Fill(lojaDataSet.fornecedor);
            comboFornecedor.SelectedValue = VariaveisGlobais.CodigoLocalizado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProduto form = new FrmProduto();
            form.ShowDialog();
        }
    }
}
