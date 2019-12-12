using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            Veiculo veiculo2 = new Veiculo();
            veiculo2.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Funcionario novoMotorista = new Funcionario();
            novoMotorista.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Viagens novaViagem = new Viagens();
            novaViagem.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Veiculo novoVeiculo = new Veiculo();
            novoVeiculo.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Financas addFinancas = new Financas();
            addFinancas.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indisponível", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Contratante addCliente = new Contratante();
            addCliente.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnManutencao_Click(object sender, EventArgs e)
        {
            Manutencao manu = new Manutencao();
            manu.Show();
        }
    }
}
