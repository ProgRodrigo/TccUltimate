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
    
    public partial class Financas : Form
    {
        float semMulta = 0;
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Financas()
        {
            InitializeComponent();
        }            
        private void Financas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Viagem'. Você pode movê-la ou removê-la conforme necessário.
            this.viagemTableAdapter.Fill(this.tccUltimate.Viagem);
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.tccUltimate.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Gastos'. Você pode movê-la ou removê-la conforme necessário.
            this.gastosTableAdapter.Fill(this.tccUltimate.Gastos);           
            comando.Connection = conn;
            CarregarDados();
            btnAtualizar.Enabled = false;
            btnNovo.Enabled = false;
            cbFuncionario.SelectedIndex = -1;
            cbViagem.SelectedIndex = -1;
        }

        private void RbSim_Click(object sender, EventArgs e)
        {
            txtMulta.Enabled = true;
        }

        private void RbNao_Click(object sender, EventArgs e)
        {
            txtMulta.Enabled = false;
        }

        private void BtnFinaizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rbSim.Checked == true)
                {
                    ReplaceDados();
                    conn.Open();
                    comando.CommandText = "Insert Into Gastos (gasolina,pedagio,data_multa,valor_multa,manutencao_corretiva,cod_funcionario,cod_viagem)Values ('" + txtGasolina.Text + "','" + txtPedagio.Text + "','" + txtData.Text + "','" + txtMulta.Text + "','" + txtManutencao.Text + "','" + cbFuncionario.Text + "','" + cbViagem.Text + "')";
                    comando.ExecuteNonQuery();
                    conn.Close();
                    LimparDados();
                }
                else
                {

                    conn.Open();
                    ReplaceDados();
                    comando.CommandText = "Insert Into Gastos (gasolina,pedagio,data_multa,valor_multa,manutencao_corretiva,cod_funcionario,cod_viagem)Values ('" + txtGasolina.Text + "','" + txtPedagio.Text + "','" + txtData.Text + "','" + semMulta + "','" + txtManutencao.Text + "','" + cbFuncionario.Text + "','" + cbViagem.Text + "')";
                    comando.ExecuteNonQuery();
                    conn.Close();
                    CarregarDados();
                    LimparDados();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os dados informados!");
            }          


        }
        private void CarregarDados()
        {
            conn.Open();
            SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Gastos", conn);
            DataTable dtbl = new DataTable();
            SqlDa.Fill(dtbl);
            gridFinancas.DataSource = dtbl;
            conn.Close();
        }

        private void LimparDados()
        {
            rbSim.Checked = false;
            rbNao.Checked = false;
            txtCodGastos.Text = "";
            txtGasolina.Text = "";
            txtPedagio.Text = "";
            txtData.Text = "";
            txtMulta.Text = "";
            txtManutencao.Text = "";
            cbFuncionario.SelectedIndex = -1;
            cbViagem.SelectedIndex = -1;
        }
        private void ReplaceDados()
        {
            txtMulta.Text = txtMulta.Text.Replace(",", ".");
            txtGasolina.Text = txtGasolina.Text.Replace(",", ".");
            txtPedagio.Text = txtPedagio.Text.Replace(",", ".");
            txtManutencao.Text = txtManutencao.Text.Replace(",", ".");
        }
     

        private void GridFinancas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFinaizar.Enabled = false;
            btnAtualizar.Enabled = true;
            btnNovo.Enabled = true;
            if(txtMulta.Text != "0"){
                rbSim.Checked = true;
            }
            else
            {
                rbNao.Checked = true;
            }
            DataGridViewRow row = gridFinancas.Rows[e.RowIndex];
            txtCodGastos.Text = row.Cells[0].Value.ToString();
            txtGasolina.Text = row.Cells[1].Value.ToString();
            txtPedagio.Text = row.Cells[2].Value.ToString();
            txtData.Text = row.Cells[3].Value.ToString();
            txtMulta.Text = row.Cells[4].Value.ToString();
            txtManutencao.Text = row.Cells[5].Value.ToString();
            cbFuncionario.Text = row.Cells[6].Value.ToString();
            cbViagem.Text = row.Cells[7].Value.ToString();
            
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = false;
            btnFinaizar.Enabled = true;
            LimparDados();
        }

        private void BtnBuscaGasto_Click(object sender, EventArgs e)
        {
            if (txtPesqViagem.Text != "")
            {
                conn.Open();
                comando.CommandText = "Select* from Gastos where cod_viagem = '" + txtPesqViagem.Text + "'";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    conn.Close();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Gastos where cod_viagem = '" + txtPesqViagem.Text + "'", conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    gridFinancas.DataSource = dtbl;
                }
                else
                {
                    MessageBox.Show("Não encontrado!");
                    conn.Close();
                }

            }
            else if (txtPesqViagem.Text == "")
            {
                MessageBox.Show("Dados ausentes para realizar a busca!");
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            conn.Open();
            ReplaceDados();
            comando.CommandText= "Update Gastos set gasolina='"+txtGasolina.Text+"',pedagio='"+txtPedagio.Text+"',data_multa='"+txtData.Text+"',valor_multa='"+txtMulta.Text+"',manutencao_corretiva='"+txtManutencao.Text+"' where cod_gastos ='"+txtCodGastos.Text+"'";
            comando.ExecuteNonQuery();           
            conn.Close();
            CarregarDados();
            LimparDados();
           
        }

        private void TxtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtViagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtManutencao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPedagio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
