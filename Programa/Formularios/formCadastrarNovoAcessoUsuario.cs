using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Classes;

namespace Programa.Formularios
{
    public partial class formCadastrarNovoAcessoUsuario : Form
    {
        public formCadastrarNovoAcessoUsuario()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        
            CadastrarAcessoUsuario cadastrarUser = new CadastrarAcessoUsuario(this);
            cadastrarUser.CadastroUsuario();
           
            MessageBox.Show("Usuário cadastrado com sucesso!", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUser_Click(object sender, EventArgs e)
        {
            if (txtNomeUser.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome do Usuário", "ERRO", MessageBoxButtons.OK);
                return;
            }

            if (txtSenhaUser.Text.Trim() == "")
            {
                MessageBox.Show("Informe a senha do Usuário", "ERRO", MessageBoxButtons.OK);
                return ;
            }
            if (txtSenhaUser2.Text.Trim() == "")
            {
                MessageBox.Show("Confirme a senha", "ERRO", MessageBoxButtons.OK);
                return;
            }
            if (txtSenhaUser.Text.Trim() != txtSenhaUser2.Text)
            {
                MessageBox.Show("As senhas estão diferentes, favor revisar", "ERRO", MessageBoxButtons.OK);
                return;
            }
                           
            
                CadastrarAcessoUsuario cadastrarUser = new CadastrarAcessoUsuario(this);
                cadastrarUser.CadastroUsuario();

                MessageBox.Show("Usuário cadastrado com sucesso!", "CADASTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }
    }
}
