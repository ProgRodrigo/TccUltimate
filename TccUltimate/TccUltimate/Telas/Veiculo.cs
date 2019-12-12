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
    public partial class Veiculo : Form
    {
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Veiculo()
        {
            InitializeComponent();
        }

        private void Veiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccUltimate.Veiculo'. Você pode movê-la ou removê-la conforme necessário.
            this.veiculoTableAdapter.Fill(this.tccUltimate.Veiculo);
            btnExcluirVei.Enabled = false;
            btnAlterar.Enabled = false;
            comando.Connection = conn;
            CarregarDados();
            
        }
        private void CarregarDados()
        {
            conn.Open();
            SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Veiculo", conn);
            DataTable dtbl = new DataTable();
            SqlDa.Fill(dtbl);

            gridVeiculo.DataSource = dtbl;
            conn.Close();

        }

        private void BtnSalvarVei_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                comando.CommandText = "INSERT INTO Veiculo (placa_veiculo,tipo_veiculo, modelo_veiculo, Ano_veiculo,seguro_veiculo) VALUES ('" + txtPlaca.Text + "','" +cbTipo.Text + "','" + txtModeloVei.Text + "','"+txtAno.Text+"','" + cbSeguro.Text + "')";
                comando.ExecuteNonQuery();
                LimparDados();
                Manutencao man = new Manutencao();
                man.Show();


            }
            catch (Exception)
            {

                MessageBox.Show("ERRO: Verifique se todos os campos foram informados corretamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            finally
            {
                conn.Close();
                CarregarDados();
                txtPlaca.Enabled = true;
            }
        }

        

        private void BtnBuscarVei_Click(object sender, EventArgs e)

        {
            if (rbTodos.Checked)
            {
                txtPesquisaVei.Text = "";
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Veiculo", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                gridVeiculo.DataSource = dtbl;
            }
            else if (rbPlaca.Checked)
            {
                SqlDataAdapter SqlDa = new SqlDataAdapter("Select * from Veiculo WHERE placa_veiculo LIKE  '%" + txtPesquisaVei.Text + "%' ", conn);
                DataTable dtbl = new DataTable();
                SqlDa.Fill(dtbl);

                gridVeiculo.DataSource = dtbl;
            }
           else  if (rbModelo.Checked)
            {
                SqlDataAdapter SqlDa = new SqlDataAdapter("Select * from Veiculo WHERE modelo_veiculo LIKE  '%" + txtPesquisaVei.Text + "%' ", conn);
                DataTable dtbl = new DataTable();
                SqlDa.Fill(dtbl);
                gridVeiculo.DataSource = dtbl;
            }
            if (txtPesquisaVei.Text != "" && rbPlaca.Checked == false && rbModelo.Checked == false)
            {
                MessageBox.Show("Selecione uma categoria!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (txtPesquisaVei.Text == "" && rbPlaca.Checked== false && rbModelo.Checked == false && rbTodos.Checked == false)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Veiculo", conn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
            }
            rbModelo.Checked = false;
            rbPlaca.Checked = false;
            rbTodos.Checked = false;

        }
        private void GridVeiculo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnSalvarVei.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluirVei.Enabled = true;
            DataGridViewRow row = gridVeiculo.Rows[e.RowIndex];
            txtPlaca.Text = row.Cells[0].Value.ToString();
            cbTipo.Text = row.Cells[1].Value.ToString();
            txtModeloVei.Text = row.Cells[2].Value.ToString();
            txtAno.Text = row.Cells[3].Value.ToString();
            cbSeguro.Text = row.Cells[4].Value.ToString();
            txtPlaca.Enabled = false;
          
        }

        private void BtnExcluirVei_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza? Todos os dados relacionados a esse Veiculo será apagado permanentemente.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                comando.CommandText = "DELETE From Veiculo WHERE ano_veiculo = " + gridVeiculo.CurrentRow.Cells[3].Value;
                comando.ExecuteNonQuery();
                conn.Close();
                CarregarDados();
                LimparDados();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            conn.Open();
            comando.CommandText = "Update Veiculo set tipo_veiculo='" + cbTipo.Text + "', modelo_veiculo='" + txtModeloVei.Text + "', Ano_veiculo='" + txtAno.Text + "',seguro_veiculo= '" + cbSeguro.Text + "' where placa_veiculo='"+txtPlaca.Text+"'";
            comando.ExecuteNonQuery();
            LimparDados();
            conn.Close();
            CarregarDados();
            txtPlaca.Enabled = true;
           
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            btnExcluirVei.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvarVei.Enabled = true;
            txtPlaca.Enabled = true;


        }
        private void LimparDados()
        {
            txtModeloVei.Text = "";
            txtPlaca.Text = "";
            txtAno.Text = "";
            cbTipo.SelectedIndex = -1;
            cbSeguro.SelectedIndex = -1;
        }        
    }
}
