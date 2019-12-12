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
    public partial class Manutencao : Form
    {
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Manutencao()
        {
            InitializeComponent();
        }

        private void Manutencao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.tccUltimate.Veiculo);
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Manutencao'. Você pode movê-la ou removê-la conforme necessário.
            this.manutencaoTableAdapter.Fill(this.tccUltimate.Manutencao);
            comando.Connection = conn;
            CarregarDados();
            cbPlaca.SelectedIndex = -1;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }
        private void CarregarDados()
        {
            conn.Open();
            SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Manutencao", conn);
            DataTable dtbl = new DataTable();
            SqlDa.Fill(dtbl);
            gridManutencao.DataSource = dtbl;
            conn.Close();
        }
        private void LimparDados()
        {
            txtCod.Text = "";
            dataManu.Text = "";
            cbPlaca.SelectedIndex = -1;
            cbPreventiva.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           try
            {
                conn.Open();
                comando.CommandText = "select * from Manutencao where placa_veiculo = '" + cbPlaca.Text + "'";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Não foi possivel inserir, dados existentes.");
                    conn.Close();
                }
                
                else {
                    conn.Close();
                    conn.Open();
                    comando.CommandText = "insert into Manutencao (placa_veiculo,data_manutencao, manutencao_preventiva,status_manutencao) values ('" +cbPlaca.Text  + "','" + dataManu.Text + "','" + cbPreventiva.Text + "','" + cbStatus.Text + "') select * from Veiculo where placa_veiculo ='" + cbPlaca.Text + "'";
                    comando.ExecuteNonQuery();
                    conn.Close();
                    LimparDados();
                    CarregarDados();
                    Close();
                }
                    
                
            }
           catch (Exception)
            {

                MessageBox.Show("Verifique os dados informados.","ERRO!");
            }
            
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "Update Manutencao set data_manutencao='" + dataManu.Text + "',manutencao_preventiva='" + cbPreventiva.Text + "',status_manutencao='" + cbStatus.Text + "' where placa_veiculo='"+cbPlaca.Text+"'";
            comando.ExecuteNonQuery();
            conn.Close();
            CarregarDados();
            LimparDados();
            cbPlaca.Enabled = true;
        }

        private void GridManutencao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridManutencao.Rows[e.RowIndex];
            txtCod.Text = row.Cells[0].Value.ToString();
            dataManu.Text = row.Cells[1].Value.ToString();       
            cbPreventiva.Text = row.Cells[2].Value.ToString();
            cbStatus.Text = row.Cells[3].Value.ToString();
            cbPlaca.Text = row.Cells[4].Value.ToString();
            cbPlaca.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                comando.CommandText = "DELETE From Manutencao WHERE cod_manutencao = " + gridManutencao.CurrentRow.Cells[0].Value;
                comando.ExecuteNonQuery();
                conn.Close();
                CarregarDados();
                LimparDados();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                cbPlaca.Enabled = true;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            cbPlaca.Enabled = true;
        }
    }
    
}
