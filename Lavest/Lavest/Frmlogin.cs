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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lojaDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.lojaDataSet.usuarios);
            this.AcceptButton = btnlogin;
            this.CancelButton = btnsair;
            tbSenha.Clear();
            tbUsuario.Clear();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string senha = "";



                usuariosBindingSource.Filter = "user_login like '" + tbUsuario.Text + "'";
                if (usuariosBindingSource.Count == 1)
                {
                    DataRowView atual = (DataRowView)usuariosBindingSource.Current;
                    senha = (atual["user_senha"].ToString());
                    VariaveisGlobais.Nivel = atual["user_nivel"].ToString();


                    if (senha == tbSenha.Text)
                    {
                        
                        tbSenha.Clear();
                        tbUsuario.Clear();
                        MessageBox.Show("Logando...", "Lavest - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 menu = new Form1();
                        menu.ShowDialog();
                        this.Show();
                        this.usuariosTableAdapter.Fill(this.lojaDataSet.usuarios);

                    }
                    else
                    {

                        MessageBox.Show("Senha Incorreta", "Lavest - Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbSenha.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Lavest - Informa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbUsuario.Focus();
                    
                }

            }
            catch (Exception Erro)
                
            {

                MessageBox.Show("Erro: " + Erro.Message, "Lavest - Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
