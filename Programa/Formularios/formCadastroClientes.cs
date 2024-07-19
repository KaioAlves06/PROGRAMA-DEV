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

            if (cboTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Informe se o cliente é: Pessoa Fisica ou Juridica", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Informe o nome do cliente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCpfeCnpj.Text.Trim() == "")
            {
                MessageBox.Show("Informe o CPF ou CNPJ do cliente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCpfeCnpj.Text.Trim().Length < 11)
            {
                MessageBox.Show("Para CPF informe os 11 digitos ou 14 digitos para CNPJ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mskTelefone.Text.Trim().Length < 14 && mskCelular.Text.Trim().Length < 15)
            {
                MessageBox.Show("Infome pelo menos 1 numero para contato ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEndereco.Text.Trim() == "" || txtN.Text.Trim() == "" || txtBairro.Text.Trim() == "" || txtMunicipio.Text.Trim() == "" || mskCep.Text.Trim().Length < 9 || cboUf.SelectedIndex == 0)
            {
                MessageBox.Show("Verifique os campos de endereços se estão devidamente preenchido", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text.Trim() == "")
            {
                if (MessageBox.Show("Deseja informar o e-mail ? ", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtEmail.BackColor = Color.Yellow;
                    return;
                }

                // se o e-mail estiver vázio, vai perguntar se o usuário deseja informar, se ele clicar em sim vai retornar "MessageBoxButtons.YesNo,
                // MessageBoxIcon.Question) == DialogResult.Yes)"

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

        private void txtCpfeCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas dígitos (0-9), tecla Backspace e teclas de controle (como Ctrl+C, Ctrl+V)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado
            }
        }

        private void formCadastroClientes_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            cboUf.SelectedIndex = 0;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }
    }
}
