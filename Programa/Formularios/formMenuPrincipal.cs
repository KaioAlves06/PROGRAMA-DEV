using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa.Formularios
{
    public partial class formMenuPrincipal : Form
    {
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new formCadastroClientes();
            abrir.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new formCadastrarNovoAcessoUsuario();
            abrir.ShowDialog();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new formCadastroClientes();
            abrir.ShowDialog();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var abrir = new formTodosClientes();
            abrir.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new formTodosClientes();
            abrir.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var abrir = new formCadastroClientes();
            abrir.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new formCadastrarNovoAcessoUsuario();
            abrir.ShowDialog();
        }

        private void realizarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrir = new formOrcamentos();
            abrir.ShowDialog();

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void formMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
