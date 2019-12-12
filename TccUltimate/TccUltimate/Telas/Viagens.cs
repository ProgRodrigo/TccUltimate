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
    public partial class Viagens : Form
    {
        string status = "";
        SqlConnection conn = new SqlConnection(EnderecoBD.conexao());
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        public Viagens()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Boolean Disponivel = true;
            string EmAndamento = "Em andamento";
            try
            {           
                conn.Open();
                comando.CommandText = "Select * from Viagem WHERE cod_funcionario =  '" + txtResponViagem.Text + "' and status_viagem='" + EmAndamento + "'";
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Este funcionario já possui uma viagem em andamento!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disponivel = false;
                }
                conn.Close();
                conn.Open();
                comando.CommandText = "Select * from Viagem WHERE placa_veiculo='" + txtVeiculo.Text + "' and status_viagem='" + EmAndamento + "'";
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Este veículo não esta disponível!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Disponivel = false;
                }
                conn.Close();                
                if(Disponivel==true)
                {
                    if (rbAndamento.Checked)
                    { status = "Em andamento"; }
                    if (rbCancelada.Checked)
                    { status = "Cancelada"; }
                    if (rbFinalizada.Checked)
                    { status = "Finalizada"; }
                    conn.Open();
                    comando.CommandText = "Insert into Viagem(destino_viagem,reg_saida,reg_entrada,status_viagem,placa_veiculo,cod_contratante,cod_funcionario) values ('" + txtDestino.Text + "','" + txtSaidaVei.Text + "','" + txtEntradaVei.Text + "','" + status + "','" + txtVeiculo.Text + "','" + txtContratante.Text + "','" + txtResponViagem.Text + "') select * from Contratante where cod_contratante = ('" + txtContratante.Text + "') select * from Veiculo where placa_veiculo= ('" + txtVeiculo.Text + "') select * from Funcionario where cod_funcionario=('" + txtResponViagem.Text + "')";
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Viagem Cadastrada!", "*", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparDados();
                }             
                
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique se todos os dados foram preenchidos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
            

        }
        private void CarregarDados()
        {
            conn.Open();
            SqlDataAdapter SqlDa = new SqlDataAdapter("SELECT * FROM Viagem", conn);
            DataTable dtbl = new DataTable();
            SqlDa.Fill(dtbl);

            gridViagem.DataSource = dtbl;
            conn.Close();

        }
        private void LimparDados() 
            {
                txtCodViagem.Text = "";
                txtDestino.Text = "";
                txtSaidaVei.Text = "";
                txtEntradaVei.Text = "";
                rbFinalizada.Checked = false;
                rbCancelada.Checked = false;
                rbAndamento.Checked = false;
                txtContratante.Text = "";
                txtVeiculo.Text = "";
                txtResponViagem.Text = "";
            } 

        private void Viagens_Load(object sender, EventArgs e)
        {
            
            comando.Connection = conn;
            CarregarDados();
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
           {
                conn.Open();
                if (rbAndamento.Checked)
                { status = "Em andamento"; }

                if (rbCancelada.Checked)
                { status = "Cancelada"; }

                if (rbFinalizada.Checked)
                { status = "Finalizada"; }
                comando.CommandText = "Update  Viagem set destino_viagem = '" + txtDestino.Text + "',reg_saida='" + txtSaidaVei.Text + "', reg_entrada='" + txtEntradaVei.Text + "', status_viagem = '" + status + "' where cod_viagem='" + txtCodViagem.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                CarregarDados();
                MessageBox.Show("Atualizado!", "*", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
            lbCod.Visible = false;
            txtCodViagem.Visible = false;
                txtVisualizar.Text = "";      
           }
            catch (Exception)
            {

                MessageBox.Show("Verifique os dados informados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void BtnBuscarViagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbEntrada.Checked == false && rbSaida.Checked == false)
                {
                    if (cbStatus.Text != "")
                    {

                        if (cbStatus.Text == "Em andamento")
                        {

                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * From Viagem where status_viagem ='" + cbStatus.Text + "'", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }
                        if (cbStatus.Text == "Cancelada")
                        {

                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Viagem where status_viagem ='" + cbStatus.Text + "'", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }
                        if (cbStatus.Text == "Finalizada")
                        {
                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Viagem where status_viagem='" + cbStatus.Text + "'", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }
                        if (cbStatus.Text == "Todos")
                        {
                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Viagem", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }
                    }
                    
                }
                if (rbSaida.Checked)
                {
                    if (txtEntrada.Text != "" && txtSaida.Text != "" && cbStatus.Text != "")
                    {
                        if (cbStatus.Text == "Todos")
                        {
                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Viagem where reg_saida between '" + txtSaida.Text + "'AND'" + txtEntrada.Text + "'", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }
                        else
                        { 
                        conn.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Viagem where reg_saida between '" + txtSaida.Text + "'AND'" + txtEntrada.Text + "' and status_viagem ='" + cbStatus.Text + "'", conn);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);
                        gridViagem.DataSource = dtbl;
                        conn.Close();
                        }
                    }
                }
                if (rbEntrada.Checked)
                {
                    if (txtEntrada.Text != "" && txtSaida.Text != "" && cbStatus.Text != "")
                    {
                        if (cbStatus.Text == "Todos")
                        {
                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Viagem where reg_entrada between '" + txtSaida.Text + "'AND'" + txtEntrada.Text + "'", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }

                        else
                        {
                            conn.Open();
                            SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Viagem where reg_entrada between '" + txtSaida.Text + "'AND'" + txtEntrada.Text + "' and status_viagem ='" + cbStatus.Text + "'", conn);
                            DataTable dtbl = new DataTable();
                            sqlDa.Fill(dtbl);
                            gridViagem.DataSource = dtbl;
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os dados corretamente");
            }
        }
        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                comando.CommandText = "Select * from Viagem WHERE cod_viagem =  '" + txtVisualizar.Text + "'";
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    txtCodViagem.Text = Convert.ToString(dr["cod_viagem"]);
                    txtDestino.Text = Convert.ToString(dr["destino_viagem"]);
                    txtSaidaVei.Text = Convert.ToString(dr["reg_saida"]);
                    txtEntradaVei.Text = Convert.ToString(dr["reg_entrada"]);
                    txtContratante.Text = Convert.ToString(dr["cod_contratante"]);
                    txtVeiculo.Text = Convert.ToString(dr["placa_veiculo"]);
                    txtResponViagem.Text = Convert.ToString(dr["cod_funcionario"]);                    
                    status = Convert.ToString(dr["status_viagem"]);
                    if (status == "Em andamento") { rbAndamento.Checked = true; }
                    if (status == "Cancelada") { rbCancelada.Checked = true; }
                    if (status == "Finalizada") { rbFinalizada.Checked = true; }
                    conn.Close();
                    lbCod.Visible = true;
                    txtCodViagem.Visible = true;
                    btnAlterar.Enabled = true;
                    btnRegistrar.Enabled = false;
                    btnNovo.Enabled = true;
                    txtContratante.Enabled = false;
                    txtResponViagem.Enabled = false;
                    txtVeiculo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique o código informado.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        
        private void GridViagem_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RbSaida_Click(object sender, EventArgs e)
        {
            rbEntrada.Checked = false;
            txtEntrada.Enabled = true;
            txtSaida.Enabled = true;
        }

        private void RbEntrada_Click(object sender, EventArgs e)
        {
       
            rbSaida.Checked = false;
            txtEntrada.Enabled = true;
            txtSaida.Enabled = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = true;
            btnAlterar.Enabled = false;
            LimparDados();
            lbCod.Visible = false;
            txtCodViagem.Visible = false;
        }
    }
}
