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
using Programa.Classes;
using Programa.Formularios;

namespace Programa
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Testar se está conectando com o banco de dados
                using (SqlConnection cn = new SqlConnection(Conectarbanco.Cn))
                {
                    cn.Open();
                    MessageBox.Show("Sucesso ao se conectar com o banco", "TUDO OK");
                }
            }
            // se não conectar, ex retornará o erro
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao entrar no banco " + ex.Message);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = new formCadastroClientes();
            n.ShowDialog();
        }
    }


}

