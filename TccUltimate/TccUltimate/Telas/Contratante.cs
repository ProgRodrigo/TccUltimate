using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace teste
{
    public partial class Contratante : Form
    {
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Contratante()
        {
            InitializeComponent();
        }
     
        private void CarregarDados()
        {
            conn.Open();
            SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Contratante", conn);
            DataTable dtbl = new DataTable();
            SqlDa.Fill(dtbl);

            gridContratante.DataSource = dtbl;
            conn.Close();

        }

        private void Contratante_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Contratante'. Você pode movê-la ou removê-la conforme necessário.
            this.contratanteTableAdapter.Fill(this.tccUltimate.Contratante);
            comando.Connection = conn;
            CarregarDados();
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluirCli.Enabled = false;
        }

        private void BtnSalvarCon_Click_1(object sender, EventArgs e)
        {
           try
           {             
                conn.Open();
                comando.CommandText = "INSERT INTO Contratante (nome_contratante, cnpj_contratante,email_contratante,telefone_contratante,data_contratacao) VALUES ('" + txtNomeCon.Text + "','" + txtCnpj.Text + "','" + txtEmailCon.Text + "','" + txtCeluCon.Text + "','" + txtContratacao.Text + "')";
                comando.ExecuteNonQuery();
                LimparDados();                
           }
            catch (Exception)
           {

                MessageBox.Show("Verifique os dados informados!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            finally
           {
                conn.Close();
                CarregarDados();
           }
        }
        //Mostrar dados nos Text's
        private void GridContratante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridContratante.Rows[e.RowIndex];
            txtCod.Text = row.Cells[0].Value.ToString();
            txtNomeCon.Text = row.Cells[1].Value.ToString();
            txtCnpj.Text = row.Cells[2].Value.ToString();
            txtEmailCon.Text = row.Cells[3].Value.ToString();
            txtCeluCon.Text = row.Cells[4].Value.ToString();
            txtContratacao.Text = row.Cells[5].Value.ToString();
            btnSalvarCon.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluirCli.Enabled = true;
        }

        private void BtnExcluirCli_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Tem certeza? Todos os dados relacionados a este cliente serão apagados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                comando.CommandText = " Delete from Contratante WHERE cod_contratante =" + gridContratante.CurrentRow.Cells[0].Value;
                comando.ExecuteNonQuery();
                conn.Close();
                CarregarDados();
                LimparDados();
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            btnSalvarCon.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluirCli.Enabled = false;
            LimparDados();
        }
        public void LimparDados()
        {
            txtCod.Text = "";
            txtNomeCon.Text = "";
            txtEmailCon.Text = "";
            txtContratacao.Text = "";
            txtCnpj.Text = "";
            txtCeluCon.Text = "";
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "Update Contratante set nome_contratante ='"+txtNomeCon.Text+"',cnpj_contratante='"+txtCnpj.Text+"',email_contratante='"+txtEmailCon.Text+"',telefone_contratante='"+txtCeluCon.Text+"',data_contratacao='"+txtContratacao.Text+"' where cod_contratante='"+txtCod.Text+"'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarDados();
            LimparDados();
        }
         }
}
