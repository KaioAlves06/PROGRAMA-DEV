using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa.Formularios.CADASTRO
{
    public partial class formCadastroProdutos: Form
    {
        public formCadastroProdutos()
        {
            InitializeComponent();
        }

        private void mskCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto cadastrado com Sucesso !","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
