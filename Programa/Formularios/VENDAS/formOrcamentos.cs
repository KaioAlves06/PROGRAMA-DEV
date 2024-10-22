﻿using System;
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

namespace Programa.Formularios
{
    public partial class formOrcamentos : Form
    {
        public formOrcamentos()
        {
            InitializeComponent();
        }

        private void formOrcamentos_Load(object sender, EventArgs e)
        {
            // Obtém a data atual
            DateTime dataAtual = DateTime.Now;

            // Calcula a data que é 5 dias após a data atual
            DateTime dataValidade = dataAtual.AddDays(5);

            mskDataOrcamento.Text = dataAtual.ToString("dd/MM/yyyy");
            mskDataValidade.Text = dataValidade.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCpfCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void mskDataOrcamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conectarbanco.Cn))
                    {
                        cn.Open();

                        // Usar uma consulta parametrizada para evitar SQL Injection
                        var sql = "SELECT * FROM PRODUTOS WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            // Adicionar o parâmetro com o valor do TextBox
                            cmd.Parameters.AddWithValue("@ID", txtCodProduto.Text);

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    da.Fill(dt);
                                    dtOrcamento.DataSource = dt;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao trazer consulta: " + ex.Message);
                }
            }

        }
    }
}









