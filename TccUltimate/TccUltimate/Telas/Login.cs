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
    public  partial class Login : Form
        
    {
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }


        private void TextBox2_Click(object sender, EventArgs e)
        {
            txtSenhaLogin.Clear();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Senha newSenha = new Senha();
            newSenha.Show();
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuarioLogin.Clear();
        }

        private void BtnFazerLogin_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            comando.CommandText = "Select * from Usuario WHERE usuario =  '" + txtUsuarioLogin.Text + "' and senha = '" + txtSenhaLogin.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {

                Principal prin = new Principal();
                prin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso não permitido!","Bloqueado");
               
            }
            conn.Close();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comando.Connection = conn;
        }

        
    }
}
