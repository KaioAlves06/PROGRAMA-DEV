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





        private void btnSair_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

   

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            var usuario = txtUsuario.Text.Trim();
            var senha = txtSenha.Text.Trim();

           if(usuario == "KAIO" && senha  == "1234")
            {
                
                var abrir = new formMenuPrincipal();
                abrir.ShowDialog();
                this.Close();
                

            }
           else
            {
                MessageBox.Show("Usuario ou senha estão incorretos","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            

        }
    }
}
