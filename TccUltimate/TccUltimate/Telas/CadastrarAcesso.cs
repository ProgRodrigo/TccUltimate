using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class CadastrarAcesso : Form
    {
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public CadastrarAcesso()
        {
            InitializeComponent();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "Select * from Usuario WHERE usuario ='" + txtEmail.Text + "'";
            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                MessageBox.Show("Usuario Existente");
                txtEmail.Text = "";
                conn.Close();

            }

            if (txtEmail.Text == "")
            {
                label4.Text = "*Campo Obrigatorio!.".ToString();
            }
            else

                label4.Text = "".ToString();

            if (txtSenha.Text == "" && txtConfirmarSenha.Text == "")
            {
                label6.Text = "*Campo Obrigatorio!. ".ToString();
                label5.Text = "*Campo Obrigatorio!".ToString();
            }
            else { 
                label5.Text = "".ToString();
            label6.Text = "".ToString();
                   }
            if (txtSenha.Text != ""  && txtSenha.Text == txtConfirmarSenha.Text  && txtEmail.Text != "")

            {
                conn.Close();
                conn.Open();
                comando.CommandText = "INSERT INTO Usuario (usuario,senha) Values('"+txtEmail.Text+"','" + txtSenha.Text + "')";
                comando.ExecuteNonQuery();
                MessageBox.Show("Acesso Cadastrado!!", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                Close();
            }
            else if(txtSenha.Text !="" && txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senhas divergentes!");
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                conn.Close();
            }
            conn.Close();
        }

        private void CadastrarAcesso_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
