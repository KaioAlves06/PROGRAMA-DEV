using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa.Formularios
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            customizarmenu();
        }

        private void customizarmenu()
        {
            // Ocultando os painel de dub menu
            menuCadastro.Visible = false;
            menuCadastro2.Visible = false;
        }
        private void ocultarSubMenu()
        {
            if (menuCadastro.Visible == true)
            {
                menuCadastro.Visible = false;
            }
            if(menuCadastro2.Visible == true)
            {
                menuCadastro2.Visible = false;
            }

        }
        
        private void abrirMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true; 
            }
            else 
                subMenu.Visible = false;
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Abrir o menu ao clicar no botão 
            abrirMenu(menuCadastro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirMenu(menuCadastro2);
        }
    }
}
