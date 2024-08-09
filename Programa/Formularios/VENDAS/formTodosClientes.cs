using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa.Classes;

namespace Programa.Formularios
{
    public partial class formTodosClientes : Form
    {
        public formTodosClientes()
        {
            InitializeComponent();
        }

        private void formTodosClientes_Load(object sender, EventArgs e)
        {
            // Mostrar tabela de clientes do banco de dados.

            try
            {
                using (SqlConnection cn = new SqlConnection(Conectarbanco.Cn))
                {
                    cn.Open();
                    var sql = "SELECT * FROM CLIENTES"; // A query da tabela que irá mostrar

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridClientes.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao trazer consulta" + ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var abrir = new formCadastroClientes();
            abrir.ShowDialog();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridClientes_DoubleClick(object sender, EventArgs e)
        {
            var abrir = new formCadastroClientes();
            abrir.ShowDialog();
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

