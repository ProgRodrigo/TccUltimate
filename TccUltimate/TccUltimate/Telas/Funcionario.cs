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

namespace teste
{
    public partial class Funcionario : Form
    {

        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public Funcionario()
        {
            InitializeComponent();
        }

   
        private void GridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridFuncionario.Rows[e.RowIndex];
            txtCodFun.Text = row.Cells[0].Value.ToString();
            cbCargo.Text = row.Cells[1].Value.ToString();
            txtNomeFuncio.Text = row.Cells[2].Value.ToString();
            dataFun.Text = row.Cells[3].Value.ToString();
            cbHab.Text = row.Cells[4].Value.ToString();
            txtCelular.Text = row.Cells[5].Value.ToString();
            txtCpf.Text = row.Cells[6].Value.ToString();
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza? Todos os dados relacionados a este funcionario serão apagados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                conn.Open();
                comando.CommandText = "DELETE From Funcionario where cod_funcionario=" + gridFuncionario.CurrentRow.Cells[0].Value;
                comando.ExecuteNonQuery();
                conn.Close();
                CarregarDados();
                LimparDados();
            }
            
        }
        private void CarregarDados()
        {
           
            conn.Open();
            SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Funcionario", conn);
            DataTable dtbl = new DataTable();
            SqlDa.Fill(dtbl);

            gridFuncionario.DataSource = dtbl;
            conn.Close();

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter3.Fill(this.tccUltimate.Funcionario);
            comando.Connection = conn;
            CarregarDados();
            cbCargo.ResetText();
            cbHab.ResetText();
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

  

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           try
            {
                conn.Open();
                comando.CommandText = "INSERT INTO Funcionario (cargo, nome_funcionario, dtnasc_funcionario,cnh_funcionario,tel_funcionario,cpf_funcionario) VALUES ('" + cbCargo.Text + "','" + txtNomeFuncio.Text + "','" + dataFun.Text + "','" + cbHab.Text + "','" + txtCelular.Text + "','" + txtCpf.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                CadastrarAcesso cds = new CadastrarAcesso();
                cds.Show();
             }
            catch (Exception)
            {

               MessageBox.Show("Verifique se todos os dados foram preenchidos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
               if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            
              LimparDados();
                CarregarDados();
            }

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "Update  Funcionario set cargo = '" + cbCargo.Text + "',nome_funcionario='" + txtNomeFuncio.Text + "', dtnasc_funcionario='" + dataFun.Text + "', cnh_funcionario='" + cbHab.Text + "',tel_funcionario= '" + txtCelular.Text + "', cpf_funcionario ='" + txtCpf.Text + "'  where cod_funcionario = ('" + txtCodFun.Text + "')";
            comando.ExecuteNonQuery();
            LimparDados();
            conn.Close();
            CarregarDados();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            txtBusca.Text = "";
            CarregarDados();
        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            if(txtBusca.Text != "")
            {
                conn.Open();
                comando.CommandText = "Select* from Funcionario where cod_Funcionario = '" + txtBusca.Text + "'";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    conn.Close();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Funcionario where cod_Funcionario = '" + txtBusca.Text + "'", conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    gridFuncionario.DataSource = dtbl;
                }
                else
                {
                    MessageBox.Show("Não encontrado!");
                    conn.Close();
                }

            }
            else if(txtBusca.Text == "")
            {
                MessageBox.Show("Dados ausentes para realizar a busca!");
            }
            btnNovo.Enabled = true;
           
        }

        private void CbHab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LimparDados()
        {
            txtCodFun.Text = "";
            cbCargo.SelectedIndex = -1;
            txtNomeFuncio.Text = "";
            dataFun.Text = "";
            cbHab.SelectedIndex = -1;
            txtCelular.Text = "";
            txtCpf.Text = "";
        }

        private void GridFuncionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridFuncionario.Rows[e.RowIndex];
            txtCodFun.Text = row.Cells[0].Value.ToString();
            cbCargo.Text = row.Cells[1].Value.ToString();
            txtNomeFuncio.Text = row.Cells[2].Value.ToString();
            dataFun.Text = row.Cells[3].Value.ToString();
            cbHab.Text = row.Cells[4].Value.ToString();
            txtCelular.Text = row.Cells[5].Value.ToString();
            txtCpf.Text = row.Cells[6].Value.ToString();
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnSalvar.Enabled = false;
        }
    }
}
