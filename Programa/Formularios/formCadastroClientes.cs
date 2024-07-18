using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Classes;

namespace Programa.Formularios
{
    public partial class formCadastroClientes : Form
    {
        public formCadastroClientes()
        {
            InitializeComponent();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCpfeCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Defensivas, caso o usuario não preencher algum campo

            if (string.IsNullOrEmpty(cboTipo.Text))
            {
                MessageBox.Show("Informe se o cliente é: Pessoa Fisica ou Juridica", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Infor o nome do cliente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCpfeCnpj.Text == "")
            {
                MessageBox.Show("Informe o CPF ou CNPJ do cliente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mskTelefone.Text.Length >3 && mskCelular.Text == "")
            {
                MessageBox.Show("Infome pelo menos 1 numero para contato ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text == "" )
            {
                MessageBox.Show("O endereço de e-mail não foi informado", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtEndereco.Text == "" && txtN.Text == "" && txtBairro.Text == "" && txtMunicipio.Text == "" && mskCep.Text == "" && cboUf.Text == "")
            {
                MessageBox.Show("Verifique os campos de endereços se estão devidamente preenchido", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Caso esteja tudo ok, ele passara e cadastra o cliente no banco

            try
            {
                // Criar uma instância da classe CadastrarClientes, passando o formulário atual
                CadastrarClientes cadastrarClientes = new CadastrarClientes(this);

                // Chamar o método CadClientes para inserir os dados no banco de dados
                cadastrarClientes.CadClientes();

                MessageBox.Show("Cliente cadastrado com sucesso!", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao cadastrar Cliente: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
