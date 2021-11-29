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
    public partial class FrmVenda : Form
    {

        int codItemRemover = 0,qtdRemover=0,codProdutoRemover;

        public FrmVenda()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);
            try
            {
                this.Validate();
                this.vendaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.lojaDataSet);
                MessageBox.Show("Registro Salvo", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GroupBox1.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o registro" + ex.Message, "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.conta_receber' table. You can move, or remove it, as needed.
            this.conta_receberTableAdapter.Fill(this.lojaDataSet.conta_receber);
            // TODO: This line of code loads data into the 'lojaDataSet.View_TotalVenda' table. You can move, or remove it, as needed.
            this.view_TotalVendaTableAdapter.Fill(this.lojaDataSet.View_TotalVenda);
            // TODO: This line of code loads data into the 'lojaDataSet.itens_venda' table. You can move, or remove it, as needed.
            this.itens_vendaTableAdapter.Fill(this.lojaDataSet.itens_venda);
            // TODO: This line of code loads data into the 'lojaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.lojaDataSet.produto);
            // TODO: This line of code loads data into the 'lojaDataSet.produto' table. You can move, or remove it, as needed.
            this.viewItensVendaTableAdapter.Fill(this.lojaDataSet.ViewItensVenda);
            // TODO: This line of code loads data into the 'lojaDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.lojaDataSet.funcionario);
            // TODO: This line of code loads data into the 'lojaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lojaDataSet.cliente);
            // TODO: This line of code loads data into the 'lojaDataSet.venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.lojaDataSet.venda);

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            ComboCliente.SelectedValue = 1;
            dta_vendaMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            tipo_vendaComboBox.Text = "Aberta";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro atual", "Lavest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vendaBindingSource.RemoveCurrent();
                    vendaTableAdapter.Update(lojaDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não pode ser excluído " + ex.Message);
                this.vendaTableAdapter.Fill(this.lojaDataSet.venda);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            vendaBindingSource.CancelEdit();
            GroupBox1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Atualizar_grid()
        {
            if (cod_vendaTextBox.Text!="")
            {

                produtoTableAdapter.Fill(lojaDataSet.produto);

                viewItensVendaTableAdapter.Fill(lojaDataSet.ViewItensVenda);
                viewItensVendaBindingSource.Filter = "num_venda = " + cod_vendaTextBox.Text;

                view_TotalVendaTableAdapter.Fill(lojaDataSet.View_TotalVenda);
                view_TotalVendaBindingSource.Filter = "num_venda = " + cod_vendaTextBox.Text;

                if (tipo_vendaComboBox.Text=="Finalizada")
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
                viewItensVendaBindingSource.Filter = "num_venda = 0" ;
            }
        }

        private void cod_vendaTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_grid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int qtd, estoque, codprod;
                codprod = int.Parse(txtcodpro.Text);
                qtd = int.Parse(txtqtde.Text);
                estoque = int.Parse(txtestoque.Text);
                if (qtd > estoque)
                {
                    MessageBox.Show("A quantidade informada é maior que o estoque atual", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtqtde.Focus();
                }
                else
                {
                    itens_vendaTableAdapter.InserirItemVenda(int.Parse(txtqtde.Text), decimal.Parse(txtpreco.Text), int.Parse(txtcodpro.Text), int.Parse(cod_vendaTextBox.Text));
                    produtoTableAdapter.BaixaEstoque(qtd, codprod);
                    Atualizar_grid();
                    txtcodpro.Clear();
                    txtNomeProduto.Clear();
                    txtqtde.Clear();
                    txtpreco.Clear();
                    txtestoque.Clear();
                    txtcodpro.Focus();
                }
            }
            catch (Exception)
            {
                
                
            }
           
            
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (codItemRemover==0)
            {
                MessageBox.Show("Clique no item a ser removido", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
	{
                itens_vendaTableAdapter.RemoverItemVenda(codItemRemover);//remover do itens
                produtoTableAdapter.EntradaEstoque(qtdRemover,codProdutoRemover);//volta o estoque
                codProdutoRemover = 0;
                codItemRemover = 0;
                qtdRemover = 0;
                Atualizar_grid();
	}
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            consultarproduto sagula = new consultarproduto();
            sagula.ShowDialog();
            if (VariaveisGlobais.CodigoLocalizado!=0 )
            {
                
                produtoBindingSource.Filter= "cod_prod=" + VariaveisGlobais.CodigoLocalizado;
                DataRowView produto = (DataRowView)produtoBindingSource.Current;
                txtcodpro.Text = VariaveisGlobais.CodigoLocalizado.ToString();
                txtNomeProduto.Text=produto["desc_prod"].ToString();
                txtpreco.Text = produto["valor_venda"].ToString();
                txtestoque.Text = produto["qtd_prod"].ToString();
                txtqtde.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtcodpro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                produtoBindingSource.Filter = "cod_prod=" + txtcodpro.Text;
                if (produtoBindingSource.Count==1)
                {
                    DataRowView produto = (DataRowView)produtoBindingSource.Current;
                    
                    txtNomeProduto.Text = produto["desc_prod"].ToString();
                    txtpreco.Text = produto["valor_venda"].ToString();
                    txtestoque.Text = produto["qtd_prod"].ToString();
                    txtqtde.Focus();    
                }
                else
                {
                    btn_localizar_Click(sender, e);
                }
               
            }
        }

        private void txtqtde_Enter(object sender, EventArgs e)
        {
            
        }

        private void viewItensVendaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                   codItemRemover = int.Parse(viewItensVendaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                   qtdRemover= int.Parse(viewItensVendaDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                   codProdutoRemover = int.Parse(viewItensVendaDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());

            }
            catch (Exception)
            {
                codItemRemover = 0;
                
            }
        }

        private void txtqtde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            if (int.Parse(ComboCliente.SelectedValue.ToString())==1) //se for o cliente venda a vista
            {
                RadioPrazo.Visible = false;
            }
            else
            {
                RadioPrazo.Visible = true;
            }
            
            
            
            radioVista.Checked = true;
            txtValorParcela.Text = totalLabel1.Text;
            txtData.Value = DateTime.Now;
            PanelFinalizar.Visible = true;
            


            
        }

        private void btnOKCONTA_Click(object sender, EventArgs e)
        {

            try
            {
                
            
                if (radioVista.Checked==true) 
                {
                    conta_receberTableAdapter.InserirContaReceber(int.Parse(cod_vendaTextBox.Text), 1, txtData.Value, txtData.Value, decimal.Parse(txtValorParcela.Text), decimal.Parse(txtValorParcela.Text));
                    MessageBox.Show("Recebimento Registrado", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //int QTDparcelas = int.Parse(txtNumeroParcela.Value);
                    for (int i = 1; i <= txtNumeroParcela.Value; i++)
                    {
                        
                        
                        conta_receberTableAdapter.InserirContaReceber(int.Parse(cod_vendaTextBox.Text), i,     txtData.Value.AddMonths(i), null, decimal.Parse(txtValorParcela.Text),null);


                        
                    }


                    MessageBox.Show("Parcela(s) Registrada(s)", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }




                    
            tipo_vendaComboBox.Text = "Finalizada";
            vendaBindingNavigatorSaveItem_Click(sender, e);
            PanelFinalizar.Visible = false;
            Atualizar_grid();

                //limpar as caixas do panel
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Lavest", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void radioVista_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVista.Checked==true)
            {

                txtData.Enabled = false;
                txtNumeroParcela.Enabled = false;

            }
            else
            {
                txtData.Enabled = true;
                txtNumeroParcela.Enabled = true;   
            }

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtArredondamento_TextChanged(object sender, EventArgs e)
        {
            decimal total = 0, arredondar = 0;
            total = decimal.Parse(totalLabel1.Text);
            try
            {
                arredondar = decimal.Parse(txtArredondamento.Text);

            }
            catch (Exception)
            {
                arredondar = 0;

                if (txtNumeroParcela.Value > 1)
                {
                    total = decimal.Parse(txtValorParcela.Text);
                }
                else
                {
                    total = decimal.Parse(totalLabel1.Text);        
                }

                txtValorParcela.Text = total.ToString();
                
            }

            if (arredondar>0)
            {
                //total -= arredondar;
                if (txtNumeroParcela.Value>1)
                {
                    total = decimal.Parse(txtValorParcela.Text);
                    total = total - arredondar;                    
                }
                else
                {
                    total = total - arredondar;                    
                }
                txtValorParcela.Text = total.ToString();
                
            }

        }

        private void txtNumeroParcela_ValueChanged(object sender, EventArgs e)
        {

            decimal total = 0; 
            total = decimal.Parse(totalLabel1.Text);
            try
            {
                total = total / txtNumeroParcela.Value;
                txtValorParcela.Text = total.ToString();
            }
            catch (Exception)
            {
                
                
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itens_vendaTableAdapter.InserirItemVenda(int.Parse(txtqtde.Text), decimal.Parse(txtpreco.Text), int.Parse(txtcodpro.Text), int.Parse(cod_vendaTextBox.Text));
            Atualizar_grid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmCadCliente form = new FrmCadCliente();
            form.ShowDialog();
            clienteTableAdapter.Fill(lojaDataSet.cliente);
            ComboCliente.SelectedValue = VariaveisGlobais.CodigoLocalizado;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCadCliente form = new FrmCadCliente();
            form.ShowDialog();
            clienteTableAdapter.Fill(lojaDataSet.cliente);
            ComboCliente.SelectedValue = VariaveisGlobais.CodigoLocalizado;
        }
    }
}
