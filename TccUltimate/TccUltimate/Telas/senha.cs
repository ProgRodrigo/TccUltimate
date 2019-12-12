using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace teste
{
    public partial class Senha : Form
    {
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Senha()
        {
            InitializeComponent();
        }

        private void BtnCadastrarSenha_Click(object sender, EventArgs e)
        {
            if (txtUsu.Text == "" || txtSenhaAtual.Text == "" || txtNewSenha.Text == "")
            {

                MessageBox.Show("Preencha todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtUsu.Text == "") { lbUsu.Visible = true; }
                else { lbUsu.Visible = false; }
                if (txtSenhaAtual.Text == "") { lbAtual.Visible = true; }
                else { lbAtual.Visible = false; }
                if (txtNewSenha.Text == "") { lbNew.Visible = true; }
                else { lbNew.Visible = false; }
                if (txtConfirmaNewSenha.Text == "") { lbCon.Visible = true; }
                else { lbCon.Visible = false; }
            }

            else
            {
                if(txtConfirmaNewSenha.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos!","ERRO",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtConfirmaNewSenha.Text == "") { lbCon.Visible = true; }
                    
                }
                else { lbCon.Visible = false; }
                lbNew.Visible = false;
                
            }
            conn.Open();
            comando.CommandText = "Select * from Usuario WHERE usuario =  '" + txtUsu.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                    conn.Close();
                    conn.Open();
                comando.CommandText = "Select * from Usuario where senha = '" + txtSenhaAtual.Text + "'";
                dr = comando.ExecuteReader();
                if (dr.HasRows){
                    conn.Close();
                    if (txtSenhaAtual.Text == txtNewSenha.Text)
                    {
                        MessageBox.Show("Esta senha já esta sendo utilizada", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    if (txtNewSenha.Text != txtConfirmaNewSenha.Text && txtConfirmaNewSenha.Text != "")
                    {
                        MessageBox.Show("Senhas não coincidem!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                  
                    if (txtSenhaAtual.Text != txtNewSenha.Text && txtNewSenha.Text == txtConfirmaNewSenha.Text)
                    {
                        if (txtNewSenha.Text != "")
                        {
                            conn.Open();
                            comando.CommandText = "UPDATE Usuario set senha= '" + txtNewSenha.Text + "' where usuario ='" + txtUsu.Text + "'";
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Senha alterada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                   
                }
                else if (txtSenhaAtual.Text != "")
                {
                       MessageBox.Show("Senha atual inexistente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
                conn.Close();
            }           
            conn.Close();
        }

        private void Senha_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
        }
        public void LimparSenhas()
        {
            txtSenhaAtual.Text = "";
            txtNewSenha.Text = "";
            txtConfirmaNewSenha.Text = "";
        }
    }
}
